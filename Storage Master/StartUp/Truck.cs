using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster
{
    class Truck : Vehicle
    {
        const int capacity = 5;

        public Truck()
            : base(capacity)
        {
        }
    }
}
