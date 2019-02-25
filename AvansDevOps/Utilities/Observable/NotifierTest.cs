using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Observable
{
    public class NotifierTest : Observer
    {
        public string name;

        public NotifierTest(string name)
        {
            this.name = name;
        }

        public void Update(string message)
        {
            Console.WriteLine(message);
        }
    }
}
