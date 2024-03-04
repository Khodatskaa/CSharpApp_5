using CSharpApp_5;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Less_ShouldReturnCorrectCount()
        {
            // Arrange
            int[] testArray = { 2, 5, 8, 12, 15, 18, 22, 25 };
            ArrayCalculator arrayCalculator = new ArrayCalculator(testArray);

            // Act
            int lessCount = arrayCalculator.Less(20);

            // Assert
            Assert.AreEqual(5, lessCount);
        }

        [TestMethod]
        public void Greater_ShouldReturnCorrectCount()
        {
            // Arrange
            int[] testArray = { 2, 5, 8, 12, 15, 18, 22, 25 };
            ArrayCalculator arrayCalculator = new ArrayCalculator(testArray);

            // Act
            int greaterCount = arrayCalculator.Greater(10);

            // Assert
            Assert.AreEqual(7, greaterCount);
        }
    }
}