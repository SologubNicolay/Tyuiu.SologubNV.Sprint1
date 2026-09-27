using Tyuiu.SologubNV.Sprint1.Task2.V6.Lib;
namespace Tyuiu.SologubNV.Sprint1.Task2.V6.Test
{
    [TestClass]
    public class DataServiceTest 
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 500;
            var res = ds.ConvertMToKm(x);
            Assert.AreEqual(0.5, res);
        }

        
    }
}
