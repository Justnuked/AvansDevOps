using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagment.Classes;

namespace ProjectManagment.Interfaces
{
    interface IState
    {
        void Progress();
        void SetBack();
    }
}
