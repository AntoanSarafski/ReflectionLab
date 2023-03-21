using System;
using System.Reflection;

namespace ReflectionProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            PropertyInfo[] properties = typeof(Product).GetProperties((BindingFlags)60);

            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine($"Name: {property.Name}");
                Console.WriteLine($"Type: {property.PropertyType.Name}");
            }
        }
    }

    class Product
    {
        public int Id { get; set; }
        public int Model { get; set; }
    }
}
