using Tyuiu.EvseevEI.Sprint2.Task6.V8.Lib;
namespace Tyuiu.EvseevEI.Sprint2.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new ();
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
           {
                Assert.AreEqual("28 ôåâðàëÿ", ds.FindDateOfPreviousDay(1, 3));
                Assert.AreEqual("25 ôåâðàëÿ", ds.FindDateOfPreviousDay(26, 2));
                Assert.AreEqual("2 èþíÿ", ds.FindDateOfPreviousDay(3, 6));
            }
        
    }
}
 