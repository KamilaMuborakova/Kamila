﻿namespace WindowsFormsApp1
{
    public class Substract : ITwoArgumentsCalculate
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument - secondArgument;
        }

    }
}