using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagment.Classes;

namespace ProjectManagment
{
    class Forum
    {
        private List<Thread> threads;
        public Forum()
        {

        }

        public void CreateThread(string name, string content, BacklogItem item)
        {
            Thread t = new Thread(name, content, item);
            threads.Add(t);
        }
    }
}
