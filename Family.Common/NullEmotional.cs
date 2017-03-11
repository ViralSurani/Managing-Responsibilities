using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family.Common
{
    public class NullEmotional : IEmotional
    {
        private static IEmotional _instance;

        private NullEmotional()
        {
        }

        public static IEmotional Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new NullEmotional();
                return _instance;
            }
        }

        public void BeHappy()
        {
        }
    }
}
