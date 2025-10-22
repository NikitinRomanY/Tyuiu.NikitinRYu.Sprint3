using Tyuiu.NikitinRYu.Sprint3.Task1.V25.Lib;

namespace Tyuiu.NikitinRYu.Sprint3.Task1.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int value = 2;
            int startValue = 1;
            int stopValue = 6;
            double wait = 0; // Так как (2²-4)=0
            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            Assert.AreEqual(wait, res);
        }
    }
}
