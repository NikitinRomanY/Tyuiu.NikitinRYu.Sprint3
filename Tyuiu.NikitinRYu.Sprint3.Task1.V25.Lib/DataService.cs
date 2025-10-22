using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.NikitinRYu.Sprint3.Task1.V25.Lib
{
    public class DataService : ISprint3Task1V25
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double p = 1;
            int k = startValue;

            while (k <= stopValue)
            {
                p *= (Math.Pow(value, k) - 0.25) * Math.Cos(5);
                k++;
            }

            return Math.Round(p, 3);
        }
    }
}
