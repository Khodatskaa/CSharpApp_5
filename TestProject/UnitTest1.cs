using CSharpApp_5;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            ArrayCalculator arrayCalculator = new ArrayCalculator(array);
            Assert.AreEqual(5, arrayCalculator.Less(6));
            Assert.AreEqual(4, arrayCalculator.Greater(6));
        }
    }
}