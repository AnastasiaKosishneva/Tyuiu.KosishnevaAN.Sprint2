using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KosishnevaAN.Sprint2.Task2.V9.Lib;

namespace Tyuiu.KosishnevaAN.Sprint2.Task2.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнила: Косишнева А. Н. | ИСТНб-23-1";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Спринт #2                                                             *");
            Console.WriteLine("* Тема: Логические операции                                             *");
            Console.WriteLine("* Задание #2                                                            *");
            Console.WriteLine("* Вариант #9                                                            *");
            Console.WriteLine("* Выполнила: Косишнева Анастасия Николаенвна | ИСТНб-23-1               *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                              *");
            Console.WriteLine("* Написать программу на, которая запрашивает целые значения с           *");
            Console.WriteLine("* клавиатуры и вычисляет находится ли точка с координатами X,Y в        *");
            Console.WriteLine("* заштрихованной области.                                               *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                      *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("Введите значения переменной X:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значения переменной Y:");
            int y = Convert.ToInt32(Console.ReadLine());
            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");
            if (res)
            {
                Console.WriteLine("Точка находится в заштрихованной обасти");
            }
            else
            {
                Console.WriteLine("Точка не находится в заштрихованной обасти");
            }
            Console.ReadKey();
        }
    }
}
