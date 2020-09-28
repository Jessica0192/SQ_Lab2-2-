using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestTriangle
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
            public void TestCalculateHypotenuse_NotRightHypotenuse_ReturnOne()
            {
                var triangle = new Lab2.Triangle();

                var result = triangle.CalculateHypotenuse(2, 4);
                Assert.AreEqual(4.472135954999579, result, 0.1);
            }

        [TestMethod]
        public void TestCalculateHypotenuse_RightHypotenuse_ReturnRightResult()
        {
            var triangle = new Lab2.Triangle();

            var result = triangle.CalculateHypotenuse(2, 4);
            Assert.AreEqual(4.472135954999579, result, 0.1);
        }

        [TestMethod]
        public void TestCalculateArea_NotRightArea_ReturnOne()
        {
            var triangle = new Lab2.Triangle();

            var resultArea = triangle.CalculateArea(10, 20);
            Assert.AreEqual(100, resultArea, 0.1);
        }

        [TestMethod]
        public void TestCalculateArea_RightArea_ReturnRightResult()
        {
            var triangle = new Lab2.Triangle();

            var resultArea = triangle.CalculateArea(10, 20);
            Assert.AreEqual(100, resultArea, 0.1);
        }

        [TestMethod]
        public void TestCalculateAngle_NotRightAngle_ReturnOne()
        {

            var triangle = new Lab2.Triangle();

            var missingAngle = triangle.CalculateMissingAngle(70, 80);
            Assert.AreEqual(30, missingAngle);
        }
    }
}
