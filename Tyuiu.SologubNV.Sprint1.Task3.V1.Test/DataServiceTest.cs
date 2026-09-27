using Tyuiu.SologubNV.Sprint1.Task3.V1.Lib;
namespace Tyuiu.SologubNV.Sprint1.Task3.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 5, y = 10;
            var res = ds.CylinderVolume(x,y);
            Assert.AreEqual(785.398, res);
        }
    }
}
