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

using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Ganss.Excel;

namespace Blog
{
    public partial class FormAcount : Form
    {
        public static Class.User myAccount { get; set; } = new Class.User();
        //variables
        public static Cloudinary cl;

        OpenFileDialog o;

        //end
        private Image backgroundImage;
        private float opacity = 0.5f;
        public FormAcount()
        {
            InitializeComponent();
            config();
            myAccount = Class.CurrUser.ins;
        }

        private void FormAcount_Load(object sender, EventArgs e)
        {
            if (myAccount == null)
            {
                MessageBox.Show("Some thing wrong while fetching User Information");
                return;
            }
            else
            {
                txbUN.Text = myAccount.UserName;
                txbUN.Enabled = false;

                txbPW.Text = myAccount.Password;

                txbEmail.Text = myAccount.Email;
                cboAge.Text = myAccount.Age.ToString();

                var request2 = WebRequest.Create(myAccount.Avt);
                using (var response = request2.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    pictureBox1.BackgroundImage = Bitmap.FromStream(stream);
                }


            }
        }

        private void txbCPW_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txbUN.Text == "")
            {
                MessageBox.Show("Please enter user name", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txbPW.Text == "")
            {
                MessageBox.Show("Please enter password", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txbEmail.Text == "")
            {
                MessageBox.Show("Please enter email", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cboAge.Text == "")
            {
                MessageBox.Show("Please enter age", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (o.FileName == "")
            {
                MessageBox.Show("Please choose avater", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string publicId = uploadImage(o.FileName);

            Class.User user = new Class.User(myAccount.Id, txbUN.Text, txbPW.Text, txbEmail.Text, Int32.Parse(cboAge.Text), publicId);
            Class.ListUser.Instance.List.Add(user);
            UpdateData();
            MessageBox.Show("Update success");

        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            o = new OpenFileDialog();
            if (o.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackgroundImage = Image.FromFile(o.FileName);
            }
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
        void UpdateData()
        {
            var execl1 = new ExcelMapper();

            execl1.Save(Application.StartupPath + @"\assets\User.xlsx", Class.ListUser.Instance.List);
        }
        private static void config()
        {
            Account account = new Account(Class.CDConfig.CLOUD_NAME, Class.CDConfig.API_KEY, Class.CDConfig.API_SECRET);
            cl = new Cloudinary(account);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDisplayPost formDisplayPost = new FormDisplayPost();
            this.Hide();
            formDisplayPost.Show();
        }
    }
}
