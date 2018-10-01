using System;
using System.Collections.Generic;
using System.Text;

namespace TreehouseDefense
{
    class ShieldedInvader : Invader
    {
        public override int Health { get; protected set; } = 2;

        public ShieldedInvader(Path path) : base(path)
        {

        }

        public override void DecreaseHealth(int factor)
        {
            if(Random.NextDouble() < .5)
            {
                base.DecreaseHealth(factor);
            }
            else
            {
                System.Console.WriteLine("The shielded invader absorbed the blast!");
            }
        }
    }
}
