using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KosishnevaAN.Sprint2.Task7.V5.Lib;

namespace Tyuiu.KosishnevaAN.Sprint2.Task7.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Title = "Спринт #1 | Выполнила: Косишнева А. Н. | ИСТНб-23-1";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Спринт #2                                                             *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту               *");
            Console.WriteLine("* Задание #7                                                            *");
            Console.WriteLine("* Вариант #5                                                            *");
            Console.WriteLine("* Выполнила: Косишнева Анастасия Николаенвна | ИСТНб-23-1               *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                              *");
            Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные         *");
            Console.WriteLine("* (вещественные значения) и вычисляет, находится ли точка               *");
            Console.WriteLine("* с координатами X,Y в заштрихованной области.                          *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                      *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("Введите значение X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");

            if (res)
            {
                Console.WriteLine("Точка находится в звштрихованной области");
            }
            else
            {
                Console.WriteLine("Точка не находится в заштрихованной области");
            }

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
