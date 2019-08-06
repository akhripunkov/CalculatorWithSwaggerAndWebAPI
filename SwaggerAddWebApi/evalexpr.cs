using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerAddWebApi
{
    public class evalexpr
    {
        int parse_atom(string str, ref int i)
        {
            int nbr;
            if (str[i] == '(')
            {
                i++;
                nbr = parse_sum(str, ref i);
                if (str[i] == ')')
                    i++;
                return (nbr);
            }
            return (ft_atoi(str, ref i));
        }

        private int ft_atoi(string str, ref int i)
        {
            int nbr;

            nbr = 0;
            while (i < str.Length && str[i] >= '0' && str[i] <= '9')
            {
                nbr = nbr * 10 + (str[i] - '0');
                i++;
            }
            return (nbr);
        }

        int parse_factors(string str, ref int i)
        {
            int nbr;
            int nbr2;
            char op;

            nbr = parse_atom(str, ref i);
            while (i < str.Length)
            {
                op = str[i];
                if (op != '/' && op != '*' && op != '%')
                    return (nbr);
                i++;
                nbr2 = parse_atom(str, ref i);
                if (op == '/')
                    nbr /= nbr2;
                else if (op == '*')
                    nbr *= nbr2;
                else
                    nbr %= nbr2;
            }
            return (nbr);
        }

        int parse_sum(string str, ref int i)
        {
            int nbr;
            int nbr2;
            char op;
            nbr = parse_factors(str, ref i);
            while (i < str.Length)
            {
                op = str[i];
                if (op != '+' && op != '-')
                    return (nbr);
                i++;
                nbr2 = parse_factors(str, ref i);
                if (op == '+')
                    nbr += nbr2;
                else
                    nbr -= nbr2;
            }
            return (nbr);
        }

        public int eval_expr(string str)
        {
            int i;
            
            i = 0;
            str = str.Replace(" ", "");
            return (parse_sum(str, ref i));
        }
    }
}
