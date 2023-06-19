using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Class
{
    public class ListCmt
    {
        private List<Cmt> list;
        private static ListCmt instance = new ListCmt();

        public List<Cmt> List { get => list; set => list = value; }
        public static ListCmt Instance { get => instance; set => instance = value; }
    }
}
