using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagment.Classes
{
    class Backlog
    {
        private List<BacklogItem> items;

        public Backlog()
        {
            items = new List<BacklogItem>();
        }

        public void AddBacklogItem(BacklogItem item)
        {
            items.Add(item);
        }
    }
}
