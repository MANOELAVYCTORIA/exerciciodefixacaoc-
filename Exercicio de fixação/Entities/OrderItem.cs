﻿using System;
using System.Collections.Generic;
using System.Text;
using Exercicio_de_fixação.Entities;
using System.Globalization;

namespace Exercicio_de_fixação.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }
        public OrderItem()
        {

        }

        public OrderItem(int quantity, double price, Product product )
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Quantity* Price;
        }

        public override string ToString()
        {
            return Product.Name + ", $" + Price.ToString("F2", CultureInfo.InvariantCulture)
            +", Quantity: " + Quantity + ", SubTotal: $" + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
