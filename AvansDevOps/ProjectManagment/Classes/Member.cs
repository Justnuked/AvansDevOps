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

        private Role role;

        public Member(string name, string role)
        {
            this.name = name;

            switch (role)
            {
                case "developer":
                    this.role = Role.Developer;
                    break;

                case "projectmanager":
                    this.role = Role.ProjectManager;
                    break;

                default:
                    // Error logic
                    break;
            }
        }
    }
}
