namespace SkypeLogExport
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel;
    using sds = System.Data.SQLite;

    public class SkypeLogExportModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            var t = PropertyChanged;
            if (t != null) { t(this, new PropertyChangedEventArgs(propertyName)); }
        }

        public string SkypeDataFolderPath { get; set; }
        public string SkypeMainDbFilePath { get; set; }
        public SkypeMainDbDataSet SkypeData { get; private set; }
        public ChatLogModel ConversionResult { get; private set; }

        public bool TryUpdateSkypeMainDbPath()
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
            SkypeMainDbFilePath = mainDbPaths.FirstOrDefault();

            SkypeData = SkypeMainDbDataSet.LoadDataFromFile(SkypeMainDbFilePath);
            OnPropertyChanged(nameof(SkypeData));

            ConvertSkypeDataToSkypeLog();
            OnPropertyChanged(nameof(ConversionResult));

            return true;
        }

        public static DateTime? ConvertFromSQLiteTimestampToClrLocalDateTime(long? value)
        {
            if (value.HasValue == false) { return null; }
            var epoch = new DateTime(1970, 1, 1, 0, 0, 1, DateTimeKind.Utc);
            var elapsedSeconds = TimeSpan.FromSeconds(value.Value);
            var utcTime = epoch + elapsedSeconds;
            return utcTime.ToLocalTime();
        }

        public void ConvertSkypeDataToSkypeLog()
        {
            ConversionResult = new SkypeLogExport.ChatLogModel();
            ConversionResult.ChannelList = SkypeData.Conversations.Select(e =>
            {
                var newChannel = new Channel();
                newChannel.Id = e.id;
                newChannel.Identity = e.identity;
                newChannel.DisplayName = e.displayname;
                newChannel.CreationTimestamp = ConvertFromSQLiteTimestampToClrLocalDateTime(e.creation_timestamp);
                newChannel.Creator_Person_Identity = e.creator;
                return newChannel;
            }).ToList();
            var ChannelId_Channel_Dict = ConversionResult.ChannelList.ToDictionary(e => e.Id);
            foreach (var e in SkypeData.Messages)
            {
                if (e.body_xml == null) { continue; }
                if (e.convo_id.HasValue == false) { continue; }
                var channel = ChannelId_Channel_Dict[e.convo_id.Value];
                var newMessage = new Message();
                newMessage.Channel_Identity = e.chatname;
                newMessage.Id = e.id;
                if (e.timestamp.HasValue) { newMessage.Timestamp = ConvertFromSQLiteTimestampToClrLocalDateTime(e.timestamp).Value; }
                if (e.edited_timestamp.HasValue)
                {
                    newMessage.EditedBy_Person_Identity = e.edited_by;
                    newMessage.EditedTimestamp = ConvertFromSQLiteTimestampToClrLocalDateTime(e.edited_timestamp.Value);
                }
                newMessage.Body = e.body_xml;
                channel.MessageList.Add(newMessage);
            }
        }
    }
}
