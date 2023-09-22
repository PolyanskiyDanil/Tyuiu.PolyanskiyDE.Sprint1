using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.PolyanskiyDE.Sprint1.Task1.V6.Lib
{
    public class DataService : ISprint1Task1V6
    {
        public double Calculate(double x, double y)
        {
            return (x + y) / (3 * y);
        }
    }
}
