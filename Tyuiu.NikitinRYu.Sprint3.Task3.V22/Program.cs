using Tyuiu.NikitinRYu.Sprint3.Task3.V22.Lib;

namespace Tyuiu.NikitinRYu.Sprint3.Task3.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Никитин Р.Ю. | ИБКСб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Никитин Р.Ю. | ИБКСб-25-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach подсчитать максимальное количество букв b,       *");
            Console.WriteLine("* находящихся на соседних позициях в строке: 'tbtbbb dsfbg bbg'           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value = "tbtbbb dsfbg bbg";
            char item = 'b';

            Console.WriteLine($"Исходная строка: {value}");
            Console.WriteLine($"Искомый символ: {item}");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int result = ds.GetMaxCharCount(value, item);

            Console.WriteLine($"Максимальное количество подряд идущих букв '{item}' = {result}");

            Console.ReadKey();
        }
    }
}