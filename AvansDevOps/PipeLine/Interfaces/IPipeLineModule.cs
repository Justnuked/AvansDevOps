using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PipeLine.Classes;

namespace PipeLine.Interfaces
{
    public interface IPipeLineModule
    {
        void Execute();
        Status GetStatus();
    }
}
