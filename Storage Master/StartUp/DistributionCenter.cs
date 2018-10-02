using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster
{
    class DistributionCenter : Storage
    {
        const int capacity = 2;
        const int garageSlots = 5;

        public DistributionCenter(string name)
            : base(name, capacity, garageSlots, new Vehicle[3] { new Van(), new Van(), new Van })
        {}
    }
}
