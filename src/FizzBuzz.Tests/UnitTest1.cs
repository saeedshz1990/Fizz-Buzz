using System;
using FizzBuzz.Logic;
using Xunit;

namespace FizzBuzz.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Fizz_Mod_Should_ByThreeAndthenResultByZero()
        {
            var itterator = 3;
            var secondNumber = 3;
            var sut = new Fizz();

            var expected = sut.Fizz(itterator);

            expected.Should().Be(secondNumber);
        }
    }
}
