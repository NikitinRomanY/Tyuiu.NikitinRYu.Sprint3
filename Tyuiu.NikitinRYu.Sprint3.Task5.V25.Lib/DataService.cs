using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.NikitinRYu.Sprint3.Task5.V25.Lib
{
    public class DataService : ISprint3Task5V25
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double totalSum = 0;

            for (int i = startValue1; i <= stopValue1; i++)
            {
                double innerSum = 0;
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    innerSum += Math.Pow(x, k) + Math.Cos(k);
                }
                totalSum += innerSum;
            }

            return Math.Round(totalSum, 3);
        }
    }
}
