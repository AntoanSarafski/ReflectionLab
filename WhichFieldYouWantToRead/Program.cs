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
                string propertyName = Console.ReadLine();

                try
                {
                    GetPropertyValue(DateTime.Now, propertyName);
                }
                catch (Exception)
                {

                    Console.WriteLine("No Such Property");
                }




            }

            void GetPropertyValue(object obj, string propertyName)
            {

                Type type = obj.GetType();

                PropertyInfo property = type.GetProperty(propertyName);


                Console.WriteLine(property.GetValue(obj));

                //field.SetValue(product, (int)field.GetValue(product) + 1);
            }
        }
    }
}


