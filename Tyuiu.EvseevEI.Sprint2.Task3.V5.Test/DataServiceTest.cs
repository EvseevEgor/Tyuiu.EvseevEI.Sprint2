using Tyuiu.EvseevEI.Sprint2.Task3.V5.Lib;
namespace Tyuiu.EvseevEI.Sprint2.Task3.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void ValidCondition1()
        {
            double x = 2;
            double res = ds.Calculate(x);
            double wait = -7;
            Assert.AreEqual(wait, res);
        }
        public void ValidCondition2()
        {
            double x = 0;
            double res = ds.Calculate(x);
            double wait = (0-1) / 12;
            Assert.AreEqual(wait, res);
        }
        public void ValidCondition3()
        {
            double x = -1;
            double res = ds.Calculate(x);
            double wait = 1 / 10;
            Assert.AreEqual(wait, res);
        }
        public void ValidCondition4()
        {
            double x = 1;
            double res = ds.Calculate(x);
            double wait = 10;
            Assert.AreEqual(wait, res);
        }


    }
}
