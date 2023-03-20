using System;

namespace EnumBinary
{
    class Program
    {
        static void Main(string[] args)
        {

            Days promotion = Days.Monday | Days.Tuesday;  // Gruop two days ! 


            if (promotion.HasFlag(Days.Monday))
            {
                Console.WriteLine("Monday Promotion");
            }


            if (promotion.HasFlag(Days.Tuesday))
            {
                Console.WriteLine("Tuesday Promotion");
            }


        }

        enum Days
        {
            Monday = 0,
            Tuesday = 2,
            Wednesday = 4,
            Thursday = 8,
            Friday = 16,
            Saturday = 32,
            Sunday = 64
        }
    
    }
}
