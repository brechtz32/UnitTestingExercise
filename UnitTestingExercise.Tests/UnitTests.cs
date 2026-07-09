using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(4, 7, 10, 21)]
        [InlineData(1, -15, 5, -9)]
        [InlineData(0, 0, 0, 0)]
        [InlineData(-15, -10, -9, -34)]
        [InlineData(10, 0, -10, 0)]
        [InlineData(-1, 0, 1, 0)]

        public void AddTest(int num1, int num2, int num3, int expected)
        {
            // DONE -Start Step 3 here:

            //Arrange
            // create a Calculator object
            var calculatorAdd = new Calculator();
            

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
            var actual = calculatorAdd.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 3, 2)]//Add test data <-------
        [InlineData(-5, 3, -8)]
        [InlineData(3, -5, 8)]
        [InlineData(-4, -8, 4)]
        [InlineData(9, 9, 0)]
        [InlineData(0, 5, -5)]
        [InlineData(0, 0, 0)]

        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            // DONE - Start Step 5 here:

            //Arrange
            var calculatorSubtract = new Calculator();

            //Act
            var actual = calculatorSubtract.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(6, 7, 42)]//Add test data <-------
        [InlineData(-5, -5, 25)]
        [InlineData(-2, 4, -8)]
        [InlineData(8, 0, 0)]
        [InlineData(0, 0, 0)]
        [InlineData(10, 10, 100)]

        public void MultiplyTest(int num1, int num2, int expected)
        {
            // DONE - Start Step 7 here:

            //Arrange
            var calculatorMultiply = new Calculator();

            //Act
            var actual = calculatorMultiply.multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(10, 2, 5)]//Add test data <-------
        [InlineData(1, 1, 1)]
        [InlineData(-20, 2, -10)]
        [InlineData(15, -3, -5)]
        [InlineData(32, 4, 8)]
        [InlineData(-50, -10, 5)]

        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var calculatorDivide = new Calculator();

            //Act
            var actual = calculatorDivide.divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }
                
    }
}
