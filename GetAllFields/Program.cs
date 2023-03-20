using System;
using System.Reflection;

namespace GetAllFields
{
    class Program
    {
        static void Main(string[] args)
        {

            Type type = typeof(Product);

            FieldInfo[] fields = type.GetFields(
                BindingFlags.NonPublic
                | BindingFlags.Instance
                | BindingFlags.Static
                | BindingFlags.Public);

            foreach (FieldInfo field in fields)
            {
                Console.WriteLine(field.Name);
            }
        }

        class Product
        {
            private int privateField;
            protected int protectedField;
            internal int internalField;
            public int publicField;

            public static int publicStaticField;
        }

    }
}
