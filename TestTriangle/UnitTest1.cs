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
    }
}
