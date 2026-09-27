using Tyuiu.SologubNV.Sprint1.Task5.V7.Lib;
namespace Tyuiu.SologubNV.Sprint1.Task5.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double x = 60;
            DataService ds = new DataService();
            int res = ds.AngleToHoursMinutes(x);
            int wait = 2;
            Assert.AreEqual(wait, res);
            
        }
    }
}
