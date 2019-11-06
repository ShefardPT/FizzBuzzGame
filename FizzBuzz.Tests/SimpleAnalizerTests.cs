using FizzBuzz.Services;
using FizzBuzz.Services.Interfaces;
using NUnit.Framework;
using TypeMock.ArrangeActAssert;
using System.Collections;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class SimpleAnalizerTests
    {
        IAnalizer _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new SimpleAnalizer();
        }

        [Test, Isolated]
        public void Should_return_isFizz()
        {
            var result = _sut.Analize(18);

            Assert.IsTrue(result.IsFizz);
            Assert.IsFalse(result.IsBuzz);
        }

        [Test, Isolated]
        public void Should_return_isBuzz()
        {
            var result = _sut.Analize(20);

            Assert.IsTrue(result.IsBuzz);
            Assert.IsFalse(result.IsFizz);
        }

        [Test, Isolated]
        public void Should_return_isFizz_and_isBuzz()
        {
            var result = _sut.Analize(45);

            Assert.IsTrue(result.IsFizz);
            Assert.IsTrue(result.IsBuzz);
        }
    }
}