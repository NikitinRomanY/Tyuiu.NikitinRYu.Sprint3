using Tyuiu.NikitinRYu.Sprint3.Task5.V25.Lib;

namespace Tyuiu.NikitinRYu.Sprint3.Task5.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();
            int x = 2;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 10;

            // Вычисляем ожидаемое значение
            double innerSum = 0;
            for (int k = 1; k <= 10; k++)
            {
                innerSum += Math.Pow(2, k) + Math.Cos(k);
            }
            double wait = 3 * innerSum;
            wait = Math.Round(wait, 3);

            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            Assert.AreEqual(wait, res);
        }
    }
}
