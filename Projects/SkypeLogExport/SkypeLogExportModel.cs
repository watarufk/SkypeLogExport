namespace SkypeLogExport
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel;
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using sds = System.Data.SQLite;

    public class ExportingChannelViewModel
    {
        public bool IsExporting { get; set; }
        public Channel Channel { get; set; }
    }

    public enum ExportingMethod
    {
        OneChannelInOneFile,
        AllChannelsInOneFile
    }
    public class EnumToBooleanConverter : System.Windows.Data.IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string parameterString = parameter as string;
            if (parameterString == null) { return System.Windows.DependencyProperty.UnsetValue; }
            if (Enum.IsDefined(value.GetType(), value) == false) { return System.Windows.DependencyProperty.UnsetValue; }
            object parameterValue = Enum.Parse(value.GetType(), parameterString);
            return parameterValue.Equals(value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string parameterString = parameter as string;
            if (parameterString == null || value.Equals(false)) { return System.Windows.DependencyProperty.UnsetValue; }
            return Enum.Parse(targetType, parameterString);
        }
    }

    public class SkypeLogExportModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            var t = PropertyChanged;
            if (t != null) { t(this, new PropertyChangedEventArgs(propertyName)); }
        }

        public string SkypeDataFolderPath { get; set; }

        string _SkypeMainDbFilePath;
        public string SkypeMainDbFilePath
        {
            get { return _SkypeMainDbFilePath; }
            set { _SkypeMainDbFilePath = value; OnPropertyChanged(nameof(SkypeMainDbFilePath)); }
        }
        public SkypeMainDbDataSet SkypeMainDbDataSet { get; private set; }
        public ChatLogModel ConversionResult { get; private set; }

        public ExportingMethod ExportingMethod { get; set; }
        public ObservableCollection<ExportingChannelViewModel> ExportingChannels { get; private set; }
        ExportingChannelViewModel _CurrentSelectedChannel;
        public ExportingChannelViewModel CurrentSelectedChannel
        {
            get { return _CurrentSelectedChannel; }
            set
            {
                _CurrentSelectedChannel = value;
                OnPropertyChanged(nameof(CurrentSelectedChannel));
                OnPropertyChanged(nameof(CurrentSelectedChannelPersonList));
                OnPropertyChanged(nameof(CurrentSelectedChannelMessageList));
            }
        }
        public List<Person> CurrentSelectedChannelPersonList
        {
            get
            {
                if (_CurrentSelectedChannel == null) { return new List<Person>(); }
                return _CurrentSelectedChannel.Channel.PersonList;
            }
        }
        public List<Message> CurrentSelectedChannelMessageList
        {
            get
            {
                if (_CurrentSelectedChannel == null) { return new List<Message>(); }
                return _CurrentSelectedChannel.Channel.MessageList;
            }
        }

        public bool TryUpdateSkypeMainDbPathAndConvertData()
        {
            SkypeDataFolderPath = "";
            SkypeMainDbFilePath = "";
            string newSkypeDataFolderPath = "";
            if (false)
                newSkypeDataFolderPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Skype");
            else
                newSkypeDataFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (System.IO.Directory.Exists(newSkypeDataFolderPath) == false) { return false; }
            SkypeDataFolderPath = newSkypeDataFolderPath;
            var mainDbPaths = System.IO.Directory.GetFiles(SkypeDataFolderPath, "main.db", System.IO.SearchOption.AllDirectories);
            if (mainDbPaths.Length == 0) { return false; }
            _SkypeMainDbFilePath = mainDbPaths.FirstOrDefault();
            OnPropertyChanged(nameof(SkypeMainDbFilePath));
            if (UpdateSkypeData() == false) { return false; }
            return UpdateConversionResult();
        }

        public bool UpdateSkypeData()
        {
            try
            {
                var newSkypeMainDbDataSet = SkypeMainDbDataSet.LoadDataFromFile(SkypeMainDbFilePath);
                SkypeMainDbDataSet = newSkypeMainDbDataSet;
                OnPropertyChanged(nameof(SkypeMainDbDataSet));
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static DateTime? ConvertFromSQLiteTimestampToClrLocalDateTime(long? value)
        {
            if (value.HasValue == false) { return null; }
            var epoch = new DateTime(1970, 1, 1, 0, 0, 1, DateTimeKind.Utc);
            var elapsedSeconds = TimeSpan.FromSeconds(value.Value);
            var utcTime = epoch + elapsedSeconds;
            return utcTime.ToLocalTime();
        }

        public bool UpdateConversionResult()
        {
            try
            {
                var newConversionResult = new SkypeLogExport.ChatLogModel();
                newConversionResult.ChannelList = SkypeMainDbDataSet.Conversations.Select(e =>
                {
                    var newChannel = new Channel();
                    newChannel.Id = e.id;
                    newChannel.Identity = e.identity;
                    newChannel.DisplayName = e.displayname;
                    newChannel.CreationTimestamp = ConvertFromSQLiteTimestampToClrLocalDateTime(e.creation_timestamp);
                    newChannel.Creator_Person_Identity = e.creator;
                    return newChannel;
                }).ToList();
                var ChannelId_Channel_Dict = newConversionResult.ChannelList.ToDictionary(e => e.Id);

                var tempPersonList = SkypeMainDbDataSet.Contacts.Select(e => new Person()
                {
                    Id = e.id,
                    Identity = e.skypename,
                    FirstName = e.firstname,
                    LastName = e.lastname,
                    FullName = e.fullname,
                    DisplayName = e.displayname
                });
                var PersonIdentity_Person_Dict = tempPersonList.ToDictionary(e => e.Identity);

                foreach (var e in SkypeMainDbDataSet.Participants)
                {
                    if (e.convo_id.HasValue == false) { continue; }
                    if (PersonIdentity_Person_Dict.ContainsKey(e.identity) == false) { continue; }
                    var channel = ChannelId_Channel_Dict[e.convo_id.Value];
                    var person = PersonIdentity_Person_Dict[e.identity];
                    channel.PersonList.Add(person);
                }

                foreach (var e in SkypeMainDbDataSet.Messages)
                {
                    if (e.body_xml == null) { continue; }
                    if (e.convo_id.HasValue == false) { continue; }
                    var channel = ChannelId_Channel_Dict[e.convo_id.Value];
                    var newMessage = new Message();
                    newMessage.Channel_Identity = e.chatname;
                    newMessage.Id = e.id;
                    if (e.timestamp.HasValue) { newMessage.Timestamp = ConvertFromSQLiteTimestampToClrLocalDateTime(e.timestamp).Value; }
                    if (PersonIdentity_Person_Dict.ContainsKey(e.author))
                    {
                        newMessage.Author = PersonIdentity_Person_Dict[e.author];
                    }
                    if (e.edited_timestamp.HasValue)
                    {
                        if (PersonIdentity_Person_Dict.ContainsKey(e.edited_by))
                        {
                            newMessage.EditedBy = PersonIdentity_Person_Dict[e.edited_by];
                        }
                        newMessage.EditedTimestamp = ConvertFromSQLiteTimestampToClrLocalDateTime(e.edited_timestamp.Value);
                    }
                    newMessage.Body = e.body_xml;
                    channel.MessageList.Add(newMessage);
                }
                newConversionResult.ChannelList = newConversionResult.ChannelList.Where(e => e.MessageList.Count > 0).ToList();

                ConversionResult = newConversionResult;
                OnPropertyChanged(nameof(ConversionResult));

                var ec = ConversionResult.ChannelList.Select(e => new ExportingChannelViewModel()
                {
                    IsExporting = false,
                    Channel = e
                });
                ExportingChannels = new ObservableCollection<ExportingChannelViewModel>(ec);
                OnPropertyChanged(nameof(ExportingChannels));

                return true;
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
