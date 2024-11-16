using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.EvseevEI.Sprint2.Task7.V8.Lib
{
    public class DataService : ISprint2Task7V8
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if ((y < Math.Pow(x, 2)) & (y < 4) & (y > 0) & (x > 0))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
