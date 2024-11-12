using Tyuiu.EvseevEI.Sprint2.Task5.V14.Lib;
namespace Tyuiu.EvseevEI.Sprint2.Task5.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Милюков Л. О. | ИИПб 24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                                ");
            Console.WriteLine("* Тема: Организация ввода\\вывода в консольных приложениях                 ");
            Console.WriteLine("* Задание #5                                                               ");
            Console.WriteLine("* Вариант #14                                                              ");
            Console.WriteLine("* Выполнил: Милюков Леонид Олегович | ИИПб 24-2                            ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет         ");
            Console.WriteLine("* требуемое значение и возвращает результат.                               ");
            Console.WriteLine("* Дано целое число k (1 <= k <= 365). Определить, каким днем недели        ");
            Console.WriteLine("* (понедельником, вторником, …, субботой или воскресеньем) является        ");
            Console.WriteLine("* k-й день не високосного года, в котором 1 января d-й день недели (если 1 ");
            Console.WriteLine("* января — понедельник, то d = 1 , если вторник — d = 2 , …, если воскресен");
            Console.WriteLine("* — d = 7).                                                                ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Введите значние х:                                                       ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("* Введите значние y:                                                       ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*                                                                          ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.FindDayName(x, y));

            Console.ReadKey();

        }
    }
}
