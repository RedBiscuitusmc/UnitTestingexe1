using System;
using Xunit;

namespace UnitTestingExercise
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var calcul = new Calculator();

            //Act
            var actual = calcul.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2,2,0)]//Add test data <-------
        public void SubtractTest(int minend, int subend, int expected)
        {
            //Arrange
            var calcul = new Calculator();
            //Act
            var actual = calcul.Subtract(minend, subend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4,4,16)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Arrange
            var calcul = new Calculator();
            //Act
            var actual = calcul.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2,2,1)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var calcul = new Calculator();
            //Act
            var actual = calcul.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
