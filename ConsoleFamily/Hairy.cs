using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Family.Common;

namespace ConsoleFamily
{
    class Hairy : ChainElement, IHairy
    {
        private readonly string _owner;

        public Hairy(string owner, IChainElement next)
            : base(next)
        {
            this._owner = owner;
        }

        public Hairy(string owner)
        {
            this._owner = owner;
        }

        public void GrowHair()
        {
            Console.WriteLine("{0}: hair gets long", this._owner);
        }
    }
}
