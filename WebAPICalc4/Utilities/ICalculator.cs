namespace WebAPICalc4.Utilities
{
    public interface ICalculator
    {
        long Add(int a, int b);
        long Div(int a, int b);
        long Mult(int a, int b);
        long Sub(int a, int b);
        long Eval(string str);
    }
}