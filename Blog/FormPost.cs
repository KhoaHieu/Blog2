using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Drawing.Drawing2D;

namespace Blog
{
    public partial class FormPost : Form
    {
        int index;
        Class.Post post;
        public FormPost()
        {
            InitializeComponent();
            InitializeComponents();
            // Gắn sự kiện Paint cho Form
            this.Paint += FormPost_Paint;
        }
        private void InitializeComponents()
        {
            // Các cài đặt khác cho Form

            // Gắn sự kiện Paint cho Form
            this.Paint += FormPost_Paint;
        }
        private void FormPost_Paint(object sender, PaintEventArgs e)
        {
            // Lấy đối tượng Form hiện tại
            Form form = (Form)sender;

            // Tạo một đối tượng Graphics từ Form
            Graphics graphics = e.Graphics;

            // Vẽ hình dạng bo tròn cho Form
            using (GraphicsPath path = new GraphicsPath())
            {
                int radius = 20; // Điều chỉnh bán kính bo tròn

                // Vẽ đường cong bo tròn cho 4 góc
                path.AddArc(0, 0, radius, radius, 180, 90); // Góc trên bên trái
                path.AddArc(form.Width - radius, 0, radius, radius, 270, 90); // Góc trên bên phải
                path.AddArc(form.Width - radius, form.Height - radius, radius, radius, 0, 90); // Góc dưới bên phải
                path.AddArc(0, form.Height - radius, radius, radius, 90, 90); // Góc dưới bên trái

                // Kết nối đường cong thành một hình dạng đóng
                path.CloseFigure();

                // Đặt kiểu vẽ là Solid với màu viền mong muốn
                Pen pen = new Pen(Color.Black, 2);

                // Vẽ hình dạng bo tròn lên Form
                graphics.DrawPath(pen, path);
            }
        }

        public FormPost(int i)
        {
            index = i;
            InitializeComponent();
            post = Class.ListPost.Instance.List[index];

            lblTitle.Text = post.Title;
            lblUN.Text = post.UserName;
            lblDate.Text = post.Date;
            lblTag.Text = "#" + post.Tag;
            lblContent.Text = post.Content;

            if (post.Is2Image)
            {
                //var request = WebRequest.Create();
                ptbImage21.Visible = true;
                ptbImage22.Visible = true;
                load2Image();
            }
            else
                load1Image();

            //timf kieem username cua post
            string PostUserName = post.UserName;
            string PostUserAva = "";
            //kiem tra trong danh sach user co PostUserName thif lay avatar
            var listUser = Class.ListUser.Instance.List;
            foreach (var item in listUser)
            {
                if (item.UserName == post.UserName)
                {
                    PostUserAva = item.Avt;
                }
            }

            var request2 = WebRequest.Create(PostUserAva);
            using (var response = request2.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                pictureBox1.BackgroundImage = Bitmap.FromStream(stream);
            }





        }
        private void load2Image()
        {
            var request1 = WebRequest.Create(post.Image1);
            using (var response1 = request1.GetResponse())
            using (var stream1 = response1.GetResponseStream())
            {
                ptbImage21.BackgroundImage = Bitmap.FromStream(stream1);
            }

            var request2 = WebRequest.Create(post.Image2);
            using (var response2 = request2.GetResponse())
            using (var stream2 = response2.GetResponseStream())
            {
                ptbImage22.BackgroundImage = Bitmap.FromStream(stream2);
            }
        }

        private void load1Image()
        {
            var request = WebRequest.Create(post.Image1);
            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                ptbImage1.BackgroundImage = Bitmap.FromStream(stream);
            }


        }

        private void panelimage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }
    }
}
