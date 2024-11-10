using Tyuiu.EvseevEI.Sprint2.Task1.V20.Lib;
namespace Tyuiu.EvseevEI.Sprint2.Task1.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds= new DataService();
            int a = 242;
            int b = 155;
            int c = 456;
            int d = 17;

            bool[] res = new bool[6];
            res=ds.GetLogicOperations(a, b, c, d);
            Console.Title = "Спринт #2 | Выполнил: Евсеев Е.И. | ИИПБ-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                                                       *");
            Console.WriteLine("* Тема: Логические операции                                                                                         *");
            Console.WriteLine("* Задание #1                                                                                                                      *");
            Console.WriteLine("* Вариант #20                                                                                                                    *");
            Console.WriteLine("* Выполнил: Евсеев Егор Игоревич | ИИПБ-24-2                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                                    *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,                          *");
            Console.WriteLine("* последовательность можно чередовать, но использовать один раз в выражении) *");
            Console.WriteLine("*и логических операций (|, &, ||, &&, !, ^, последовательность операций не должна*");
            Console.WriteLine("*нарушаться), а также арифметических выражений, которая вернет логическую  * ");
            Console.WriteLine("*последовательность(массив): (False, False, False, True, True, True)                          * ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*    a = 242, b = 155, c = 456, d = 17                                                                                *");
            Console.WriteLine("*                                                                                                                                        *");
            Console.WriteLine("*                                                                                                                                        *");
            for (int i = 0; i < 6; i++)
            { 
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();

        }
    }
}
