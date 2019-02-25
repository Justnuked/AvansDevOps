using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Observable
{
    public class PipeLineModuleTest : Observable
    {
        public void Test()
        {
            Notify("hey mate I failed", null);
        }
    }
}
