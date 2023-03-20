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

            FieldInfo field = type.GetField("id");


        }
    }
}
