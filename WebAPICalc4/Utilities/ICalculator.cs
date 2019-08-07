namespace WebAPICalc4.Utilities
{
    public interface ICalculator
    {
        int Add(int a, int b);
        int Div(int a, int b);
        int Mult(int a, int b);
        int Sub(int a, int b);
        int Eval(string str);
    }
}