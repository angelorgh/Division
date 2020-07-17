using System;

namespace DivisionServices
{
    public class Division
    {
        public static double Divide(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new System.DivideByZeroException("Cannot divide by 0");
            }
            double result= num1 / num2;
            return result;
        }

    }
}
