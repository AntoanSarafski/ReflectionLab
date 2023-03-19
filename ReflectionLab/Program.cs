using System;
using System.Reflection;

namespace ReflectionLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(Laptop);

            PropertyInfo[] properties = type.GetProperties();

            foreach (var property in properties)
            {
                Console.WriteLine(property.Name);
            }
        }
    }
}
