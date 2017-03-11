using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family.Common
{
    public class NullHairy : IHairy
    {
        private static IHairy _instance;

        private NullHairy()
        {
        }

        public static IHairy Instance
        {
            get
            {
                if(_instance==null)
                    _instance = new NullHairy();
                return _instance;
            }
        }

        public void GrowHair()
        {           
        }
    }
}
