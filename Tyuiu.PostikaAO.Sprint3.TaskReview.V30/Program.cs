using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PostikaAO.Sprint3.TaskReview.V30.Lib;

namespace Tyuiu.PostikaAO.Sprint3.TaskReview.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Постика А. О. | ИИПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант 30                                                             *");
            Console.WriteLine("* Выполнил: Постика Артём Олегович | ИИПб-23-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу                                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueArray;
            valueArray = new double[len];

            valueArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("+----------+------------+");
            Console.WriteLine("+    x     |   f(x)     +");
            Console.WriteLine("+----------+------------+");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("| {0,5:d}    |  {1, 6:f2}     |", startValue, valueArray[i]);
                startValue++;
            }
            Console.WriteLine("+----------+------------+");
            Console.ReadLine();



        }
    }
}
