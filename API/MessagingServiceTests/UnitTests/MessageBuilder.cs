using MessagingService.Domain;
using MongoDB.Bson.Serialization.IdGenerators;

namespace MessagingServiceTests.UnitTests
{
    public class MessageBuilder
    {
        private Message _message;

        public MessageBuilder WithSingleMessage()
        {
            _message = new Message
            {
                Subject = "Urgent",
                Body = "Hippos have been seen swimming in Thames",
                Sender = "Christina",
                Receiver = "Peter"
            };

            return this;
        }

        public MessageBuilder WithNoSender ()
        {
            _message.Sender = string.Empty;

            return this;
        }

        public MessageBuilder WithNoReceiver()
        {
            _message.Receiver = string.Empty;

            return this;
        }

        public Message Build ()
        {
            return _message;
        }
    }
}
