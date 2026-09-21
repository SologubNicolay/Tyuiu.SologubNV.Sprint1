using Tyuiu.SologubNV.Sprint1.Task1.V28.Lib;
namespace Tyuiu.SologubNV.Sprint1.Task1.V28.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            var res = ds.Calculate(x);
            Assert.Equal(x, res);
        }
    }
}