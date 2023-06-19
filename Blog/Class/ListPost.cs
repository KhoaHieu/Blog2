using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Class
{
    public class ListPost
    {
        private List<Post> list;
        private static ListPost instance = new ListPost();

        public List<Post> List { get => list; set => list = value; }
        public static ListPost Instance { get => instance; set => instance = value; }
    }
}
