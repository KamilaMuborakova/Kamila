﻿using System;

namespace WindowsFormsApp1
{
    public class TwoArgumentFactory
    {
        public static ITwoArgumentsCalculate CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "Add":
                    return new AddCalculator();
                case "Substract":
                    return new Substract();
                case "Divide":
                    return new Divide();
                case "Multiply":
                    return new Multiply();
                default:
                    throw new Exception("Неизвестная операция");

            }

        }
    }
}