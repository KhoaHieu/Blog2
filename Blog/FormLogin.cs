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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace Blog
{
    public partial class FormLogin : Form
    {
        private Image backgroundImage;
        private float opacity = 0.5f;
        public FormLogin()
        {
            InitializeComponent();
            InitializeComponents();
        }
        private void InitializeComponents()
        {
            // Đặt hình nền cho form
            string mypath = @"D:\Backup\Năm 3\C#\Blog\Blog\Resources\background11.png";
            //backgroundImage = Image.FromFile("D:\\Backup\\Năm 3\\C#\\Blog\\Blog\\Resources\\background11.png");
            backgroundImage = Image.FromFile(mypath);
            this.BackgroundImageLayout = ImageLayout.Stretch;
            txbUN.BorderStyle = BorderStyle.FixedSingle;

            // Tạo hình dạng bo tròn
            int cornerRadius = 10;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, cornerRadius * 2, cornerRadius * 2, 180, 90);
            path.AddArc(txbUN.Width - cornerRadius * 2, 0, cornerRadius * 2, cornerRadius * 2, 270, 90);
            path.AddArc(txbUN.Width - cornerRadius * 2, txbUN.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
            path.AddArc(0, txbUN.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
            path.CloseFigure();

            // Tạo Region từ hình dạng bo tròn
            txbUN.Region = new Region(path);
            // Đặt kiểu viền là FixedSingle cho txbUN
            txbUN.BorderStyle = BorderStyle.FixedSingle;

            // Đặt kiểu viền là FixedSingle cho txbPW
            txbPW.BorderStyle = BorderStyle.FixedSingle;

            // Tạo hình dạng bo tròn cho txbUN
            int cornerRadius2 = 10;
            GraphicsPath pathUN = new GraphicsPath();
            pathUN.AddArc(0, 0, cornerRadius * 2, cornerRadius * 2, 180, 90);
            pathUN.AddArc(txbUN.Width - cornerRadius * 2, 0, cornerRadius * 2, cornerRadius * 2, 270, 90);
            pathUN.AddArc(txbUN.Width - cornerRadius * 2, txbUN.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
            pathUN.AddArc(0, txbUN.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
            pathUN.CloseFigure();

            // Tạo Region từ hình dạng bo tròn cho txbUN
            txbUN.Region = new Region(pathUN);

            // Tạo hình dạng bo tròn cho txbPW
            GraphicsPath pathPW = new GraphicsPath();
            pathPW.AddArc(0, 0, cornerRadius * 2, cornerRadius * 2, 180, 90);
            pathPW.AddArc(txbPW.Width - cornerRadius * 2, 0, cornerRadius * 2, cornerRadius * 2, 270, 90);
            pathPW.AddArc(txbPW.Width - cornerRadius * 2, txbPW.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
            pathPW.AddArc(0, txbPW.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
            pathPW.CloseFigure();

            // Tạo Region từ hình dạng bo tròn cho txbPW
            txbPW.Region = new Region(pathPW);
            // Đặt kiểu viền là FixedSingle
            panellogin.BorderStyle = BorderStyle.FixedSingle;

            // Đặt màu nền mờ
            Color originalColor = panellogin.BackColor;
            int alpha = 150; // Độ mờ, giá trị từ 0 đến 255
            Color muffledColor = Color.FromArgb(alpha, originalColor.R, originalColor.G, originalColor.B);
            panellogin.BackColor = muffledColor;
            int borderRadius = 50; // Điều chỉnh bán kính bo tròn tại đây

          
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Vẽ hình nền
            e.Graphics.DrawImage(backgroundImage, ClientRectangle);

            // Vẽ lớp mờ
            using (SolidBrush brush = new SolidBrush(Color.FromArgb((int)(opacity * 255), Color.Black)))
            {
                e.Graphics.FillRectangle(brush, ClientRectangle);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string un = txbUN.Text;
            string pw = txbPW.Text;

            bool check = false;
            foreach (Class.User user in Class.ListUser.Instance.List)
            {
                if (user.UserName == un)
                {
                    if (user.Password == pw)
                    {
                        Class.CurrUser.ins = user; //user hien tai
                        Class.CurrUser.isLogin = true;
                        check = true;
                        break;
                    }
                }
            }
            if (!check)
            {
                MessageBox.Show("Wrong user name or password", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // MessageBox.Show("ok", "ok");
            FormDisplayPost frm = new FormDisplayPost();
            this.Hide();
            frm.Show();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegister reg = new FormRegister();
            reg.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            FormForgotPassword frm = new FormForgotPassword();
            frm.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txbUN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSubmit_Click(sender, e);
            }
        }
    }
}
