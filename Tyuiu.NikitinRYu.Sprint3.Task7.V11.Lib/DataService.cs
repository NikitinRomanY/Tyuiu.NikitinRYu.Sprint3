using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.NikitinRYu.Sprint3.Task7.V11.Lib
{
    public class DataService : ISprint3Task7V11
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray = new double[stopValue - startValue + 1];

            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                // Проверка деления на ноль (2 - 2x = 0 → x = 1)
                if (x == 1)
                {
                    valueArray[count] = 0;
                }
                else
                {
                    double denominator = 2 - 2 * x;
                    double term = Math.Sin(x) / denominator;
                    double fx = Math.Cos(x) + term - 4 * x;
                    valueArray[count] = Math.Round(fx, 2);
                }
                count++;
            }

            return valueArray;
        }
    }
}
