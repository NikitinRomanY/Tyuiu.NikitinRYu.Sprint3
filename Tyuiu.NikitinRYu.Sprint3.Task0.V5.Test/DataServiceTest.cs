using Tyuiu.NikitinRYu.Sprint3.Task0.V5.Lib;

namespace Tyuiu.NikitinRYu.Sprint3.Task0.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 10;
            double wait = 38.467; // Примерное значение, нужно вычислить
            double res = ds.GetSumSeries(startValue, stopValue);
            Assert.AreEqual(wait, res);
        }
    }
}
