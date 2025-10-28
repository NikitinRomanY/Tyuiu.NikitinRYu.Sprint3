using Tyuiu.NikitinRYu.Sprint3.Task2.V2.Lib;

namespace Tyuiu.NikitinRYu.Sprint3.Task2.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 7;

            double expected = 1;
            for (int k = 1; k <= 7; k++)
            {
                expected *= Math.Sin(0.1) + k;
            }
            expected = Math.Round(expected, 3);

            double res = ds.GetMultiplySeries(startValue, stopValue);
            Assert.AreEqual(expected, res);
        }
    }
}
