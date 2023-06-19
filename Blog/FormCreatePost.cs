using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CloudinaryDotNet;
using CloudinaryDotNet.Actions;

using Ganss.Excel;


namespace Blog
{
    public partial class FormCreatePost : Form
    {
        public static Cloudinary cl;

        OpenFileDialog o1;
        OpenFileDialog o2;


        public FormCreatePost()
        {
            InitializeComponent();
            config();

            cboTag.Items.Add("Food");
            cboTag.Items.Add("Clothes");
            cboTag.Items.Add("News");
            cboTag.Items.Add("politics");
            cboTag.Items.Add("Science");
            cboTag.Items.Add("Sport");
        }

       

        private static void config()
        {
            Account account = new Account(Class.CDConfig.CLOUD_NAME, Class.CDConfig.API_KEY, Class.CDConfig.API_SECRET);
            cl = new Cloudinary(account);
        }

        public static string uploadImage(string imgpath)
        {
            try
            {
                var uploadParams = new ImageUploadParams()
                {
                    File = new FileDescription(imgpath)
                };

                var uploadResult = cl.Upload(uploadParams);
                MessageBox.Show("oke babe");
                return uploadResult.SecureUrl.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            o1 = new OpenFileDialog();
            if (o1.ShowDialog() == DialogResult.OK)
            {
                ptb1.BackgroundImage = Image.FromFile(o1.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            o2 = new OpenFileDialog();
            if (o2.ShowDialog() == DialogResult.OK)
            {
                ptb1.BackgroundImage = Image.FromFile(o2.FileName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txbTitle.Text == "")
            {
                MessageBox.Show("Please enter title", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txbContent.Text == "")
            {
                MessageBox.Show("Please enter content", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cboTag.SelectedItem == "")
            {
                MessageBox.Show("Please choose tag", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (o1 == null)
            {
                MessageBox.Show("Please choose image", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string publicId1 = uploadImage(o1.FileName);
            string publicId2 = "";

            if (chb1.Checked)
                publicId2 = uploadImage(o2.FileName);

            String date = DateTime.Now.ToString();

            Class.Post post = new Class.Post(Class.ListPost.Instance.List.Count, cboTag.Text,
                txbTitle.Text, txbContent.Text, date, Class.CurrUser.ins.Id, Class.CurrUser.ins.UserName, publicId1, publicId2, chb1.Checked);
           
            Class.ListPost.Instance.List.Add(post);
            MessageBox.Show("Create post success");

            WriteData();

            FormDisplayPost frm = new FormDisplayPost();
            frm.Show();
            this.Hide();
        }


        private void chb1_CheckedChanged(object sender, EventArgs e)
        {
            if (chb1.Checked)
                panel1.Visible = true;
            else
                panel1.Visible = false;
        }

        void WriteData()
        {
            var execl1 = new ExcelMapper();
            execl1.Save(Application.StartupPath + @"\assets\Post.xlsx", Class.ListPost.Instance.List);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormDisplayPost frm = new FormDisplayPost();
            this.Hide();
            frm.Show();
        }
    }
}
