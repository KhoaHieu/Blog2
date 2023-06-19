using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ganss.Excel;

namespace Blog
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ReadData();
            Application.Run(new FormLogin());
        }

        static void ReadData()
        {        
            Class.ListUser.Instance.List = new ExcelMapper(Application.StartupPath + @"\assets\User.xlsx").Fetch<Class.User>().ToList();
            Class.ListPost.Instance.List = new ExcelMapper(Application.StartupPath + @"\assets\Post.xlsx").Fetch<Class.Post>().ToList();
            Class.ListCmt.Instance.List = new ExcelMapper(Application.StartupPath + @"\assets\Comment.xlsx").Fetch<Class.Cmt>().ToList();

        }
    }
}
