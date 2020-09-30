using System;

namespace MessagingService.Domain
{
    public class Message
    {
        public Message()
        {
            DateSent = DateTime.Now;
        }

        public Guid Id { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public DateTime DateSent { get; set; }
        public bool Read { get; set; }

        public void CheckMandatoryFields()
        {
            if (string.IsNullOrEmpty(Sender)) throw new Exception("Sender cannot be empty");
            if (string.IsNullOrEmpty(Receiver)) throw new Exception("Receiver cannot be empty");
        }

        public void MarkAsRead()
        {
            Read = true;
        }
    }
}
