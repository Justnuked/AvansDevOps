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

        private ReviewDocument document;

        public Sprint()
        {
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
    }
}
