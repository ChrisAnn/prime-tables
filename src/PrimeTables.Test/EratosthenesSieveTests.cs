using System.Collections;
using NUnit.Framework;

namespace PrimeTables.Test
{
    [TestFixture]
    public class EratosthenesSieveTests
    {
        [TestCase (2, new[] {2})]
        public void OutputsExpectedPrimes(int max, IEnumerable expectedPrimes)
        {
            Assert.That(EratosthenesSieve.SievePrimes(max), Is.EquivalentTo(expectedPrimes));
        }
    }
}