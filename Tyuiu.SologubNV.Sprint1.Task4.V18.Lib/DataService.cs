using tyuiu.cources.programming.interfaces.Sprint1;
using static System.Math;
namespace Tyuiu.SologubNV.Sprint1.Task4.V18.Lib
{
    public class DataService : ISprint1Task4V18
    {
        public double Calculate(double x, double y)
        {
            return Round((Sqrt(3 + x) / (Pow(x * y, 2))), 3);
        }
    }
}
