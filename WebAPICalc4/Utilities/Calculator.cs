using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPICalc4.Utilities;

namespace WebAPICalc4.Utilities
{
    public class Calculator : ICalculator
    {
        public int Add(int a, int b)
        {
            return (a + b);
        }

        public int Sub(int a, int b)
        {
            return (a - b);
        }

        public int Mult(int a, int b)
        {
            return (a * b);
        }

        public int Div(int a, int b)
        {
            if (b == 0)
                return Int32.MaxValue;
            return (a / b);
        }

        public int Eval(string str)
        {
            int i;

            i = 0;
            str = str.Replace(" ", "");
            return (new FunctionsForStringCalc().parse_sum(str, ref i));
        }
    }
}
