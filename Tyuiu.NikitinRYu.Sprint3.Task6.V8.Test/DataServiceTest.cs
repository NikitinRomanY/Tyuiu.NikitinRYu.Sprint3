using Tyuiu.NikitinRYu.Sprint3.Task6.V8.Lib;

namespace Tyuiu.NikitinRYu.Sprint3.Task6.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int startValue = 18;
            int stopValue = 28;

            // Вычисляем ожидаемое значение вручную
            int wait = 0;
            for (int num = 18; num <= 28; num++)
            {
                for (int d = 12; d <= num; d++)
                {
                    if (num % d == 0)
                    {
                        wait += d;
                    }
                }
            }

            int res = ds.GetSumTheDivisors(startValue, stopValue);
            Assert.AreEqual(wait, res);
        }
    }
}
