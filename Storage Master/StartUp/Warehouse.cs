using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster
{
    class Warehouse : Storage
    {
        const int capacity = 10;
        const int garageSlots = 10;

        public Warehouse(string name) 
            : base(name, capacity, garageSlots, new Vehicle[3] { new Semi(), new Semi(), new Semi()})
        {}
    }
}
