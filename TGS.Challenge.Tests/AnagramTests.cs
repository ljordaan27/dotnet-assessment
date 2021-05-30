using System;
using NUnit.Framework;

namespace TGS.Challenge.Tests
{
    [TestFixture()]
    public class AnagramTests
    {
        private readonly Anagram _anagram;

        public AnagramTests()
        {
            this._anagram = new Anagram();
        }

        [Test()]
        public void Word1_IsRequired()
        {
            var ex = Assert.Throws<ArgumentException>(() => _anagram.AreAnagrams(string.Empty, "ABC"));
            Assert.That(ex.Message, Is.EqualTo("Word1 cannot be null. Please enter a valid word."));
        }

        [Test()]
        public void Word2_IsRequired()
        {
            var ex = Assert.Throws<ArgumentException>(() => _anagram.AreAnagrams("ABC", string.Empty));
            Assert.That(ex.Message, Is.EqualTo("Word2 cannot be null. Please enter a valid word."));
        }

        [Test()]
        public void Dormitory_IsAnagram_Dirty_room()
        {
            var result = _anagram.AreAnagrams("Dormitory", "Dirty_room");

            Assert.IsTrue(result);
        }

        [Test()]
        public void Funeral_IsAnagram_Reel_fun()
        {
            var result = _anagram.AreAnagrams("Funeral", "Reel fun");

            Assert.IsFalse(result);
        }

        [Test()]
        public void School_master_IsAnagram_The_classroom()
        {
            var result = _anagram.AreAnagrams("School master?!", "!?The classroom");

            Assert.IsTrue(result);
        }

        [Test()]
        public void Listen_Is_NOT_Anagram_Silence()
        {
            var result = _anagram.AreAnagrams("Listen", "Silence");

            Assert.IsFalse(result);
        }

        [Test()]
        public void Funeral_IsAnagram_Real_fun()
        {
            var result = _anagram.AreAnagrams("Funeral", "Real fun");

            Assert.IsTrue(result);
        }

        [Test()]
        public void IsAnagram_Contains_Same_Numbers()
        {
            var result = _anagram.AreAnagrams("1 Funeral", "Realfun 1");

            Assert.IsTrue(result);
        }

        [Test()]
        public void IsAnagram_Contains_Different_Numbers()
        {
            var result = _anagram.AreAnagrams("1 Funeral", "Real fun 2");

            Assert.IsFalse(result);
        }
    }
}