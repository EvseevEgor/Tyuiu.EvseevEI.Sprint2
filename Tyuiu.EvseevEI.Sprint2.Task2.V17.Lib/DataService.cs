using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.EvseevEI.Sprint2.Task2.V17.Lib
{
    public class DataService : ISprint2Task2V17
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            if (((x >= 3) &  (x <=5)&& (y >= 3) && (y <= 7)) ||((x >= 3) & (x <= 5)&  (y == 11))|| ((x == 7) && (y == 12)) ||((x >= 6) && (x <= 7) & (y >= 5)&  (y <= 11)) || ((x >= 8) && (x <= 10) && (y >= 5) && (y <= 7)) || ((x >= 9) & (x <= 12) && (y >= 3) && (y <= 4)) || ((x == 10) && (y >= 8) && (y <= 12)) || ((x >= 11) && (x <= 12) && (y >= 10) && (y <= 11)) || ((x >= 11) && (x <= 12) && (y == 5)) && ((x == 13) & (y == 4)))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
