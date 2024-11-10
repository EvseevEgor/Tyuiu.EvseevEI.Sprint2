using Tyuiu.EvseevEI.Sprint2.Task1.V20.Lib;
namespace Tyuiu.EvseevEI.Sprint2.Task1.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();
            int a = 242;
            int b = 155;
            int c = 456;
            int d = 17;
            bool[] res = new bool[6];
            res =ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] { false, false, false, true, true, true };


            CollectionAssert.AreEqual(wait, res);
        }
    }
}