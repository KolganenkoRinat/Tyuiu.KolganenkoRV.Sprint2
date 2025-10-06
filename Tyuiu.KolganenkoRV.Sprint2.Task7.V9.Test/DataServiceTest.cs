using Tyuiu.KolganenkoRV.Sprint2.Task7.V9.Lib;

namespace Tyuiu.KolganenkoRV.Sprint2.Task7.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x = 0;
            double y = 0;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(true, res);
        }
    }
}
