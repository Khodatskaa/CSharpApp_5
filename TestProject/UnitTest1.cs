using CSharpApp_5;

namespace TestProject
{
    [TestClass]
    public class ExtendedArrayCalculator2Tests
    {
        [TestMethod]
        public void CountDistinct_ShouldReturnCorrectCount()
        {
            // Arrange
            int[] testArray = { 2, 5, 8, 12, 15, 18, 22, 25, 8, 15 };
            ExtendedArrayCalculator2 extendedArrayCalculator2 = new ExtendedArrayCalculator2(testArray);

            // Act
            int distinctCount = extendedArrayCalculator2.CountDistinct();

            // Assert
            Assert.AreEqual(8, distinctCount); 
        }

        [TestMethod]
        public void EqualToValue_ShouldReturnCorrectCount()
        {
            // Arrange
            int[] testArray = { 2, 5, 8, 12, 15, 18, 22, 25, 8, 15 };
            ExtendedArrayCalculator2 extendedArrayCalculator2 = new ExtendedArrayCalculator2(testArray);

            // Act
            int equalToValueCount = extendedArrayCalculator2.EqualToValue(15);

            // Assert
            Assert.AreEqual(2, equalToValueCount); 
        }
    }
}