using System;
using System.Collections.Generic;
using System.Text;

namespace TreehouseDefense
{
    class LobbingTower : Tower
    {
        protected override int Range { get; } = 2;
        protected override int Power { get; } = 2;
        protected override double Accuracy { get; } = .50;

        public LobbingTower (MapLocation location) : base(location)
        {

        }
    }
}
