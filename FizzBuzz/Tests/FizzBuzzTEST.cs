using FizzBuzz.ProductionCode;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Tests
{
   public class FizzBuzzTEST
    {
        [Test]
        public void VerificareMultipluDe3()
        {
            //Arrange
            FizzBuzzGame fizzBuzz = new FizzBuzzGame();

            //Act
            string result = fizzBuzz.Algoritm(6);

            //Assert
            Assert.AreEqual("Fizz", result);
        }

        [Test]
        public void VerificareMultipluDe5()
        {
            //Arrange
            FizzBuzzGame fizzBuzz = new FizzBuzzGame();

            //Act
            string result = fizzBuzz.Algoritm(10);

            //Assert
            Assert.AreEqual("Buzz", result);
        }

        [Test]
        public void VerificareMultipluDe3siDe5()
        {
            //Arrange
            FizzBuzzGame fizzBuzz = new FizzBuzzGame();

            //Act
            string result = fizzBuzz.Algoritm(15);

            //Assert
            Assert.AreEqual("FizzBuzz", result);
        }

        [Test]
        public void VerificareNrCareNueMultipluDe3sau5()
        {
            //Arrange
            FizzBuzzGame fizzBuzz = new FizzBuzzGame();

            //Act
            string result = fizzBuzz.Algoritm(7);

            //Assert
            Assert.AreEqual("7", result);
        }
    }
}
