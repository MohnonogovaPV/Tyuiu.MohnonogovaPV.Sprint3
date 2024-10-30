using Tyuiu.MohnonogovaPV.Sprint3.Task2.V19.Lib;
namespace Tyuiu.MohnonogovaPV.Sprint3.Task2.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Мохноногова П. В. | АСОиУБ - 24-1";
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                                *");
            Console.WriteLine("* Тема: Оператор цикла do-while                                                            *");
            Console.WriteLine("* Задание #2                                                                               *");
            Console.WriteLine("* Вариант #19                                                                              *");
            Console.WriteLine("* Выполнила: Мохноногова Полина Викторовна | АСОиУБ - 24-1                                 *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
            Console.WriteLine("* Написать программу используя цикл do...while,                                            *");
            Console.WriteLine("* которая вычисляет сумму ряда по формуле.                                                 *");
            Console.WriteLine("*                                                                                          *");

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            
            int startValue = 1;
            int stopValue = 10;

            
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                               *");
            Console.WriteLine("********************************************************************************************");

            Console.WriteLine("Сумму ряда = " + ds.GetSumSeries(startValue, stopValue));

            Console.ReadKey();
        }
    }
}
