using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family.Common
{
    public class ChainElement : IChainElement
    {
        private readonly IChainElement _next;

        public ChainElement(IChainElement next)
        {
            this._next = next;
        }

        protected ChainElement() : this(NullChainElement.Instance)
        {
        }

        public virtual T As<T>(T defaultValue) where T : class
        {
            if (this is T)
                return this as T;
            return this._next.As<T>(defaultValue);
        }
    }
}
