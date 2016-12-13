using KennyAndRob.Millionaire.Models;
using NUnit.Framework;

namespace KennyAndRob.Millionaire.Tests
{
    [TestFixture]
    public class StatusCalculatorTestFixture
    {
        [Test]
        public void Can_Calculate_Status()
        {
            // Given
            var netWorth = 20; // $20

            // When
            var status = StatusCalculator.HowRichAmI(netWorth);

            // Then
            Assert.That(status, Is.EqualTo("You are poor"));
        }

        [Test]
        public void Can_Calculate_Status_That_I_Am_Rich()
        {
            // Given
            var netWorth = 20000000; // 20 million

            // When
            var status = StatusCalculator.HowRichAmI(netWorth);

            // Then
            Assert.That(status, Is.EqualTo("You are crazy rich!!!"));
        }
    }
}
