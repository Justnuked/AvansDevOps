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
        public void Progress()
        {
            // Set to Doing
        }

        public void SetBack()
        {
            // Nothing happens
        }
    }
}
