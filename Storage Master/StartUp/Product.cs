using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster
{
    public abstract class Product
    {
        private double price;
        private double weight;

        protected Product(double price, double weight)
        {
            Price = price;
            Weight = weight;
        }

        public double Price
        {
            get => this.price;
            set
            {
                if(value < 0)
                {
                    throw new InvalidOperationException("Price cannot be negative!");
                }
                this.price = value;
            }
        }

        public double Weight
        {
            get => this.weight;
            set => this.weight = value;
        }
    }
}
