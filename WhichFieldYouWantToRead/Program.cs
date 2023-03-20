using System;
using System.Reflection;
using TypeClass;

namespace WhichFieldYouWantToRead
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product()
            {
                field1 = 1,
                field2 = 2,
                field365 = 14,
                model = 3,
                price = 12,
                id = 1488

            };

            while (true)
            {
                Console.WriteLine("Which field you want to read?");
                string fieldName = Console.ReadLine();

                
                Type type = typeof(Product);
                
                FieldInfo field = type.GetField(fieldName);

                if (field == null) continue;

                Console.WriteLine(field.GetValue(product));

                field.SetValue(product, (int)field.GetValue(product) + 1);

            }

        }
    }
}
