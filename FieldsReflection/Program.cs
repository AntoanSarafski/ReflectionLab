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

            FieldInfo[] fields = type.GetFields();

            Console.WriteLine(fields.Length); // Thats the way to show us only PUBLIC fields.

        }
    }
}
