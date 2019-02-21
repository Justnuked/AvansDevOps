using ProjectManagment.Classes;
using ProjectManagment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagment
{
    class Project
    {
        private string name;
        private DateTime creationDate;

        private List<Forum> forums;
        private List<Member> members;
        private List<ISprint> sprints;
        private Backlog backLog;
    }
}
