using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.NikitinRYu.Sprint3.Task4.V20.Lib
{
    public class DataService : ISprint3Task4V20
    {
        public double Calculate(int startValue, int stopValue)
        {
            double product = 1;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    continue; // Пропускаем x = 0
                }

                double denominator = Math.Cos(x) - x;

                // Проверка деления на ноль
                if (Math.Abs(denominator) < 0.001)
                {
                    continue; // Пропускаем значения, где знаменатель близок к нулю
                }

                double y = x / denominator + 2.5;
                product *= y;
            }

            return Math.Round(product, 3);
        }
    }
}
