using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KosishnevaAN.Sprint2.Task6.V10.Lib;

namespace Tyuiu.KosishnevaAN.Sprint2.Task6.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string res;
            Console.Title = "Спринт #1 | Выполнила: Косишнева А. Н. | ИСТНб-23-1";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Спринт #2                                                             *");
            Console.WriteLine("* Тема:Оператор switch                                                  *");
            Console.WriteLine("* Задание #6                                                            *");
            Console.WriteLine("* Вариант #10                                                           *");
            Console.WriteLine("* Выполнила: Косишнева Анастасия Николаенвна | ИСТНб-23-1               *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                              *");
            Console.WriteLine("* Дата некоторого дня характеризуется тремя натуральными числами: g     *");
            Console.WriteLine("* (год), m (порядковый номер месяца) и n (число). По заданным g, n и m  *");
            Console.WriteLine("* определить дату предыдущего дня. Заданный год не является високосным. *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                      *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("Введите день: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите месяц: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите месяц: ");
            int g = Convert.ToInt32(Console.ReadLine());

            if (((m < 1) || (m > 12)) || ((n < 1) || (n > 31)) || ((g<1)))
            {
                res = "Введены не верные значени";

            }
            else
            {
                res = "Предыдущая дата:" + ds.FindDateOfPreviousDay(g, m, n);
            }

            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
