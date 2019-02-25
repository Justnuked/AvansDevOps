using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PipeLine.Classes;
using Utilities.Observable;

namespace PipeLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Pipeline p = new Pipeline("test");

            p.AddModule(new BuildCSharp());
            p.AddModule(new TestCSharp());

            NotifierTest test = new NotifierTest("testNot");

            p.Subscribe(test);
            p.Execute();
            Console.ReadKey();
        }
    }
}
