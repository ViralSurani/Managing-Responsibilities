using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Family.Common;

namespace ConsoleFamily
{
    class Emotional : ChainElement, IEmotional
    {
        private readonly string _owner;
        private readonly string _laughingSound;

        public Emotional(string owner, string laughingSound, IChainElement next)
            : base(next)
        {
            this._owner = owner;
            this._laughingSound = laughingSound;
        }

        public Emotional(string owner, string laughingSound)            
        {
            this._owner = owner;
            this._laughingSound = laughingSound;
        }

        public void BeHappy()
        {
            Console.WriteLine("{0}: {1}", this._owner, this._laughingSound);
        }
    }
}
