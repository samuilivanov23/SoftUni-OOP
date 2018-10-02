using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster
{
    class HardDrive : Product
    {
        const double weight = 1;
        public HardDrive(double price) 
            : base(price, weight)
        {}
    }
}
