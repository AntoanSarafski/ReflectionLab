﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionLab
{
    public class Laptop
    {

        public int Id { get; set; }

        public int Cores { get; set; }

        public decimal Price { get; set; }

        public string CPUModel { get; set; }

        public void Start()
        {
            Console.WriteLine("Laptop is starting...");
        }

    }
}
