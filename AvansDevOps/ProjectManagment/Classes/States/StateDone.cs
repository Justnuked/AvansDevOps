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
        public void Progress()
        {
            // Nothing happens
        }

        public void SetBack()
        {
            // Set back to To-Do, cannot go back to doing
        }
    }
}
