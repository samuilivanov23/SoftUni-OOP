using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace StorageMaster
{
    public abstract class Vehicle
    {
        public int Capacity { get; set; }
        readonly List<Product> trunk;

        public Vehicle(int capacity)
        {
            Capacity = capacity;
            trunk = new List<Product>();
        }

        public void LoadProduct(Product product)
        {
            if (IsFull())
            {
                throw new InvalidOperationException("Vehicle is full!");
            }

            trunk.Add(product);
        }

        public Product Unload()
        {
            if (!this.IsFull())
            {
                throw new InvalidOperationException("No products left in vehicle!");
            }
            Product temp = trunk.Last();
            trunk.RemoveAt(trunk.Count - 1);
            return temp;
        }

        public  bool IsFull()
        {
            if(trunk.Sum(x => x.Weight) >= Capacity)
            {
                return true;
            }
            return false;
        }

        public bool IsEmpty()
        {
            return trunk.Count == 0;
        }
    }
}
