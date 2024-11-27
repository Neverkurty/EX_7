using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace UtilityTests
{
    public class UtilityTests
    {
        [TestFixture]
        public class SortArrayTests
        {
            [Test]
            public void SortArray_WithValidArray_ReturnsSortedArray()
            {
                int[] array = { 5, 3, 8, 1 };
                int[] expected = { 1, 3, 5, 8 };
                Assert.AreEqual(expected, Utility.SortArray(array));
            }

            [Test]
            public void SortArray_WithEmptyArray_ReturnsEmptyArray()
            {
                int[] array = { };
                Assert.AreEqual(array, Utility.SortArray(array));
            }

            [Test]
            public void SortArray_WithNull_ThrowsArgumentNullException()
            {
                Assert.Throws<ArgumentNullException>(() => Utility.SortArray(null));
            }

            [Test]
            public void SortArray_WithSingleElement_ReturnsSameArray()
            {
                int[] array = { 1 };
                Assert.AreEqual(array, Utility.SortArray(array));
            }
        }

        [TestFixture]
        public class IsPalindromeTests
        {
            [Test]
            public void IsPalindrome_WithPalindromeString_ReturnsTrue()
            {
                Assert.IsTrue(Utility.IsPalindrome("racecar"));
            }

            [Test]
            public void IsPalindrome_WithNonPalindromeString_ReturnsFalse()
            {
                Assert.IsFalse(Utility.IsPalindrome("hello"));
            }

            [Test]
            public void IsPalindrome_WithEmptyString_ReturnsTrue()
            {
                Assert.IsTrue(Utility.IsPalindrome(""));
            }

            [Test]
            public void IsPalindrome_WithNull_ThrowsArgumentNullException()
            {
                Assert.Throws<ArgumentNullException>(() => Utility.IsPalindrome(null));
            }
        }

        [TestFixture]
        public class FactorialTests
        {
            [Test]
            public void Factorial_WithPositiveNumber_ReturnsFactorial()
            {
                Assert.AreEqual(120, Utility.Factorial(5));
            }

            [Test]
            public void Factorial_WithZero_ReturnsOne()
            {
                Assert.AreEqual(1, Utility.Factorial(0));
            }

            [Test]
            public void Factorial_WithNegativeNumber_ThrowsArgumentException()
            {
                Assert.Throws<ArgumentException>(() => Utility.Factorial(-1));
            }

            [Test]
            public void Factorial_WithLargeNumber_ReturnsExpectedResult()
            {
                Assert.AreEqual(3628800, Utility.Factorial(10));
            }

            [Test]
            public void Factorial_WithOutOfRange_ThrowsArgumentException()
            {
                Assert.Throws<ArgumentException>(() => Utility.Factorial(25));
            }
        }

        [TestFixture]
        public class FibonacciTests
        {
            [Test]
            public void Fibonacci_WithZero_ReturnsZero()
            {
                Assert.AreEqual(0, Utility.Fibonacci(0));
            }

            [Test]
            public void Fibonacci_WithOne_ReturnsOne()
            {
                Assert.AreEqual(1, Utility.Fibonacci(1));
            }

            [Test]
            public void Fibonacci_WithPositiveNumber_ReturnsExpectedResult()
            {
                Assert.AreEqual(55, Utility.Fibonacci(10));
            }

            [Test]
            public void Fibonacci_WithNegativeNumber_ThrowsArgumentException()
            {
                Assert.Throws<ArgumentException>(() => Utility.Fibonacci(-5));
            }
        }

        [TestFixture]
        public class IndexOfSubstringTests
        {
            [Test]
            public void IndexOfSubstring_WithValidInput_ReturnsCorrectIndex()
            {
                Assert.AreEqual(6, Utility.IndexOfSubstring("hello world", "world"));
            }

            [Test]
            public void IndexOfSubstring_WithSubstringNotFound_ReturnsNegativeOne()
            {
                Assert.AreEqual(-1, Utility.IndexOfSubstring("hello world", "test"));
            }

            [Test]
            public void IndexOfSubstring_WithNullString_ThrowsArgumentNullException()
            {
                Assert.Throws<ArgumentNullException>(() => Utility.IndexOfSubstring(null, "world"));
            }

            [Test]
            public void IndexOfSubstring_WithNullSubstring_ThrowsArgumentNullException()
            {
                Assert.Throws<ArgumentNullException>(() => Utility.IndexOfSubstring("hello world", null));
            }

            [Test]
            public void IndexOfSubstring_WithSubstringNotFound_ReturnsNegativeTwo()
            {
                Assert.AreEqual(-1, Utility.IndexOfSubstring("", "test"));
            }

            [Test]
            public void IndexOfSubstring_WithSubstringNotFound_ReturnsNegativeThree()
            {
                Assert.AreEqual(0, Utility.IndexOfSubstring("Hello world", ""));
            }
        }

        [TestFixture]
        public class IsPrimeTests
        {
            [Test]
            public void IsPrime_WithPrimeNumber_ReturnsTrue()
            {
                Assert.IsTrue(Utility.IsPrime(29));
            }

            [Test]
            public void IsPrime_WithNonPrimeNumber_ReturnsFalse()
            {
                Assert.IsFalse(Utility.IsPrime(10));
            }

            [Test]
            public void IsPrime_WithOne_ReturnsFalse()
            {
                Assert.IsFalse(Utility.IsPrime(1));
            }

            [Test]
            public void IsPrime_WithNegativeNumber_ReturnsFalse()
            {
                Assert.IsFalse(Utility.IsPrime(-5));
            }
        }

        [TestFixture]
        public class ReverseIntegerTests
        {
            [Test]
            public void ReverseInteger_WithPositiveNumber_ReturnsReversed()
            {
                Assert.AreEqual(321, Utility.ReverseInteger(123));
            }

            [Test]
            public void ReverseInteger_WithNegativeNumber_ReturnsReversed()
            {
                Assert.AreEqual(-21, Utility.ReverseInteger(-120));
            }

            [Test]
            public void ReverseInteger_WithOverflow_ReturnsZero()
            {
                Assert.AreEqual(0, Utility.ReverseInteger(2147483647));
            }

            [Test]
            public void ReverseInteger_WithZero_ReturnsZero()
            {
                Assert.AreEqual(0, Utility.ReverseInteger(0));
            }
        }

        [TestFixture]
        public class ToRomanTests
        {
            [Test]
            public void ToRoman_WithValidNumber_ReturnsRomanNumeral()
            {
                Assert.AreEqual("II", Utility.ToRoman(2));
            }

            [Test]
            public void ToRoman_WithOutOfRangeLow_ThrowsArgumentException()
            {
                Assert.Throws<ArgumentException>(() => Utility.ToRoman(0));
            }

            [Test]
            public void ToRoman_WithOutOfRangeHigh_ThrowsArgumentException()
            {
                Assert.Throws<ArgumentException>(() => Utility.ToRoman(4000));
            }

            [Test]
            public void ToRoman_WithValidComplexNumber_ReturnsRomanNumeral()
            {
                Assert.AreEqual("MCMXCIV", Utility.ToRoman(1994));
            }
        }
    }
}
