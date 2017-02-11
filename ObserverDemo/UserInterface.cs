using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDemo
{
    public class UserInterface
    {
        public void AfterDoSomthingWith(object sender, string data)
        {
            Console.WriteLine("Hey User, look at this {0}.", data.ToUpper());
        }
    }
}
