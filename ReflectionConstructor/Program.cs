using ActivatorCreateInstance;
using System;

namespace ReflectionConstructor
{
    public class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(Product);

            Product product = (Product)Activator.CreateInstance(type, new object[] { 5, 5m, "New"}); //Reflection finds a constructor that matches to the given parameters.

            Console.WriteLine(product.Id);
            Console.WriteLine(product.Price);
            Console.WriteLine(product.Model);
        }
    }
}
