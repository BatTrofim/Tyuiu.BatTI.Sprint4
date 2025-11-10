using Tyuiu.BatTI.Sprint4.Task7.V2.Lib;

namespace Tyuiu.BatTI.Sprint4.Task7.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int n = 3;
            int m = 4;
            string value = "597643158942";
            int[,] matrix = new int[n, m];
            int res = ds.Calculate(n, m, value);
            int wait = 39;
            Assert.AreEqual(wait, res);
        }
    }
}
