﻿using System;

namespace ActivatorCreateInstance
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = (Random)Activator.CreateInstance(typeof(Random));
                                                                               // The same result ! 
            Random rand2 = new Random();
        }
    }
}
