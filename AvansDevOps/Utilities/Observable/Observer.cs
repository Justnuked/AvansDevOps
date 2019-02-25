using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Observable
{
    public interface Observer
    {
        void Update(string message);
    }
}
