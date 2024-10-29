using Tyuiu.MohnonogovaPV.Sprint3.Task1.V20.Lib;
namespace Tyuiu.MohnonogovaPV.Sprint3.Task1.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 16;

            double res = ds.GetSumSeries(startValue, stopValue);

            double wait = 16.471;
            Assert.AreEqual(wait, res);
        }
    }
}