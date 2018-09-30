using System;
using System.Collections.Generic;
using System.Text;

namespace TreehouseDefense
{
    class SniperTower : Tower
    {
        protected override double Accuracy { get; } = 1;

        public SniperTower (MapLocation location) : base(location)
        {

        }
    }
}
