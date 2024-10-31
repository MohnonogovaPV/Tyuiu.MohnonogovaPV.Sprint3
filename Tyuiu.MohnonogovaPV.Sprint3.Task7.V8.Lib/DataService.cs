using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MohnonogovaPV.Sprint3.Task7.V8.Lib
{
    public class DataService : ISprint3Task7V8
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] massfunValue = new double[11];
            int i = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (Math.Sin(x) + 1 == 0) massfunValue[i] = 0;
                else massfunValue[i] = Math.Round((Math.Sin(x) + ((Math.Cos(x) + 1) / (2 - x)) + 2 * x), 2);
                i++;
            }
            return massfunValue;
        }
    }
}
