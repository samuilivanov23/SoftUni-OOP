using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster
{
    class Van : Vehicle
    {
        const int capacity = 2;

        public Van() 
            :base(capacity)
        {
        }
    }
}
