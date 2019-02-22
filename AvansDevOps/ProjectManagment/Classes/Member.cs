using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagment.Interfaces;

namespace ProjectManagment.Classes
{
    class Member
    {
        // In this context meaning communication platforms
        public List<IPlatform> platforms;
        public string name;
        public int id;
        private enum Role
        {
            Developer,
            ProjectManager
        }
        private HashSet<Role> roles;
        public Member(string name)
        {
            this.name = name;
        }
        public void AddRole(string role)
        {
            switch (role)
            {
                case "developer":
                    roles.Add(Role.Developer);
                    break;

                case "projectmanager":
                    roles.Add(Role.ProjectManager);
                    break;

                default:
                    // Error logic
                    break;
            }
        }
    }
}
