using System;
using System.Reflection;
using TypeClass;

namespace FieldsReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(Product);

            FieldInfo field = type.GetField("price");

            Console.WriteLine($"Name:  {field.Name}");
            Console.WriteLine($"DeclaringType:  {field.DeclaringType}");
            Console.WriteLine($"IsFamily:  {field.IsFamily}");
            Console.WriteLine($"IsPrivate:  {field.IsPrivate}");
            Console.WriteLine($"IsPublic:  {field.IsPublic}");
            Console.WriteLine($"IsStatic:  {field.IsStatic}");





        }
    }
}
