using System;

namespace ActivatorCreateInstance
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = (Random)Activator.CreateInstance(typeof(Random));
                                                                               // The same result ! 
            Random rand2 = new Random();

            Console.WriteLine(rand.Next());
            Console.WriteLine(rand2.Next());

            DateTime date = (DateTime)InstanceCreator(typeof(DateTime));
            Console.WriteLine(date.ToString());

            object InstanceCreator(Type type)                         // We can create dynamic any objects of any types.
            {
                return Activator.CreateInstance(type);
            }
        }
    }
}
