using ReflectionLab;
using System;
using TypeClass.ReflectionNamespace;

namespace TypeClass
{
    class Program
    {
        static void Main(string[] args)
        {


            //PrintTypeInfo(new Mouse());
            //PrintTypeInfo(new Laptop());

            Type type = (Type.GetType(Console.ReadLine()));
            PrintTypeInfo(type);
            void PrintTypeInfo(Type type)

            {
                //Type type = product.GetType();

                Console.WriteLine($"FullName:{type.FullName}");
                Console.WriteLine($"Name:{type.Name}");
                Console.WriteLine($"Assembly:{type.Assembly}");
                Console.WriteLine($"IsArray:{type.IsArray}");
                Console.WriteLine($"IsAbstract:{type.IsAbstract}");
                Console.WriteLine($"IsClass:{type.IsClass}");
                Console.WriteLine($"IsInterface:{type.IsInterface}");
                Console.WriteLine($"IsPublic:{type.IsPublic}");
            }

        }
    }
    namespace ReflectionNamespace
    {

        public class Reflected
        {

        }
    }

}
