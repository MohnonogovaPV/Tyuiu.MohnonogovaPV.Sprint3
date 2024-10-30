using Tyuiu.MohnonogovaPV.Sprint3.Task2.V19.Lib;
namespace Tyuiu.MohnonogovaPV.Sprint3.Task2.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 10;

            double res = ds.GetSumSeries(startValue, stopValue);
            double wait = 4.971;
            Assert.AreEqual(wait, res);
        }
    }
}