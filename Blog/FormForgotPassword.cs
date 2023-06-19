using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blog
{
    public partial class FormForgotPassword : Form
    {
        
        public FormForgotPassword()
        {
            InitializeComponent();
            InitializeComponents();
        }
        private void InitializeComponents()
        {
            int borderRadius = 50; // Điều chỉnh bán kính bo tròn tại đây

            // Tạo hình dạng bo tròn
            GraphicsPath roundedPath = new GraphicsPath();
            roundedPath.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            roundedPath.AddArc(btnSubmit.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            roundedPath.AddArc(btnSubmit.Width - borderRadius, btnSubmit.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            roundedPath.AddArc(0, btnSubmit.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            roundedPath.CloseAllFigures();

            // Áp dụng hình dạng bo tròn vào Button
            btnSubmit.Region = new Region(roundedPath);

            int borderRadius2= 20; // Điều chỉnh bán kính bo tròn tại đây

            // Tạo hình dạng bo tròn
            GraphicsPath roundedPath2= new GraphicsPath();
            roundedPath2.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            roundedPath2.AddArc(btnLogin.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            roundedPath2.AddArc(btnLogin.Width - borderRadius, btnLogin.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            roundedPath2.AddArc(0, btnLogin.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            roundedPath2.CloseAllFigures();

            // Áp dụng hình dạng bo tròn vào Button
            btnLogin.Region = new Region(roundedPath2);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txbEmail.Text == "")
            {
                MessageBox.Show("Please enter email", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool check = false;
            foreach (Class.User user in Class.ListUser.Instance.List)
            {
                if(user.Email ==txbEmail.Text)
                {
                    check = true;
                    user.Password = randomPassword().ToString();
                    Class.SendMail.send(txbEmail.Text, "Reset password", "your new password is: " + user.Password);
                    break;
                }
            }
            if(!check)
            {
                MessageBox.Show("Email not true", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
   
        private int randomPassword()
        {
            Random rd = new Random();
            return rd.Next(1000001, 9999999);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            frm.Show();
            this.Hide();
        }

        private void FormForgotPassword_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}






