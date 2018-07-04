namespace WindowsFormsApp1.TwoArguments
{
    public class Substract : ITwoArgumentsCalculate
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument - secondArgument;
        }

    }
}
