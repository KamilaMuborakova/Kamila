namespace WindowsFormsApp1
{
    public class Multiply : ITwoArgumentsCalculate
    {
       public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument * secondArgument;
        }

    }
}
