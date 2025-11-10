using Tyuiu.BatTI.Sprint4.Task5.V9.Lib;

namespace Tyuiu.BatTI.Sprint4.Task5.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5] { { 9, 9, 8, 6, 9 },

                                           { 5, 8, 8, 8, 7 },

                                           { 6, 5, 9, 7, 9 },

                                           { 7, 7, 9, 7, 8 },

                                           { 8, 5, 8, 5, 5 } };
            int res = ds.Calculate(matrix);
            int wait = 25;
            Assert.AreEqual(wait, res);
        }
    }
}
