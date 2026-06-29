using CustomerCommLib;
using Moq;
using NUnit.Framework;

namespace CustomerComm.Tests
{
    [TestFixture]
    public class CustomerCommTests
    {
        private Mock<IMailSender> mockMailSender;

        [OneTimeSetUp]
        public void Init()
        {
            mockMailSender = new Mock<IMailSender>();
        }

        [Test]
        [TestCase]
        public void Test_SendMailToCustomer_ReturnsTrue()
        {
            mockMailSender
                .Setup(x => x.SendMail(It.IsAny<string>(), It.IsAny<string>()))
                .Returns(true);

            CustomerComm customer = new CustomerComm(mockMailSender.Object);

            bool result = customer.SendMailToCustomer();

            Assert.That(result, Is.True);
        }
    }
}
