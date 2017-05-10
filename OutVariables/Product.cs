using System;

namespace OutVariables
{
    public class Product
    {
        public void GetProduct(out string name,out decimal price ,out int quantity, out bool inStock)
        {
            name = "Bag";
            price = 900;
            quantity = 20;
            inStock = true;
            Console.WriteLine($"Name:{name},Price:{price},Quantity:{quantity},Instock:{inStock}");
        }
    }
}
