using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family.Common
{
    public interface IChainElement
    {
        T As<T>(T defaultValue) where T : class;
    }
}
