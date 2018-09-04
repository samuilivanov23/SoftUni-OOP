﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skeleton
{
    public class FakeWeapon : IWeapon
    {
        public int AttackPoints => 10;

        public int DurabilityPoints => 5;

        public void Attack(ITarget target)
        {
        }
    }
}
