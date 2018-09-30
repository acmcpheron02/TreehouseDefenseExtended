using System;
using System.Collections.Generic;
using System.Text;

namespace TreehouseDefense
{
    class ShieldedInvader : Invader
    {
        private static readonly System.Random _random = new System.Random();

        public ShieldedInvader(Path path) : base(path)
        {

        }

        public override void DecreaseHealth(int factor)
        {
            if(_random.NextDouble() < .5)
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
