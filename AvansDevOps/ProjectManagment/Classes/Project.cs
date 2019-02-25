using ProjectManagment.Classes;
using CMS.Interfaces;
using ProjectManagment;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagment.Classes.Factories;

namespace ProjectManagment
{
    class Project
    {
        private int id;
        private string name;
        private DateTime creationDate;
        private Forum forum;
        private ISourceController source;

        private HashSet<Member> members;
        private List<Sprint> sprints;
        private Backlog backLog;
        private SprintFactory factory;

        public Project(string name)
        {
            this.name = name;
            creationDate = DateTime.Now;

            forum = new Forum();
        }

        public void CreateSprint(string type, DateTime start, DateTime end)
        {
            sprints.Add(factory.CreateSprint(type, start, end));
        }

        public void AddMembers(HashSet<Member> members)
        {
            foreach (Member m in members)
            {
                this.members.Add(m);
            }
        }
        public void RemoveMembers(HashSet<Member> members)
        {
            foreach (Member m in members)
            {
                this.members.Remove(m);
            }
        }
        public override string ToString()
        {
            string toReturn = "";

            toReturn += name + ", created on " + creationDate + ". Members: \n";

            foreach (Member m in members)
            {
                toReturn += m.name + "\n";
            }

            return toReturn;
        }
    }
}
