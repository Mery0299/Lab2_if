using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab2_if9;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_NumbersRepeated()
        {
            bool result = Logic.Check(new float[] { 2, 2, 2 });
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestMethod_NumbersNotRepeated()
        {
            bool result = Logic.Check(new float[] { 0, 5.1f, -7 });
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestMethod_MultiplyNumbers()
        {
            string result = Logic.Solution(new float[] { 5, 3.8f, -7 });
            Assert.AreEqual("Ответ: -7 * 3,8 = -26,6", result);
        }
    }
}
