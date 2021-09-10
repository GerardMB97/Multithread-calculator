using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiThreading;

namespace CalculatorTest
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Sum_WhenInvokedWithAListContaining_123_Should_Return_6()
        {
            //Arrange
            List<int> numbers = new List<int>() { 1, 2, 3 };
            Calculator calculator = new Calculator();


            //Act
            int output = calculator.Sum(numbers);

            //Assert
            int expectedOutput = 6;
            Assert.AreEqual(output, expectedOutput, 0.001, "Numers not summed correctly");

        }
        [TestMethod]
        public void Subtraction_WhenInvokedWithAListContaining_123_Should_Return_negative4()
        {
            //Arrange
            List<int> numbers = new List<int>() { 1, 2, 3 };
            Calculator calculator = new Calculator();


            //Act
            int output = calculator.Substraction(numbers);

            //Assert
            int expectedOutput = -4;
            Assert.AreEqual(output, expectedOutput, 0.001, "Numers not summed correctly");

        }
        [TestMethod]
        public void Multiplication_WhenInvokedWithAListContaining_123_Should_Return_6()
        {
            //Arrange
            List<int> numbers = new List<int>() { 1, 2, 3 };
            Calculator calculator = new Calculator();


            //Act
            int output = calculator.Multiplication(numbers);

            //Assert
            int expectedOutput = 6;
            Assert.AreEqual(output, expectedOutput, 0.001, "Numers not summed correctly");

        }
        [TestMethod]
        public void Division_WhenInvokedWithAListContaining_123_Should_Return_015()
        {
            //Arrange
            List<int> numbers = new List<int>() { 1, 2, 3 };
            Calculator calculator = new Calculator();


            //Act
            double output = calculator.Division(numbers);

            //Assert
            double expectedOutput = 0.16;
            Assert.AreEqual(output, expectedOutput, 0.01, "Numers not summed correctly");

        }
    }
}
