using Tyuiu.ChetvertnyhAI.Sprint6.Task5.V3.Lib;
namespace Tyuiu.ChetvertnyhAI.Sprint6.Task5.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\ТИУ\DataSprint6\InPutDataFileTask5V3.txt";
            double[] res = ds.LoadFromDataFile(path);
            double[] wait = { 2.5, -2.6, 5.7, -6.8, 9.9};
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
