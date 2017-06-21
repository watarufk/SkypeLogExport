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

    public class ExportingChannel
    {
        public bool IsExporting { get; set; }
        public Channel Channel { get; set; }
    }

    public enum ExportingMethod
    {
        EachChannelInEachFile,
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


        public SkypeMainDbDataSet SkypeMainDbDataSet { get; private set; }
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


        public ObservableCollection<ExportingChannel> ExportingChannels { get; private set; }
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
                var newChannelList = SkypeMainDbDataSet.Conversations.Select(e =>
                {
                    var newChannel = new Channel();
                    newChannel.Id = e.id;
                    newChannel.Identity = e.identity;
                    newChannel.DisplayName = e.displayname;
                    newChannel.CreationTimestamp = ConvertFromSQLiteTimestampToClrLocalDateTime(e.creation_timestamp);
                    newChannel.Creator_Person_Identity = e.creator;
                    return newChannel;
                }).ToList();
                var ChannelId_Channel_Dict = newChannelList.ToDictionary(e => e.Id);

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

                    {
                        var tempString = e.body_xml;
                        if (true)
                        {
                            var xd = new System.Xml.XmlDocument();
                            xd.LoadXml($"<body>{tempString}</body>");
                            // TODO: MUSTDO: check if it exports correct result or not when the e.body_xml contains XML documents
                            tempString = xd.InnerText;
                        }
                        else if (false)
                        {
                            var re = new System.Text.RegularExpressions.Regex("<.*?>", System.Text.RegularExpressions.RegexOptions.Singleline);
                            tempString = re.Replace(tempString, "");
                            tempString = Uri.UnescapeDataString(tempString);
                        }
                        newMessage.Body = tempString;
                    }
                    channel.MessageList.Add(newMessage);
                }

                var ec = newChannelList.Where(e => e.MessageList.Count > 0).Select(e => new ExportingChannel()
                {
                    IsExporting = false,
                    Channel = e
                });
                ExportingChannels = new ObservableCollection<ExportingChannel>(ec);
                OnPropertyChanged(nameof(ExportingChannels));

                return true;
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
                return false;
            }
        }


        ExportingChannel _CurrentSelectedChannel;
        public ExportingChannel CurrentSelectedChannel
        {
            get { return _CurrentSelectedChannel; }
            set
            {
                _CurrentSelectedChannel = value;
                OnPropertyChanged(nameof(CurrentSelectedChannel));
                OnPropertyChanged(nameof(CurrentSelectedChannelPersonList));
                OnPropertyChanged(nameof(CurrentSelectedChannelMessageList));
                OnPropertyChanged(nameof(CurrentSelectedChannelMessageTextLog));
                OnPropertyChanged(nameof(CurrentSelectedChannelMessageJson));
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
        public static string GetTextLogFromMessage_01(Message msg)
        {
            var ret = $"[{msg.Timestamp:yyyy/MM/dd HH:mm:ss (zzz)}";
            if (msg.HasEdited) { ret += $", [Edited] {msg.EditedTimestamp:yyyy/MM/dd HH:mm:ss (zzz)}"; }
            ret += $"]\t{msg.Author.DisplayName}" + Environment.NewLine;
            ret += msg.Body + Environment.NewLine;
            return ret;
        }
        public static string GetTextLogFromMessageList(IList<Message> messages)
        {
            var sb = new StringBuilder();
            foreach (var message in messages) { sb.AppendLine(GetTextLogFromMessage_01(message)); }
            var ret = sb.ToString();
            return ret;
        }
        public string CurrentSelectedChannelMessageTextLog
        {
            get { return GetTextLogFromMessageList(CurrentSelectedChannelMessageList); }
        }
        public static string GetJsonFromMessageList(IList<Message> messages)
        {
            var ret = Newtonsoft.Json.JsonConvert.SerializeObject(messages, Newtonsoft.Json.Formatting.Indented);
            return ret;
        }
        public string CurrentSelectedChannelMessageJson
        {
            get { return GetJsonFromMessageList(CurrentSelectedChannelMessageList); }
        }


        public ExportingMethod ExportingMethod { get; set; } = ExportingMethod.EachChannelInEachFile;
        public static string GetTextLogFromChannel(Channel channel)
        {
            var sb = new StringBuilder();
            sb.AppendLine("==============================");
            sb.AppendLine($"[Channel]");
            sb.AppendLine($"{channel.DisplayName}");
            sb.AppendLine("");
            sb.AppendLine("[People]");
            foreach (var person in channel.PersonList) { sb.Append($"{person.DisplayName},"); }
            sb.AppendLine();
            sb.AppendLine("==============================");
            sb.AppendLine(GetTextLogFromMessageList(channel.MessageList));
            return sb.ToString();
        }
        public bool SaveAsTextLog(string filePath)
        {
            try
            {
                var folderPath = System.IO.Path.GetDirectoryName(filePath);
                var fileNameBase = System.IO.Path.GetFileNameWithoutExtension(filePath);
                var channels = ExportingChannels.Where(e => e.IsExporting).Select(e => e.Channel);
                switch (ExportingMethod)
                {
                    case ExportingMethod.EachChannelInEachFile:
                        {
                            foreach (var channel in channels)
                            {
                                var chName = channel.DisplayName;
                                foreach (var c in System.IO.Path.GetInvalidFileNameChars()) { chName = chName.Replace(c.ToString(), "_"); }
                                var path = System.IO.Path.Combine(folderPath, $"{fileNameBase}_{chName}.txt");
                                var contents = GetTextLogFromChannel(channel);
                                System.IO.File.WriteAllText(path, contents);
                            }
                        }
                        break;
                    case ExportingMethod.AllChannelsInOneFile:
                        {
                            var path = filePath;
                            if (System.IO.File.Exists(path)) { System.IO.File.Delete(path); }
                            foreach (var channel in channels)
                            {
                                var contents = GetTextLogFromChannel(channel) + Environment.NewLine + Environment.NewLine;
                                System.IO.File.AppendAllText(path, contents);
                            }
                        }
                        break;
                    default:
                        throw new NotImplementedException();
                }
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool SaveAsJson(string filePath)
        {
            try
            {
                var folderPath = System.IO.Path.GetDirectoryName(filePath);
                var fileNameBase = System.IO.Path.GetFileNameWithoutExtension(filePath);
                var channels = ExportingChannels.Where(e => e.IsExporting).Select(e => e.Channel);
                switch (ExportingMethod)
                {
                    case ExportingMethod.EachChannelInEachFile:
                        {
                            foreach (var channel in channels)
                            {
                                var chName = channel.DisplayName;
                                foreach (var c in System.IO.Path.GetInvalidFileNameChars()) { chName = chName.Replace(c.ToString(), "_"); }
                                var path = System.IO.Path.Combine(folderPath, $"{fileNameBase}_{chName}.json");
                                var contents = Newtonsoft.Json.JsonConvert.SerializeObject(channel, Newtonsoft.Json.Formatting.Indented);
                                System.IO.File.WriteAllText(path, contents);
                            }
                        }
                        break;
                    case ExportingMethod.AllChannelsInOneFile:
                        {
                            var path = filePath;
                            if (System.IO.File.Exists(path)) { System.IO.File.Delete(path); }
                            var contents = Newtonsoft.Json.JsonConvert.SerializeObject(channels, Newtonsoft.Json.Formatting.Indented);
                            System.IO.File.WriteAllText(path, contents);
                        }
                        break;
                    default:
                        throw new NotImplementedException();
                }
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
