using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KosishnevaAN.Sprint2.Task7.V5.Lib
{
    public class DataService : ISprint2Task7V5
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((y - Math.Exp(-x) <= 0) && (y - Math.Exp(x) <= 0) && (y - x * x > 0))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
