using Tyuiu.EvseevEI.Sprint2.Task2.V17.Lib;
namespace Tyuiu.EvseevEI.Sprint2.Task2.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Евсеев Е.И. | ИИПБ-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                                                               *");
            Console.WriteLine("* Тема: Логические операции                                                                                                  *");
            Console.WriteLine("* Задание #2                                                                                                                               *");
            Console.WriteLine("* Вариант #17                                                                                                                             *");
            Console.WriteLine("* Выполнил: Евсеев Егор Игоревич | ИИПБ-24-2                                                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                                             *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,                                   *");
            Console.WriteLine("* последовательность можно чередовать, но использовать один раз в выражении)          *");
            Console.WriteLine("*и логических операций (|, &, ||, &&, !, ^, последовательность операций не должна        *");
            Console.WriteLine("*нарушаться), а также арифметических выражений, которая вернет логическую            * ");
            Console.WriteLine("*последовательность(массив): (False, False, False, True, True, True)                                    * ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                                                                                                    *");
            Console.WriteLine("*                                                                                                                                                     *");
            Console.WriteLine("*                                                                                                                                                     *");
            Console.WriteLine("Введите значение переменной  X:");
            int x =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение переменной  Y:");
            int y = Convert.ToInt32(Console.ReadLine());
            DataService ds= new DataService();
            bool res = ds.CheckDotInShadedArea(x, y);
            if (res)
            {
                Console.WriteLine("Точка находится в заштрихованной области");
            }
            else
            {
                Console.WriteLine("Точка не находится в заштрихованной области");
            }
            Console.ReadKey();
        }
    }
}
