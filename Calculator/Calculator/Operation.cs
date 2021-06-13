using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Operation
    {
        public static int Pluses(int firstArg, int secondArg)
        {
            return firstArg + secondArg;
        }
        public static int Minuses(int firstArg, int secondArg)
        {
            return firstArg - secondArg;
        }
        public static int Multiplys(int firstArg, int secondArg)
        {
            return firstArg * secondArg;
        }
        public static int Divides(int firstArg, int secondArg)
        {
            return firstArg / secondArg;
        }
    }
}
