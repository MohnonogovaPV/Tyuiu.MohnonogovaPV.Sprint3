using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MohnonogovaPV.Sprint3.Task3.V2.Lib
{
    public class DataService : ISprint3Task3V2
    {
        public int GetMaxCharCount(string value, char item)
        {
            int currentCount = 0;
            int maxCount = 0;
            string str = "asdzzz vfvfzz v gthvz";

            foreach (char c in str)
            {
                if (c == 'z')
                {
                    currentCount++;
                }
                else
                {
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                    }
                    currentCount = 0;
                }
            }
            if (currentCount > maxCount)
            {
                maxCount = currentCount;
            }
            return maxCount;
        }
    }
}
