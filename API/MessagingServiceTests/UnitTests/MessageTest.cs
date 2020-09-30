using System;
using Xunit;

namespace MessagingServiceTests.UnitTests
{
    public class MessageTest
    {
        [Fact]
        public void NewMessage_IdAndDateIsSet()
        {
            var message = new MessageBuilder().WithSingleMessage().Build();

            Assert.True(message.DateSent != DateTime.MinValue);
        }

        [Fact]
        public void CheckMandatoryFields_AllMandatoryFieldsSet_NoExceptionThrown()
        {
            var message = new MessageBuilder().WithSingleMessage().Build();

            // This should not cause an exception
            message.CheckMandatoryFields();

            Assert.True(true);
        }

        [Fact]
        public void CheckMandatoryFields_ReceiverIsEmpty()
        {
            var message = new MessageBuilder().WithSingleMessage().WithNoReceiver().Build();
            Assert.Throws<Exception>(() => message.CheckMandatoryFields());
        }

        [Fact]
        public void CheckMandatoryFields_SenderIsEmpty()
        {
            var message = new MessageBuilder().WithSingleMessage().WithNoSender().Build();
            Assert.Throws<Exception>(() => message.CheckMandatoryFields());
        }

        [Fact]
        public void MarkAsRead()
        {
            var message = new MessageBuilder().WithSingleMessage().Build();
            message.MarkAsRead();

            Assert.True(message.Read);
        }
    }
}
