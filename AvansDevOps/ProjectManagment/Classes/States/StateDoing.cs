using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagment.Interfaces;

namespace ProjectManagment.Classes
{
    class StateDoing : IState
    {
        private BacklogItem b;
        public string type;

        public StateDoing(BacklogItem b)
        {
            type = "doing";
            this.b = b;
        }

        public void Progress()
        {
            b.state = new StateDone(b);
            // Set to done
        }

        public void SetBack()
        {
            b.state = new StateToDo(b);
            // Set to-do
        }

        string IState.GetType()
        {
            return type;
        }
    }
}
