using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Family.Common;

namespace ConsoleFamily
{
    class Family
    {
        private readonly IEnumerable<FamilyMemeber> _memebers;

        public Family(IEnumerable<FamilyMemeber> members)
        {
            this._memebers = new List<FamilyMemeber>(members);
        }

        public void WinterBegins()
        {
            Console.WriteLine("Winter just came...");
            foreach (FamilyMemeber member in _memebers)
            {
                member.As<IHairy>(NullHairy.Instance).GrowHair();
                member.As<IBearded>(NullBearded.Instance).GrowBeard();
            }
            Console.WriteLine(new string('-', 20));
        }

        public void SummerComes()
        {
            Console.WriteLine("Summer is here...");
            foreach (FamilyMemeber memeber in _memebers)
            {
                memeber.As<IEmotional>(NullEmotional.Instance).BeHappy();
            }
            Console.WriteLine(new string('-', 20));
        }
    }
}
