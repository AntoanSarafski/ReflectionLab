using System;

namespace TypeClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(Console);

            Console.WriteLine(type.FullName);
            Console.WriteLine(type.Name);
            Console.WriteLine(type.Assembly);
            Console.WriteLine(type.IsArray);
            Console.WriteLine(type.IsAbstract);
            Console.WriteLine(type.IsClass);
            Console.WriteLine(type.IsInterface);
            Console.WriteLine(type.IsPublic);
        }
    }
}
