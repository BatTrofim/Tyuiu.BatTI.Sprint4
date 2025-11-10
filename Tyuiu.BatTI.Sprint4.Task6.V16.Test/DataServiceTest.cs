using Tyuiu.BatTI.Sprint4.Task6.V16.Lib;

namespace Tyuiu.BatTI.Sprint4.Task6.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var car = new string[] { "Автомобиль", "Велосипед", "Самолет", "Поезд", "Трамвай", "Троллейбус", "Метро" };
            string [] res = ds.Calculate(car);
            string[] wait = { "Самолет", "Трамвай" };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
