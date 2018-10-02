using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster
{
    class GPU : Product
    {
        const double weight = 0.7;
        public GPU(double price)
            : base(price, weight)
        {}
    }
}
