using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Family.Common;

namespace ConsoleFamily
{
    public class FamilyMemeber
    {
        private readonly ChainElement _components;

        public FamilyMemeber(ChainElement components)
        {
            this._components = components;
        }

        public T As<T>(T defaultValue) where T : class
        {
            return this._components.As<T>(defaultValue);
        }
    }
}
