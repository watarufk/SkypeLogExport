namespace SkypeLogExport
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Runtime.Serialization;

    [DataContract]
    public class Person
    {
        [DataMember]
        public long Id { get; set; }
        [DataMember]
        public string Identity { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string FullName { get; set; }
        [DataMember]
        public string DisplayName { get; set; }
    }

    [DataContract]
    public class Message
    {
        [DataMember]
        public long Id { get; set; }
        [DataMember]
        public string Channel_Identity { get; set; }
        [DataMember]
        public string Identity { get; set; }

        [DataMember]
        public DateTime Timestamp { get; set; }
        [DataMember]
        public Person Author { get; set; }

        [DataMember]
        public DateTime? EditedTimestamp { get; set; }
        public bool HasEdited { get { return EditedTimestamp.HasValue; } }
        [DataMember]
        public Person EditedBy { get; set; }

        [DataMember]
        public string Body { get; set; }

        // Can make reply, thread and so on
        [DataMember]
        public string Replying_Message_Identity { get; set; }
    }

    [DataContract]
    public class Channel
    {
        [DataMember]
        public long Id { get; set; }
        [DataMember]
        public string Identity { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string DisplayName { get; set; }
        [DataMember]
        public DateTime? CreationTimestamp { get; set; }
        [DataMember]
        public string Creator_Person_Identity { get; set; }
        [DataMember]
        public List<Person> PersonList { get; set; }
        [DataMember]
        public List<Message> MessageList { get; set; }

        public Channel()
        {
            PersonList = new List<Person>();
            MessageList = new List<Message>();
        }
    }
}
