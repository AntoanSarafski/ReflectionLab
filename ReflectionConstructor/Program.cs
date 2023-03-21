using ActivatorCreateInstance;
using System;

namespace ReflectionConstructor
{
    public class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(Product);

            Product product = (Product)Activator.CreateInstance(type); // That will give exception, cuz we dont have deffault(empty) constructor in Product Class ! 
        }
    }
}
