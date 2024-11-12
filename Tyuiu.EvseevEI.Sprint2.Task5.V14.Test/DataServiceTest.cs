using Tyuiu.EvseevEI.Sprint2.Task5.V14.Lib;
namespace Tyuiu.EvseevEI.Sprint2.Task5.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var dataService = new DataService();
            Assert.AreEqual("Четверг", dataService.FindDayName(5, 1));

        }
    }
}