using System.ComponentModel.Design;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KolganenkoRV.Sprint2.Task7.V9.Lib
{
    public class DataService : ISprint2Task7V9
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((y >= Math.Sin(x * Math.PI / 180)) && (x >= 0) && (x <= 180) && (y >= 0) && (y < 0.5))
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
