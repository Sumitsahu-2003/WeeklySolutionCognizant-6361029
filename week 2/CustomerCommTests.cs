using NUnit.Framework;
using Moq;
using CustomerCommLib;

namespace CustomerComm.Tests
{
    [TestFixture]
    public class CustomerCommTests
    {
        private Mock<IMailSender> _mailSenderMock;
        private CustomerCommLib.CustomerComm _customerComm;

        [OneTimeSetUp]
        public void Init()
        {
            _mailSenderMock = new Mock<IMailSender>();

            _mailSenderMock
                .Setup(m => m.SendMail(It.IsAny<string>(), It.IsAny<string>()))
                .Returns(true);

            _customerComm = new CustomerCommLib.CustomerComm(_mailSenderMock.Object);
        }

        [Test]
        [TestCase]
        public void SendMailToCustomer_WhenCalled_ReturnsTrue()
        {
            var result = _customerComm.SendMailToCustomer();
            Assert.That(result, Is.True);
        }
    }
}
