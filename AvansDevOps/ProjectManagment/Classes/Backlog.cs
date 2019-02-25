using System;
using System.Collections.Generic;
using ProjectManagment.Interfaces;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagment.Classes
{
    public class Backlog
    {
        private List<BacklogItem> items;
        private Sprint s;

        public Backlog(Sprint s)
        {
            items = new List<BacklogItem>();
            this.s = s;
        }

        public void AddBacklogItem(BacklogItem item)
        {
            if (!s.active)
            {
                items.Add(item);
            }
        }

        public void RemoveBacklogItem(BacklogItem item)
        {
            if (!s.active)
            {
                items.Remove(item);
            }
        }
    }
}
