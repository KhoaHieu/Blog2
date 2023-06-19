using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Class
{
    public class CurrUser
    {
        public static User ins;
        public static bool isLogin = false;
        public static void logout()
        {
            ins = null;
            isLogin = false;
        }
    }
}
