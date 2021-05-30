using System;
using NUnit.Framework;

namespace TGS.Challenge.Tests
{
    [TestFixture()]
    public class VowelCountTests
    {
        private readonly VowelCount _vowelCount;

        public VowelCountTests()
        {
            this._vowelCount = new VowelCount();
        }

        [Test()]
        public void Value_IsRequired()
        {
            Assert.Throws<ArgumentException>(() => _vowelCount.Count(string.Empty));
        }

        [Test()]
        public void AEIOU_Returns_Correct_Count()
        {
            var count = _vowelCount.Count("AEIOU");

            Assert.AreEqual(5, count);
        }

        [Test()]
        public void lmnpqr_Returns_Correct_Count()
        {
            var count = _vowelCount.Count("lmnpqr");

            Assert.AreEqual(0, count);
        }

        [Test()]
        public void abcdefghijklmnopqrstuvwxyz_Returns_Correct_Count()
        {
            var count = _vowelCount.Count("abcdefghijklmnopqrstuvwxyz");

            Assert.AreEqual(5, count);
        }

        [Test()]
        public void Howmanycanyoufind_Returns_Correct_Count()
        {
            var count = _vowelCount.Count("How many can you find");

            Assert.AreEqual(6, count);
        }

        [Test()]
        public void Aaaaaa_Returns_Correct_Count()
        {
            var count = _vowelCount.Count("Aaaaaa");

            Assert.AreEqual(6, count);
        }

        [Test()]
        public void Alpha_Numeric_Returns_Correct_Count()
        {
            var count = _vowelCount.Count("@Are numbers and special characters allowed?! 123456789");

            Assert.AreEqual(14, count);
        }

        [Test()]
        public void Empty_String_Returns_Correct_Count()
        {
            var exceptionMessage = "Input value cannot be null";

            var ex = Assert.Throws<ArgumentException>(() => _vowelCount.Count(null));
            Assert.That(ex.Message, Is.EqualTo(exceptionMessage));

            ex = Assert.Throws<ArgumentException>(() => _vowelCount.Count(string.Empty));
            Assert.That(ex.Message, Is.EqualTo(exceptionMessage));

            ex = Assert.Throws<ArgumentException>(() => _vowelCount.Count(""));
            Assert.That(ex.Message, Is.EqualTo(exceptionMessage));
        }
    }
}