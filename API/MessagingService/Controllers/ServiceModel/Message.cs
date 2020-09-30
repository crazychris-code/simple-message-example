using System;

namespace MessagingService.Controllers.ServiceModel
{
    public class Message
    {
        public Guid Id { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public DateTime DateSent { get; set; }
        public bool Read { get; set; }
    }
}
