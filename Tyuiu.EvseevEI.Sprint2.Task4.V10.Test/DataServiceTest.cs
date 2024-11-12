using Tyuiu.EvseevEI.Sprint2.Task4.V10.Lib;
namespace Tyuiu.EvseevEI.Sprint2.Task4.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1 ()
        {
            DataService ds = new();
            double x = 0;
            double y = 3;
            double res = ds.Calculate(x, y);
            double wait = 1;
            Assert.AreEqual(wait, res);
        }
        public void ValidCondition2()
        {
            DataService ds = new();
            double x = 1;
            double y = 1;
            double res = ds.Calculate(x, y);
            double wait = 6;
            Assert.AreEqual(wait, res);
        }
    }
}