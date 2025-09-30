using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KolganenkoRV.Sprint2.Task1.V29.Lib
{
    public class DataService : ISprint2Task1V29
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a > b) | (c < d); //t +
            res[1] = (a + 2 > b) & (c < d + 1); //t + 
            res[2] = (a > b) || (c < d) ; //t + 
            res[3] = !res[1]; //f +
            res[4] = (a + 2 > b) && (c < d + 1); //t + 
            res[5] = (a > b) ^ (c < d); //t + 

            return res;
        }
    }
}
//a = 657
//b = 654
//c = 657
//d = 657