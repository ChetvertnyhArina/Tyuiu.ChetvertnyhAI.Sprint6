using Tyuiu.ChetvertnyhAI.Sprint6.Task7.V22.Lib;
namespace Tyuiu.ChetvertnyhAI.Sprint6.Task7.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\ТИУ\DataSprint6\InPutDataFileTask7V22.csv";
            int[,] res = ds.GetMatrix(path);
            CollectionAssert.AreEqual(res, res);
        }
    }
}
