using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class MathHelperTests
    {
        [TestMethod]
        public void Add_ReturnsCorrectSum_ForPositiveNumbers()
        {
            Assert.AreEqual(30, MathHelper.Add(10, 20));
        }

        [TestMethod]
        public void Add_ReturnsCorrectSum_ForNegativeNumbers()
        {
            Assert.AreEqual(-12, MathHelper.Add(-5, -7));
        }

        [TestMethod]
        public void Add_ReturnsCorrectSum_ForZero()
        {
            Assert.AreEqual(0, MathHelper.Add(0, 0));
        }

        [TestMethod]
        public void Run_PrintsHelloMessageFirst()
        {
            // Arrange
            using var sw = new StringWriter();
            Console.SetOut(sw);

            // Act
            Program.Run();

            // Assert
            var output = sw.ToString();
            var firstLine = output.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries)[0];
            Assert.AreEqual("Hello, First testing Jenkins with .Net console!", firstLine);
        }
    }
}