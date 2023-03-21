using System;

namespace EnumBinary
{
    class Program
    {
        static void Main(string[] args)
        {

            Days promotion = Days.Thursday | Days.Saturday | Days.Sunday;  // Gruop many days ! 


            if (promotion.HasFlag(Days.Thursday))
            {
                Console.WriteLine("Thursday Promotion"); // int.Promotion = 8
            }


            if (promotion.HasFlag(Days.Saturday))
            {
                Console.WriteLine("Saturday Promotion"); // int.Promotion = 32
            }
            // Sunday int.Promotion = 64
            Console.WriteLine((int)promotion); // Group int.Promotion = 104
            Console.WriteLine(8 | 32 | 64 );   // The same result - 104


        }

        enum Days
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 4,
            Thursday = 8,
            Friday = 16,
            Saturday = 32,
            Sunday = 64
        }
    
    }
}
