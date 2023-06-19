using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Class
{
    public class User
    {
        private int id;
        private string userName;
        private string password;
        private string email;
        private int age;
        private string avt;

        public User()
        {
        }
        public User(int id, string userName, string password, string email, int age, string avt)
        {
            this.id = id;
            this.userName = userName;
            this.password = password;
            this.email = email;
            this.age = age;
            this.avt = avt;
        }

        public int Id { get => id; set => id = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public int Age { get => age; set => age = value; }
        public string Avt { get => avt; set => avt = value; }
    }
}
