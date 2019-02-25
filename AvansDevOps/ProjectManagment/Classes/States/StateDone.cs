using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagment.Interfaces;

namespace ProjectManagment.Classes
{
    class StateDone : IState
    {
        private BacklogItem b;
        public string type;

        public StateDone(BacklogItem b)
        {
            type = "done";
            this.b = b;
        }

        public void Progress()
        {
            // Nothing happens
        }

        public void SetBack()
        {
            // Set back to To-Do, cannot go back to doing
            // Send notification    

            b.state = new StateToDo(b);
        }

        string IState.GetType()
        {
            return type;
        }
    }
}
