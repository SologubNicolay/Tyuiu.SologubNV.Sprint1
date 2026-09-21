using System.Security.Cryptography.X509Certificates;
using Tyuiu.SologubNV.Sprint1.Task0.V20.Lib;
namespace Tyuiu.SologubNV.Sprint1.Task0.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculated()
        {
            DataService ds = new DataService();
            var result = ds.Calculate();
            Assert.AreEqual(13 , result);
        }
    }
}