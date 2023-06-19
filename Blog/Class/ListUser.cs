using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Class
{
    public class ListUser
    {
        private List<User> list;
        private static ListUser instance = new ListUser();

        public List<User> List { get => list; set => list = value; }
        public static ListUser Instance { get => instance; set => instance = value; }
    }
}
