using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KosishnevaAN.Sprint2.Task5.V8.Lib
{
    public class DataService : ISprint2Task5V8
    {
        public string FindDateOfPreviousDay(int m, int n)
        {
         
           switch (m)
            {
                case 1:
                    m = 1;
                    n = n - 1;
                    break;
                case 2:
                    m = 2;
                    n = n - 1;
                    break;
                case 3:
                    m = 3;
                    n = n - 1;
                    break;
                case 4:
                    m = 4;
                    n = n - 1;
                    break;
                case 5:
                    m = 5;
                    n = n - 1;
                    break;
                case 6:
                    m = 6;
                    n = n - 1;
                    break;
                case 7:
                    m = 7;
                    n = n - 1;
                    break;
                case 8:
                    m = 8;
                    n = n - 1;
                    break;
                case 9:
                    m = 9;
                    n = n - 1;
                    break;
                case 10:
                    m = 10;
                    n = n - 1;
                    break;
                case 11:
                    m = 11;
                    n = n - 1;
                    break;
                case 12:
                    m = 12;
                    n = n - 1;
                    break;
                    

            }
            return ;
        }
    }
}
