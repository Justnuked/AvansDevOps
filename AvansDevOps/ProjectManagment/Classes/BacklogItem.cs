using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagment.Interfaces;

namespace ProjectManagment.Classes
{
    class BacklogItem
    {
        private HashSet<BacklogItem> subItems;
        private IState state;
        private Member developer;

        public void AddSubItem(BacklogItem item)
        {
            subItems.Add(item);
        }
        public void RemoveSubItem(BacklogItem item)
        {
            subItems.Remove(item);
        }
    }
}
