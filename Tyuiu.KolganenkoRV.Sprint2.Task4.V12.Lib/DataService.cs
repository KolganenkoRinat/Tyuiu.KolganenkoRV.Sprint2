using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KolganenkoRV.Sprint2.Task4.V12.Lib
{
    public class DataService : ISprint2Task4V12
    {
        public double Calculate(double x, double y)
        {
            double z = (Math.Sqrt(x)) > (y * 2) ? (Math.Pow((7.0 + (2.0 / Math.Pow(y, 2))), x)) : ((3.0 * Math.Pow(x, 2) - Math.Cos(Math.Pow(y, 2)) + 10.0) / (Math.Pow(y, 2) - Math.Sin(Math.Pow(x, 2)) + 12.0));
            return Math.Round(z, 3);
        }
    }
}

