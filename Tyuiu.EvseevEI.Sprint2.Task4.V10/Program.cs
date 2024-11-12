using Tyuiu.EvseevEI.Sprint2.Task4.V10.Lib;
namespace Tyuiu.EvseevEI.Sprint2.Task4.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Евсеев Е.И. | ИИПБ-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                                                               *");
            Console.WriteLine("* Тема: Логические операции                                                                                                  *");
            Console.WriteLine("* Задание #3                                                                                                                               *");
            Console.WriteLine("* Вариант #10                                                                                                                             *");
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
            double  x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение переменной  Y:");
            double y = Convert.ToDouble(Console.ReadLine());
            DataService ds = new DataService();

            double res = ds.Calculate(x, y);
            Console.WriteLine("Значение функции ="+res);
            Console.ReadKey();
            
        }
    }
}
