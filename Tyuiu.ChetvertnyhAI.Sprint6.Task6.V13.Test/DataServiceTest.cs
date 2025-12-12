using Tyuiu.ChetvertnyhAI.Sprint6.Task6.V13.Lib;
namespace Tyuiu.ChetvertnyhAI.Sprint6.Task6.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\ТИУ\DataSprint6\InPutDataFileTask6V13.txt";
            string res = ds.CollectTextFromFile(path);
            Assert.AreEqual(res, res);
        }
    }
}
