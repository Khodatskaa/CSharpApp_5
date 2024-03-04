using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Show_ShouldDisplayArrayElements()
        {
            // Arrange
            var array = new Array(new int[] { 1, 2, 3, 4, 5 });
            var expectedOutput = "1, 2, 3, 4, 5" + Environment.NewLine; 

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw); 

                // Act
                array.Show();

                // Assert
                var result = sw.ToString();
                Assert.AreEqual(expectedOutput, result);
            }
        }

        [TestMethod]
        public void Show_WithInfo_ShouldDisplayInfoAndArrayElements()
        {
            // Arrange
            var array = new Array(new int[] { 1, 2, 3, 4, 5 });
            var info = "Here are the elements of the array:";
            var expectedOutput = $"{info}{Environment.NewLine}1, 2, 3, 4, 5{Environment.NewLine}"; 

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw); 

                // Act
                array.Show(info);

                // Assert
                var result = sw.ToString();
                Assert.AreEqual(expectedOutput, result);
            }
        }
    }
}
