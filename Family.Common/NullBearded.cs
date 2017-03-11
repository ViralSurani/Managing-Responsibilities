using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family.Common
{
    public class NullBearded : IBearded
    {
        private static IBearded _instance;

        private NullBearded()
        {
        }

        public static IBearded Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new NullBearded();
                return _instance;
            }
        }

        public void GrowBeard()
        {            
        }
    }
}
