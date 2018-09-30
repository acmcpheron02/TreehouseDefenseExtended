﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TreehouseDefense
{
    class PowerTower : Tower
    {
        protected override int Power { get; } = 2;

        public PowerTower (MapLocation location) : base(location)
        {
    
        }
    }
}
