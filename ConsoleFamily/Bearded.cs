using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Family.Common;

namespace ConsoleFamily
{
    class Bearded : ChainElement, IBearded
    {
        private readonly string _owner;

        public Bearded(string owner, IChainElement next)
            : base(next)
        {
            this._owner = owner;
        }

        public Bearded(string owner)
        {
            this._owner = owner;
        }

        public void GrowBeard()
        {
            Console.WriteLine("{0}: beard grows", this._owner);
        }
    }
}
