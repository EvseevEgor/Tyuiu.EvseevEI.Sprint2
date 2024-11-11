using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.EvseevEI.Sprint2.Task3.V5.Lib
{
    public class DataService : ISprint2Task3V5
    {
        public double Calculate(double x)
        {
            double y = 0;
            if (x > 1)
            {
                y = x - Math.Pow(((x + 1) / (x - 1)), x);
            } else if ( x == 0)
            {
                y = (Math.Pow(x, 2) - Math.Cos(Math.Pow(x, 2))) / (Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2) + 12));
            } else if ((x > -9) && (x < 0))
            {
                y = Math.Pow(6 + 4 / Math.Pow(x, 2), x);
            } else if (x < -9)
            {
                y = Math.Pow(x, 3) + 10 * x - (Math.Pow(x, 2) / Math.Pow(x, 4));
            }
            return y;
        }
    }
}
