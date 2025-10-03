using Tyuiu.KolganenkoRV.Sprint2.Task3.V6.Lib;

namespace Tyuiu.KolganenkoRV.Sprint2.Task3.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 5;
            double res = ds.Calculate(x);
            double wait = 9;//9
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double wait = 0.75;//0.75
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = -5;
            double res = ds.Calculate(x);
            double wait = 0;//0
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -20;
            double wait = -219.95;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}
