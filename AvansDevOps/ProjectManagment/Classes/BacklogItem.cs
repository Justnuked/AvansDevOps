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
        private string description;
        private HashSet<BacklogItem> subItems;
        private IState state;
        private Member developer;

        public BacklogItem(string description)
        {
            this.description = description;
        }

        public void SetMember(Member dev)
        {
            this.developer = dev;
        }

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
