using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ChetvertnyhAI.Sprint6.Task0.V15.Lib;
namespace Tyuiu.ChetvertnyhAI.Sprint6.Task0.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double wait = 64;
            Assert.AreEqual(wait, res);
        }
    }
}
