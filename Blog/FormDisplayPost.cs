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

using Ganss.Excel;

namespace Blog
{
    public partial class FormDisplayPost : Form
    {
        private List<int> order = new List<int>();
        private int size = Class.ListPost.Instance.List.Count;
        private int index = -1;
        private bool isPlayPanel = false;
        private int idxCmt = Class.ListCmt.Instance.List.Count - 1;
        public FormDisplayPost()
        {
            InitializeComponent();
            makeOrder();
            loadNext();
            label3.Text = Class.CurrUser.ins.UserName;

            var request = WebRequest.Create(Class.CurrUser.ins.Avt);
            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                pictureBox1.BackgroundImage = Bitmap.FromStream(stream);
            }

            var request2 = WebRequest.Create(Class.CurrUser.ins.Avt);
            using (var response = request2.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                ptbAvt.BackgroundImage = Bitmap.FromStream(stream);
            }



            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, ptbAvt.Width - 1, ptbAvt.Height - 3);
            Region rg = new Region(gp);
            ptbAvt.Region = rg;

        
        }

        private void makeOrder()
        {
            List<bool> isShow = new List<bool>();
            foreach (Class.Post p in Class.ListPost.Instance.List)
                isShow.Add(false);

            int num = -1;
            int count = 0;
            Random rd = new Random();

            while (count < size)
            {
                num = rd.Next(0, size);
                if (num >= 0 && num < size && isShow[num] == false)
                {
                    isShow[num] = true;
                    order.Add(num);
                    count++;
                }
            }
        }

        private void loadNext()
        {
            index++;
            if (index == size)
                index = 0;

            pnlPost.Controls.Clear();
            FormPost frm = new FormPost(order[index]);
            frm.Dock = DockStyle.Fill;
            frm.TopMost = true;
            frm.TopLevel = false;
            pnlPost.Controls.Add(frm);

            loadCmt(order[index]);

            frm.Show();
        }

        private void loadPrev()
        {
            index--;
            if (index == -1)
                index = size - 1;

            pnlPost.Controls.Clear();
            FormPost frm = new FormPost(order[index]);
            frm.Dock = DockStyle.Fill;
            frm.TopMost = true;
            frm.TopLevel = false;
            pnlPost.Controls.Add(frm);
            frm.Show();
            loadCmt(order[index]);
        }

        private void loadCmt(int idx)
        {
            List<Class.Cmt> listCmt = new List<Class.Cmt>();
            Console.WriteLine("post index: " + idx);
            bool check = false;
            while (listCmt.Count < 4 && idxCmt >= 0)
            {
                Console.WriteLine("cmt index: " + Class.ListCmt.Instance.List[idxCmt].PostId);

                if (Class.ListCmt.Instance.List[idxCmt].PostId == idx)
                {
                    listCmt.Add(Class.ListCmt.Instance.List[idxCmt]);
                    check = true;
                }
                idxCmt--;
            }
            if (!check)
            {
                lblUN1.Text = "";
                lblUN2.Text = "";
                lblUN3.Text = "";
                lblUN4.Text = "";
                lblContent1.Text = "";
                lblContent2.Text = "";
                lblContent3.Text = "";
                lblContent4.Text = "";
                pb001.BackgroundImage = null;
                pb002.BackgroundImage = null;
                pb003.BackgroundImage = null;
                pb004.BackgroundImage = null;

                idxCmt = Class.ListCmt.Instance.List.Count - 1;

                return;
            };
            pnl1.Controls.Clear();
            pnl2.Controls.Clear();
            pnl3.Controls.Clear();
            pnl4.Controls.Clear();
            pnlCmt.Controls.Clear();

            pnl1.Controls.Add(lblUN1);
            pnl1.Controls.Add(lblContent1);
            pnl1.Controls.Add(pb001);


            pnl2.Controls.Add(lblUN2);
            pnl2.Controls.Add(lblContent2);
            pnl2.Controls.Add(pb002);

            pnl3.Controls.Add(lblUN3);
            pnl3.Controls.Add(lblContent3);
            pnl3.Controls.Add(pb003);

            pnl4.Controls.Add(lblUN4);
            pnl4.Controls.Add(lblContent4);
            pnl4.Controls.Add(pb004);

            pnlCmt.Controls.Add(pnl1);
            pnlCmt.Controls.Add(pnl2);
            pnlCmt.Controls.Add(pnl3);
            pnlCmt.Controls.Add(pnl4);
            Console.WriteLine(listCmt.Count);

            for (int j = 0; j < listCmt.Count; j++)
            {
                string name = listCmt[j].UserName;
                string avt = "";
                //tìm kiếm trong list user xem có user nào trùng tên với name không
                foreach (Class.User u in Class.ListUser.Instance.List)
                {
                    if (u.UserName == name)
                    {
                        avt = u.Avt;
                        break;
                    }
                }


                var request = WebRequest.Create(avt);
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    pnlCmt.Controls[j].Controls[2].BackgroundImage = Bitmap.FromStream(stream);
                }
                pnlCmt.Controls[j].Controls[2].BackgroundImageLayout = ImageLayout.Stretch;
                pnlCmt.Controls[j].Controls[0].Text = listCmt[j].UserName;


                pnlCmt.Controls[j].Controls[1].Text = listCmt[j].Content;
                Console.WriteLine("size: ", listCmt[j].Content);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadNext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadPrev();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Class.CurrUser.logout();
            FormLogin frm = new FormLogin();
            frm.Show();
            this.Close();
        }

        private void ptbAvt_Click(object sender, EventArgs e)
        {
            isPlayPanel = !isPlayPanel;
            if (isPlayPanel)
                panel1.Visible = true;
            else
                panel1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormCreatePost frmc = new FormCreatePost();
            frmc.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            loadCmt(order[index]);
        }

        private void ptbSend_Click(object sender, EventArgs e)
        {
            Class.Cmt cmt = new Class.Cmt(order[index], Class.CurrUser.ins.UserName, txbCmt.Text);
            Class.ListCmt.Instance.List.Add(cmt);

            idxCmt = Class.ListCmt.Instance.List.Count - 1;
            loadCmt(order[index]);
            WriteData();
        }

        void WriteData()
        {
            var execl1 = new ExcelMapper();
            execl1.Save(Application.StartupPath + @"\assets\Comment.xlsx", Class.ListCmt.Instance.List);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAcount frm = new FormAcount();
            this.Hide();
            frm.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // Lấy đối tượng PictureBox hiện tại
            PictureBox pictureBox = (PictureBox)sender;

            // Tạo một đối tượng Graphics từ PictureBox
            Graphics graphics = e.Graphics;

            // Xóa nền hiện tại của PictureBox
            graphics.Clear(Color.Transparent);

            // Vẽ hình tròn trong PictureBox
            int diameter = Math.Min(pictureBox.Width, pictureBox.Height);
            graphics.FillEllipse(Brushes.Red, 0, 0, diameter, diameter);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pnl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormMessenger frm = new FormMessenger();
            this.Hide();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormDisplayPost fr = new FormDisplayPost();
            this.Hide();
            fr.Show();
        }

        private void FormDisplayPost_Load(object sender, EventArgs e)
        {

        }

        private void lblContent2_Click(object sender, EventArgs e)
        {

        }

        private void pnlCmt_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            FormDisplayPost frm = new FormDisplayPost();
            this.Hide();
            frm.Show();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            FormMessenger frm1 = new FormMessenger();
            this.Hide();
            frm1.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblUN3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
