using System;
using System.Reflection;
using TypeClass;

namespace ReadAllFields
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(Product);

            FieldInfo[] fields = type.GetFields();

            foreach (FieldInfo field in fields)
            {
                Console.WriteLine($"Name: {field.Name}");
                Console.WriteLine($"DeclaringType: {field.DeclaringType}");
                Console.WriteLine($"IsFamily: {field.IsFamily}");
                Console.WriteLine($"IsPublic: {field.IsPublic}");
                Console.WriteLine($"IsStatic: {field.IsStatic}");
            }
        }
    }
}
