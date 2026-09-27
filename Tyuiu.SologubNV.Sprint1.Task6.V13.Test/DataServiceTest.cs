using Tyuiu.SologubNV.Sprint1.Task6.V13.Lib;
namespace Tyuiu.SologubNV.Sprint1.Task6.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            string strTest = "abcdefg";
            DataService ds = new DataService();
            bool res = ds.CheckWordsAlphabet(strTest);
            bool wait = true;
            Assert.AreEqual(wait, res);
            
        }
    }
}
