using NUnit.Framework;
using LB_KPZ_2.Algorithms;
using System.Collections.Generic;
using NUnit.Framework.Legacy;

namespace LB_KPZ_2.Tests
{
    [TestFixture]
    public class EratosthenesSieveTests
    {
        private EratosthenesSieve _sieve;

        [SetUp]
        public void Setup()
        {
            _sieve = new EratosthenesSieve();
        }

        [Test]
        public void FindPrimes_WhenNIs1_ReturnsEmptyList()
        {
            var result = _sieve.FindPrimes(1);
            ClassicAssert.IsEmpty(result);
        }

        [Test]
        public void FindPrimes_WhenNIs2_ReturnsListWith2()
        {
            var result = _sieve.FindPrimes(2);
            ClassicAssert.AreEqual(new List<int> { 2 }, result);
        }

        [Test]
        public void FindPrimes_WhenNIs3_Returns2And3()
        {
            var result = _sieve.FindPrimes(3);
            ClassicAssert.AreEqual(new List<int> { 2, 3 }, result);
        }

        [Test]
        public void FindPrimes_WhenNIs10_ReturnsCorrectPrimes()
        {
            var expected = new List<int> { 2, 3, 5, 7 };
            var result = _sieve.FindPrimes(10);
            ClassicAssert.AreEqual(expected, result);
        }

        [Test]
        public void FindPrimes_WhenNIs30_ReturnsAllPrimesUpTo30()
        {
            var expected = new List<int> { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
            var result = _sieve.FindPrimes(30);
            ClassicAssert.AreEqual(expected, result);
        }

        [Test]
        public void FindPrimes_WhenNIs0_ThrowsException()
        {
            ClassicAssert.Throws<System.IndexOutOfRangeException>(() => _sieve.FindPrimes(0));
        }
    }

    [TestFixture]
    public class SundaramSieveTests
    {
        private SundaramSieve _sieve;

        [SetUp]
        public void Setup()
        {
            _sieve = new SundaramSieve();
        }

        [Test]
        public void FindPrimes_WhenNIs1_ReturnsEmptyList()
        {
            var result = _sieve.FindPrimes(1);
            ClassicAssert.IsEmpty(result);
        }

        [Test]
        public void FindPrimes_WhenNIs2_ReturnsListWith2()
        {
            var result = _sieve.FindPrimes(2);
            ClassicAssert.AreEqual(new List<int> { 2 }, result);
        }

        [Test]
        public void FindPrimes_WhenNIs3_Returns2And3()
        {
            var result = _sieve.FindPrimes(3);
            ClassicAssert.AreEqual(new List<int> { 2, 3 }, result);
        }

        [Test]
        public void FindPrimes_WhenNIs10_ReturnsCorrectPrimes()
        {
            var expected = new List<int> { 2, 3, 5, 7 };
            var result = _sieve.FindPrimes(10);
            ClassicAssert.AreEqual(expected, result);
        }

        [Test]
        public void FindPrimes_WhenNIs30_ReturnsAllPrimesUpTo30()
        {
            var expected = new List<int> { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
            var result = _sieve.FindPrimes(30);
            ClassicAssert.AreEqual(expected, result);
        }

        [Test]
        public void FindPrimes_WhenNIs0_ThrowsArgumentException()
        {
            var ex = ClassicAssert.Throws<ArgumentException>(() => _sieve.FindPrimes(0));
            ClassicAssert.That(ex.Message, Does.Contain("n must be greater than 0"));
        }

        [Test]
        public void FindPrimes_WhenNIs10_ReturnsCorrectPrimes_2()
        {
            var sieve = new SundaramSieve();
            var expected = new List<int> { 2, 3, 5, 7 };

            var result = sieve.FindPrimes(10);

            ClassicAssert.AreEqual(expected, result);
        }
    }
}