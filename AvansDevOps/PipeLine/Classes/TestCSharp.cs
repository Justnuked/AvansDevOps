using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PipeLine.Interfaces.Modules;

namespace PipeLine.Classes
{
    public class TestCSharp : ITestModule
    {
        private Status status;

        public void Execute()
        {
            Console.WriteLine("Testing C# Code. . . ");
            status = Status.FAILED;
        }

        public Status GetStatus()
        {
            return status;
        }
    }
}
