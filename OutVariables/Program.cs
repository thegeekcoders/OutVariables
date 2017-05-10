using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            Sleep sleep = new Sleep();
            sleep.GetSleep(out int hoursOfSleep);

            ICalculator calc = new Calculator();
           int sum = calc.GetSum(out int no1, out int no2);
            Console.WriteLine($"Sum: {sum}");

            Product product = new Product();

            product.GetProduct(out string name, out decimal price, out int quantity, out bool inStock);

        }
    }
}
