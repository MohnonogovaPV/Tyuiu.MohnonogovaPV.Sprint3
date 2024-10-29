﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MohnonogovaPV.Sprint3.Task1.V20.Lib
{
    public class DataService : ISprint3Task1V20
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sumSeries = 0;

            while (startValue <= stopValue)
            {
                sumSeries += (Math.Pow(1 / Math.Cos(startValue), 2));
                startValue++;
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
