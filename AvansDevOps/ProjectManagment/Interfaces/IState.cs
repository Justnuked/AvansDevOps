using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagment.Classes;

namespace ProjectManagment.Interfaces
{
    public interface IState
    {
        void Progress();
        void SetBack();

        string GetType();
    }
}
