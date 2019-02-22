using ProjectManagment.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagment
{
    class Comment
    {
        public string content;
        public DateTime creationDate;
        private Member poster;
        private List<Comment> subComments;

        public Comment(string content, Member poster)
        {
            subComments = new List<Comment>();

            this.content = content;
            this.poster = poster;

            creationDate = DateTime.Now;
        }

        public void AddSubComment(Comment comment)
        {
            subComments.Add(comment);
        }
    }
}
