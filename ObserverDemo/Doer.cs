using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDemo
{
    public class Doer
    {
        public event EventHandler<string> AfterDoSomethingWith;
        public event EventHandler<Tuple<string, string>> AfterDoMore;

        private string data = string.Empty;

        public void DoSomethingWith(string data)
        {
            Console.WriteLine("Doing somthing with {0}", data);
            this.data = data;
            OnAfterDoSomethingWith(this.data);
        }

        public void DoMore(string appendData)
        {
            this.data += appendData;
            OnAfterDoMore(this.data, appendData);
        }

        private void OnAfterDoSomethingWith(string data)
        {
            if (this.AfterDoSomethingWith != null)
                this.AfterDoSomethingWith(this,data);
        }

        private void OnAfterDoMore(string completeData, string appendData)
        {
            if (this.AfterDoMore != null)
                this.AfterDoMore(this, Tuple.Create(completeData,appendData));
        }
    }
}
