using Tyuiu.NikitinRYu.Sprint3.Task7.V11.Lib;

namespace Tyuiu.NikitinRYu.Sprint3.Task7.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Никитин Р.Ю. | ИБКСб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Никитин Р.Ю. | ИБКСб-25-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:          *");
            Console.WriteLine("* F(x) = cos(x) + sin(x)/(2 - 2x) - 4x на диапазоне [-5;5] с шагом 1     *");
            Console.WriteLine("* Произвести проверку деления на ноль. При делении на ноль вернуть 0.     *");
            Console.WriteLine("* Значения занести в массив, округлить до 2 знаков после запятой.         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine($"Старт шага = {startValue}");
            Console.WriteLine($"Конец шага = {stopValue}");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            double[] result = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("+----------+-----------+");
            Console.WriteLine("|    X     |    F(x)   |");
            Console.WriteLine("+----------+-----------+");

            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                Console.WriteLine("|{0,5:d}     | {1,8:f2}  |", x, result[count]);
                count++;
            }
            Console.WriteLine("+----------+-----------+");

            Console.ReadKey();
        }
    }
}