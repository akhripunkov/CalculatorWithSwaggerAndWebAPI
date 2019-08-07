using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPICalc4.Utilities;

namespace WebAPICalc4.Utilities
{
    public class Calculator : ICalculator
    {
        public long Add(int a, int b)
        {
            return (long)a + (long)b;
        }

        public long Sub(int a, int b)
        {
            return (long)a - (long)b;
        }

        public long Mult(int a, int b)
        {
            return (long)a * (long)b;
        }

        public long Div(int a, int b)
        {
            if (b == 0)
                return long.MaxValue;
            return (long)a / (long)b;
        }

        public long Eval(string str)
        {
            int i;

            i = 0;
            str = str.Replace(" ", "");
            return (long)(new FunctionsForStringCalc().parse_sum(str, ref i));
        }
    }
}
