using Tyuiu.NikitinRYu.Sprint3.Task5.V25.Lib;

namespace Tyuiu.NikitinRYu.Sprint3.Task5.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Никитин Р.Ю. | ИБКСб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Никитин Р.Ю. | ИБКСб-25-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить y = ∑_{i=1}^3 ∑_{k=1}^{10} (x^k + cos(k)) при x=2             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 2;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 10;

            Console.WriteLine($"Переменная X = {x}");
            Console.WriteLine($"Старт шага внешнего цикла = {startValue1}");
            Console.WriteLine($"Конец шага внешнего цикла = {stopValue1}");
            Console.WriteLine($"Старт шага внутреннего цикла = {startValue2}");
            Console.WriteLine($"Конец шага внутреннего цикла = {stopValue2}");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            double result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            Console.WriteLine($"Сумма ряда = {result}");

            Console.ReadKey();
        }
    }
}