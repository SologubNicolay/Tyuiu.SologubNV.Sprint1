using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.SologubNV.Sprint1.Task7.V24.Lib
{
    public class DataService : ISprint1Task7V24
    {
        public double Calculate(double x, double y)
        {
            double a = 1 + Math.Cos(Math.Sqrt(x + 1));
            double b = Math.Sin((15 * y) - 4);
            return Math.Round(a / b,3);
        }
    }
}
