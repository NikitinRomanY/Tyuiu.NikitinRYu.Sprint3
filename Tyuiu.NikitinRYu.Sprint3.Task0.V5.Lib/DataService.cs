using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.NikitinRYu.Sprint3.Task0.V5.Lib
{
    public class DataService : ISprint3Task0V5
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sum = 0;
            for (int k = startValue; k <= stopValue; k++)
            {
                sum += 1.0 / (Math.Sin(k) * Math.Sin(k));
            }
            return Math.Round(sum, 3);
        }
    }
}
