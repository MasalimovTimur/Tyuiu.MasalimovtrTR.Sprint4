using Tyuiu.MasalimovtrTR.Sprint4.Task0.V1.Lib;

namespace Tyuiu.MasalimovtrTR.Sprint4.Task0.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] numsArray= { 6, 4, 3, 2, 1, 0, 9, 8, 7, 5 };
            int res = ds.GetSumEvenArrEl(numsArray);
            Assert.AreEqual(5, res);
        }
    }
}