using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster
{
    class SolidStateDrive : Product
    {
        const double weight = 0.2;
        public SolidStateDrive(double price) 
            : base(price, weight)
        {}
    }
}
