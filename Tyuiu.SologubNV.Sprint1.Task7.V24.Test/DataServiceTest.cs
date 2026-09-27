using Tyuiu.SologubNV.Sprint1.Task7.V24.Lib;
namespace Tyuiu.SologubNV.Sprint1.Task7.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            double wait = 1.101;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
