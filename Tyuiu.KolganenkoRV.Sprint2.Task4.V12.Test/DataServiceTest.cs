using Tyuiu.KolganenkoRV.Sprint2.Task4.V12.Lib;

namespace Tyuiu.KolganenkoRV.Sprint2.Task4.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 1;
            double wait = 4.324;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);          
        }
        
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 36;
            double y = 4;
            double wait = 144.383;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);

        }
    }
}
