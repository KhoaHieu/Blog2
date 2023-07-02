using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Class
{
    public class Cmt
    {
        private int postId;
        private String userName;
        private string content;
        private string date;

        public Cmt(int postId, string userName, string content,string date)
        {
            this.postId = postId;
            this.userName = userName;
            this.date = date;
            this.content = content;
            
        }
        public Cmt()
        {

        }

        public int PostId { get => postId; set => postId = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Content { get => content; set => content = value; }
        public string Date { get => date; set => date = value; }
    }
}
