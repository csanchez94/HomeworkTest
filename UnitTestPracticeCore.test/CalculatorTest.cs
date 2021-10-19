using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestPracticeCore.test
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void TestSumTwoNumbers()
        {
            // Arrange
            var sum = new Operations();
            var num1 = 7;
            var num2 = 5;
            var expectedResult = 12;

            // Act
            var result = sum.DoOperation(num1, num2, "+");

            // Assert
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void TestRestTwoNumbers()
        {
            // Arrange
            var substraction = new Operations();
            var num1 = 7;
            var num2 = 5;
            var expectedResult = 2;

            // Act
            var result = substraction.DoOperation(num1, num2, "-");

            // Assert
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void TestProductTwoNumbers()
        {
            // Arrange
            var product = new Operations();
            var num1 = 7;
            var num2 = 5;
            var expectedResult = 35;

            // Act
            var result = product.DoOperation(num1, num2, "*");

            // Assert
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void TestDivisionTwoNumbers()
        {
            // Arrange
            var division = new Operations();
            var num1 = 7;
            var num2 = 5;
            var expectedResult = 1.4;

            // Act
            var result = division.DoOperation(num1, num2, "/");

            // Assert
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void TestDefaultwoNumbers()
        {
            // Arrange
            var division = new Operations();
            var num1 = 7;
            var num2 = 5;
            var expectedResult = 0;

            // Act
            var result = division.DoOperation(num1, num2, "$");

            // Assert
            Assert.AreEqual(result, expectedResult);
        }


        [TestMethod]
        public void TestListOperation()
        {
            // Arrange
            var division = new Operations();
            double [] num1= {7,2,3,4,3 };
            string [] num2= {"+", "-","*","/" };
            double expectedResult = 8;

            // Act
            double result = division.NList(num1, num2);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }
    }
}
