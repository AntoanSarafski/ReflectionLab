using System;
using System.Collections.Generic;
using System.Text;

namespace ActivatorCreateInstance
{
    public class Product
    {

        public Product(int id, decimal price, string model)
        {
            Id = id;
            Price = price;
            Model = model;
        }

        public Product()
        {

        }
        public int Id { get; set; }
        public decimal Price { get; set; }

        public string Model { get; set; }

    }
}
