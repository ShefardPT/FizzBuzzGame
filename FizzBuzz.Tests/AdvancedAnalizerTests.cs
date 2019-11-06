using NUnit.Framework;
using TypeMock.ArrangeActAssert;
using System;
using System.Collections.Generic;
using System.Text;
using FizzBuzz.Services;
using FizzBuzz.Services.Interfaces;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class AdvancedAnalizerTests
    {
        IAnalizer _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new AdvancedAnalizer();
        }

        [Test, Isolated]
        public void Should_return_isFizz()
        {
            var result = _sut.Analize(13);

            Assert.IsTrue(result.IsFizz);
            Assert.IsFalse(result.IsBuzz);
        }

        [Test, Isolated]
        public void Should_return_isBuzz()
        {
            var result = _sut.Analize(59);

            Assert.IsTrue(result.IsBuzz);
            Assert.IsFalse(result.IsFizz);
        }

        [Test, Isolated]
        public void Should_return_isFizz_and_isBuzz()
        {
            var result = _sut.Analize(53);

            Assert.IsTrue(result.IsFizz);
            Assert.IsTrue(result.IsBuzz);
        }
    }
}
