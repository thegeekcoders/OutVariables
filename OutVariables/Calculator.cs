using System;

namespace OutVariables
{
    public class Calculator : ICalculator
    {
        public int GetSum(out int no1, out int no2)
        {
            Console.WriteLine("Enter first number:");
            no1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            no2 = Convert.ToInt32(Console.ReadLine());

            return (no1 + no2);
        }
    }
}
