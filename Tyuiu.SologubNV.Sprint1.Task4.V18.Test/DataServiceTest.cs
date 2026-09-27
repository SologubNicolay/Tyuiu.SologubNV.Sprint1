using Tyuiu.SologubNV.Sprint1.Task4.V18.Lib;
namespace Tyuiu.SologubNV.Sprint1.Task4.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 6;
            double y = 1;
            double wait = 0.083;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
