using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KolganenkoRV.Sprint2.Task0.V26.Lib
{
    public class DataService : ISprint2Task0V26
    {
        // x=1045 y=975
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x == y; //f
            res[1] = x != y + 70; //f
            res[2] = x < y  ; //f
            res[3] = x > y; //t
            res[4] = x <= y + 70; //t
            res[5] = x >= y; //t

            return res;
        }
    }
}
