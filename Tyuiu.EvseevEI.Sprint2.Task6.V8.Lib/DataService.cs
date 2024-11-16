using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.EvseevEI.Sprint2.Task6.V8.Lib
{
    public class DataService : ISprint2Task6V8
    {
        public string FindDateOfPreviousDay(int d, int m)
        {
            {
                d -= 1;
                if (d == 0)
                {
                    m -= 1;
                    switch (m)
                    {
                        case 1: d = 31; break;
                        case 2: d = 28; break;
                        case 3: d = 31; break;
                        case 4: d = 30; break;
                        case 5: d = 31; break;
                        case 6: d = 30; break;
                        case 7: d = 31; break;
                        case 8: d = 31; break;
                        case 9: d = 30; break;
                        case 10: d = 31; break;
                        case 11: d = 30; break;
                        case 12: d = 31; break;
                        default: throw new ArgumentException("Месяц должен быть от 1 до 12");
                    }
                }
                switch (m)
                {
                    case 1: return $"{d}.0{m}";
                    case 2: return $"{d}.0{m}";
                    case 3: return $"{d}.0{m}";
                    case 4: return $"{d}.0{m}";
                    case 5: return $"{d}.0{m}";
                    case 6: return $"{d}.0{m}";
                    case 7: return $"{d}.0{m}";
                    case 8: return $"{d}.0{m}";
                    case 9: return $"{d}.0{m}";
                    case 10: return $"{d}.{m}";
                    case 11: return $"{d}.{m}";
                    case 12: return $"{d}.{m}";
                    default: throw new ArgumentException("Месяц должен быть от 1 до 12");
                }
            }
        }
    }
}
     
