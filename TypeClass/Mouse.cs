using System;
using System.Collections.Generic;
using System.Text;
using TypeClass;

namespace ReflectionLab
{
    public class Mouse : Product
    {
        public int Id { get; set; }

        public string Model { get; set; }

        public decimal Price { get; set; }

        public int Precision { get; set; }


    }
}
