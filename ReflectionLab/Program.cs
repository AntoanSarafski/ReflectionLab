using System;
using System.Reflection;

namespace ReflectionLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(Laptop);

            PrintProperties(typeof(Laptop));

            PrintProperties(typeof(Mouse));

            void PrintProperties(Type type)
            {
                Console.WriteLine("\n---------");
                Console.WriteLine(type.Name);
                Console.WriteLine("---------");

                PropertyInfo[] properties = type.GetProperties();

                foreach (var property in properties)
                {
                    Console.WriteLine(property.Name);
                }
            }
        }
    }
}
