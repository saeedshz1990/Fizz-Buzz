using System;
using FizzBuzz.Exceptions;
using FizzBuzz.Logic;
using FluentAssertions;
using Xunit;

namespace FizzBuzz.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Fizz_Mod_Should_ByThreeAndthenResultByZero()
        {
            var itterator = 9;

            var sut = new Fizz();

            var expected = sut.FizzByThree(itterator);

            expected.Should().Be("Fizz");
        }


        [Fact]
        public void Fizz_Mod_Throw_NotFound()
        {
            var itterator = 4;
            var sut = new Fizz();
            
            Action expected = () => sut.FizzByThree(itterator);
            expected.Should().ThrowExactly<ModNotDivideByThree>();
        }
        
        [Fact]
        public void Buzz_Mod_Should_ByFiveAndThenResultByZero()
        {
            var itterator = 10;

            var sut = new Fizz();

            var expected = sut.BuzzByFive(itterator);

            expected.Should().Be("Buzz");
        }

        [Fact]
        public void Buzz_Mod_ThrowByFiveException()
        {
            var itterator = 7;
            var sut = new Fizz();

            Action expected = () => sut.BuzzByFive(itterator);
            expected.Should().ThrowExactly<ModNotDivideByFive>();
        }
        
        [Fact]
        public void FzBizz_Mod_ByThreeAndByFive_Should_ByFizzBuzz()
        {
            var itterator = 15;

            var sut = new Fizz();

            var expected = sut.FizzBuzz(itterator);

            expected.Should().Be("FizzBuzz");
        }
        
        [Fact]
        public void FzBizz_Mod_ByThreeAndByFive_ThrowByThreeException()
        {
            var itterator = 16;
            var sut = new Fizz();

            Action expected = () => sut.FizzBuzz(itterator);
            expected.Should().ThrowExactly<ModNotDivideByThreeAndFive>();
        }
    }
}
