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
        public IState state;
        private Member developer;

        public BacklogItem(string description)
        {
            subItems = new HashSet<BacklogItem>();
            this.description = description;
            state = new StateToDo(this);
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

        public void Progress()
        {
            if (subItems.Count > 0)
            {
                CompleteCheck();
            }
            else
            {
                state.Progress();
            }
        }

        // Use this method when there are subitems present.
        public void CompleteCheck()
        {
            bool allDone = true;
            foreach (BacklogItem b in subItems)
            {
                if (!(b.state.GetType().Equals("done")))
                {
                    allDone = false;
                }
            }

            if (allDone)
            {
                state = new StateDone(this);
            }
        }
    }
}
