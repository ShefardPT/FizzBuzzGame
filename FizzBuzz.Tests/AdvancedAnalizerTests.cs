using NUnit.Framework;
using TypeMock.ArrangeActAssert;
using System;
using System.Collections.Generic;
using System.Text;
using FizzBuzz.Services;
using FizzBuzz.Services.Interfaces;

namespace FizzBuzz.Tests
{
    [TestFixture, Isolated]
    public class AdvancedAnalizerTests
    {
        IAnalizer _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new AdvancedAnalizer();

            var fakeSimpleAnalizer = Isolate.Fake.Instance<SimpleAnalizer>();
            Isolate.WhenCalled(() => fakeSimpleAnalizer.Analize(0)).WillReturn(new Models.FizzBuzzResult());

            Isolate.NonPublic.InstanceField(_sut, "_simpleAnalizer").Value = fakeSimpleAnalizer;
        }

        [Test]
        public void Should_return_isFizz()
        {
            var result = _sut.Analize(33);

            Assert.IsTrue(result.IsFizz);
            Assert.IsFalse(result.IsBuzz);
        }

        [Test]
        public void Should_return_isBuzz()
        {
            var result = _sut.Analize(50);

            Assert.IsTrue(result.IsBuzz);
            Assert.IsFalse(result.IsFizz);
        }

        [Test]
        public void Should_return_isFizz_and_isBuzz()
        {
            var result = _sut.Analize(35);

            Assert.IsTrue(result.IsFizz);
            Assert.IsTrue(result.IsBuzz);
        }
    }
}
