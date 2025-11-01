using Tyuiu.BatTI.Sprint4.Task0.V29.Lib;

namespace Tyuiu.BatTI.Sprint4.Task0.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] numsArray = { 7, 4, 3, 2, 1, 5, 9, 8, 7, 4 };
            int res = ds.GetSumOddArrEl(numsArray);
            int wait = 32;
            Assert.AreEqual(wait, res);
        }
    }
}
