using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.NikitinRYu.Sprint3.Task6.V8.Lib
{
    public class DataService : ISprint3Task6V8
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int totalSum = 0;

            for (int num = startValue; num <= stopValue; num++)
            {
                // Ищем делители от 12 до num (т.к. делители > 11)
                for (int divisor = 12; divisor <= num; divisor++)
                {
                    if (num % divisor == 0)
                    {
                        totalSum += divisor;
                    }
                }
            }

            return totalSum;
        }
    }
}
