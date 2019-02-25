using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Observable;

namespace Utilities
{
    class Program
    {
        static void Main(string[] args)
        {
            PipeLineModuleTest test = new PipeLineModuleTest();

            NotifierTest notitest = new NotifierTest("Notifier1");
            NotifierTest notitest1 = new NotifierTest("Notifier2");
            NotifierTest notitest2 = new NotifierTest("Notifier3");
            NotifierTest notitest3 = new NotifierTest("Notifier4");

            test.Subscribe(notitest);
            test.Subscribe(notitest1);
            test.Subscribe(notitest2);
            test.Subscribe(notitest3);

            test.Test();

            Console.ReadKey();
        }
    }
}
