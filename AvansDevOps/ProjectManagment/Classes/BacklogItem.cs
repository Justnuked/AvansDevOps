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
        private List<BacklogItem> subItems;
        private IState state;
        private Member developer;
    }
}
