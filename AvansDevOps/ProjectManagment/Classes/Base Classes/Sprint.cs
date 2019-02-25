using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagment.Classes;

namespace ProjectManagment
{
    public class Sprint
    {
        protected DateTime start;
        protected DateTime end;

        public bool active;

        private Backlog backlog;
        private ReviewDocument document;

        public Sprint()
        {
            active = false;
            backlog = new Backlog(this);
        }

        public Sprint(DateTime start, DateTime end)
        {
            this.start = start;
            this.end = end;
        }

        public ReviewDocument GetDocument()
        {
            return document;
        }

        public void Start()
        {
            active = true;
        }
    }
}
