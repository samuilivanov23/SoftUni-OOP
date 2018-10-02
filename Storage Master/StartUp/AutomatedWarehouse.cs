using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster
{
    class AutomatedWarehouse : Storage
    {
        const int capacity = 1;
        const int garageSlots = 2;

        public AutomatedWarehouse(string name) 
            :base(name, capacity, garageSlots, new Vehicle[1] { new Truck()})
        {}
    }
}
