using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.EvseevEI.Sprint2.Task6.V8.Lib
{
    public class DataService : ISprint2Task6V8
    {
        DataService ds = new();
        public string FindDateOfPreviousDay(int m, int n, string? dateOfPreviousDay)
        {
            if (m < 1 || m > 12 || n < 1 || n > DaysInMonth(m))
            {
                throw new ArgumentException("Некорректные значения  месяца или дня.");
            }

            // Создаем текущую дату
            DateTime currentDate = new DateTime(2023, m, n); // Можно использовать любой год, неважно

            // Вычисляем предыдущую дату
            DateTime previousDate = currentDate.AddDays(-1);

            string? DateOfPreviousDay = null;
            return DateOfPreviousDay;
        }

        private static int DaysInMonth(int month)
        {
            switch (month)
            {
                case 1: // Январь
                case 3: // Март
                case 5: // Май
                case 7: // Июль
                case 8: // Август
                case 10: // Октябрь
                case 12: // Декабрь
                    return 31;
                case 4: // Апрель
                case 6: // Июнь
                case 9: // Сентябрь
                case 11: // Ноябрь
                    return 30;
                case 2: // Февраль
                    return 28; // Не учитываем високосные годы для упрощения
                default:
                    throw new ArgumentOutOfRangeException("Некорректный номер месяца.");
            }
        }

        public string FindDateOfPreviousDay(int m, int n)
        {
            throw new NotImplementedException();
        }
    }
}


