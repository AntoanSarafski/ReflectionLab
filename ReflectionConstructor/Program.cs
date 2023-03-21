using ActivatorCreateInstance;
using System;
using System.Reflection;

namespace ReflectionConstructor
{
    public class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(Product);
            ConstructorInfo[] constructors = type.GetConstructors(); // That give us all public constructors!

            Product product = (Product)Activator.CreateInstance(type, new object[] { 5, 5m, "New"}); //Reflection finds a constructor that matches to the given parameters.

            Console.WriteLine(product.Id);
            Console.WriteLine(product.Price);
            Console.WriteLine(product.Model);
        }
    }
}
