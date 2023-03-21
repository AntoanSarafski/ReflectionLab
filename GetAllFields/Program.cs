using System;
using System.Reflection;

namespace GetAllFields
{
    class Program
    {
        static void Main(string[] args)
        {

            Type type = typeof(Product);

            
            BindingFlags allFields = BindingFlags.NonPublic
                | BindingFlags.Instance
                | BindingFlags.Static
                | BindingFlags.Public;

            FieldInfo[] fields = type.GetFields(allFields);

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
