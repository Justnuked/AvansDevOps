using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagment.Classes;

namespace ProjectManagment
{
    class Thread
    {
        private string title;
        private string content;
        private DateTime creationDate;
        private List<Comment> comments;
        //Keep threads based around relevant items/subjects
        private BacklogItem item;

        public Thread(string title, string content, BacklogItem item)
        {
            this.title = title;
            this.content = content;
            creationDate = DateTime.Now;
            this.item = item;
        }

        public void AddComment(Comment comment)
        {
            comments.Add(comment);
        }


    }
}
