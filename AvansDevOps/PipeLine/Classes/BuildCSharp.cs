using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PipeLine.Interfaces.Modules;
using Utilities.Observable;

namespace PipeLine.Classes
{
    public class BuildCSharp : IBuildModule
    {
        private Status status;

        public BuildCSharp()
        {

        }

        public void Execute()
        {
            Console.WriteLine("Building C# code. . .");
            status = Status.SUCCES;
        }


        public Status GetStatus()
        {
            return status;
        }
    }
}
