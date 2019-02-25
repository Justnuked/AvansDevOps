using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagment.Interfaces;

namespace ProjectManagment.Classes
{
    class StateToDo : IState
    {
        private string type;
        private BacklogItem b;

        public StateToDo(BacklogItem b)
        {
            this.type = "todo";
            this.b = b;
        }

        public void Progress()
        {
            // Set to Doing
            b.state = new StateDoing(b);
        }

        public void SetBack()
        {
            // Nothing happens
        }

        string IState.GetType()
        {
            return type;
        }
    }
}
