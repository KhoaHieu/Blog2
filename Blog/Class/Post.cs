using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Class
{
    public class Post
    {
        private int id;
        private string tag;
        private string title;
        private string content;
        private string date;
        private int userId;
        private string userName;
        private string image1;
        private string image2;
        private bool is2Image;

        public Post(int id, string tag, string title, string content, string date, int userId, string userName, 
            string image1, string image2, bool is2Image)
        {
            this.id = id;
            this.tag = tag;
            this.title = title;
            this.content = content;
            this.date = date;
            this.userId = userId;
            this.userName = userName;
            this.image1 = image1;
            this.image2 = image2;
            this.is2Image = is2Image;
        }

        public Post()
        {

        }


        public int Id { get => id; set => id = value; }
        public string Tag { get => tag; set => tag = value; }
        public string Title { get => title; set => title = value; }
        public string Content { get => content; set => content = value; }
        public string Date { get => date; set => date = value; }
        public int UserId { get => userId; set => userId = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Image1 { get => image1; set => image1 = value; }
        public string Image2 { get => image2; set => image2 = value; }
        public bool Is2Image { get => is2Image; set => is2Image = value; }
    }
}
