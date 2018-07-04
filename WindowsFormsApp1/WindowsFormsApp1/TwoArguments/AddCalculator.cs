namespace WindowsFormsApp1
{
    public class AddCalculator: ITwoArgumentsCalculate
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument + secondArgument;
        }

    }
}