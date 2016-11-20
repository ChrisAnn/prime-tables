using System.Collections;
using NUnit.Framework;

namespace PrimeTables.Test
{
    [TestFixture]
    public class EratosthenesSieveTests
    {
        [TestCase (2, new[] {2})]
        [TestCase (5, new[] {2, 3, 5})]
        [TestCase (30, new[] {2, 3, 5, 7, 11, 13, 17, 19, 23, 29})]
        [TestCase (121, new[] {2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113})]
        public void OutputsExpectedPrimes(int max, IEnumerable expectedPrimes)
        {
            Assert.That(EratosthenesSieve.SievePrimes(max), Is.EquivalentTo(expectedPrimes));
        }
    }
}