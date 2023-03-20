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

                //try
                //{
                //    GetFieldValue(DateTime.Now, fieldName);
                //}
                //catch (Exception)
                //{

                //    Console.WriteLine("No Such Field");
                //}
                



            }

            void GetFieldValue(object obj, string fieldName)
            {

                Type type = obj.GetType();

                FieldInfo field = type.GetField(fieldName);


                Console.WriteLine(field.GetValue(product));

                //field.SetValue(product, (int)field.GetValue(product) + 1);
            }
        }
    }
}


