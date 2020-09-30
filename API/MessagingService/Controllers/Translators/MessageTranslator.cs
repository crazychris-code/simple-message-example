using MessagingService.Controllers.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MessagingService.Controllers.Translators
{
    public static class MessageTranslator
    {
        public static Domain.Message ToDomain(Message message)
        {
            return new Domain.Message
            {
                Id = message.Id,
                Body = message.Body,
                Subject = message.Subject,
                Sender = message.Sender,
                Receiver = message.Receiver,
                Read = message.Read
            };
        }

        public static Message ToServiceModel(Domain.Message message)
        {
            return new Message
            {
                Id = message.Id,
                Body = message.Body,
                Subject = message.Subject,
                Sender = message.Sender,
                Receiver = message.Receiver,
                DateSent = message.DateSent,
                Read = message.Read
            };
        }

        public static List<Message> ToServiceModel(List<Domain.Message> messages)
        {
            return messages.Select(ToServiceModel).ToList();
        }
    }
}
