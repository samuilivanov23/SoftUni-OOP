using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster
{
    class RAM : Product
    {
        const double weight = 0.1;
        public RAM(double price) 
            : base(price, weight)
        {}
    }
}
