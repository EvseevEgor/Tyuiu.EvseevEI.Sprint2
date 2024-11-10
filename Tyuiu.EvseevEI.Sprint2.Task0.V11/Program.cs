using Tyuiu.EvseevEI.Sprint2.Task0.V11.Lib;
namespace Tyuiu.EvseevEI.Sprint2.Task0.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 8105;
            int y = 275;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            Console.Title = "Спринт #2 | Выполнил: Евсеев Е.И. | ИИПБ-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                                                       *");
            Console.WriteLine("* Тема: Операции сравнения                                                                                           *");
            Console.WriteLine("* Задание #0                                                                                                                      *");
            Console.WriteLine("* Вариант #11                                                                                                                    *");
            Console.WriteLine("* Выполнил: Евсеев Егор Игоревич | ИИПБ-24-2                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                                    *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,                           *");
            Console.WriteLine("* последовательность операций не должна нарушаться) и арифметических            *");
            Console.WriteLine("*  выражений, которая вернет логическую последовательность(массив):                 *");
            Console.WriteLine("*(True, False, True, False, True, False)                                                                             * ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* x = 8105, y = 275                                                                                                           *");
            Console.WriteLine("*                                                                                                                                        *");
            Console.WriteLine("*                                                                                                                                        *");
            for (int i=0; i<6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
