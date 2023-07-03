using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blog
{
    public partial class FormEmoji : Form
    {


        public event EventHandler<string> EmojiSelected;

        public TextBox CommentTextBox { get; set; }

        public FormEmoji()
        {
            // Định nghĩa các button đại diện cho emoji
            Button emojiButton1 = new Button();
            emojiButton1.Location = new System.Drawing.Point(12, 12);
            emojiButton1.Size = new System.Drawing.Size(50, 50);
            emojiButton1.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emojiButton1.Text = "😄";
            emojiButton1.Click += EmojiButton_Click;

            Button emojiButton2 = new Button();
            emojiButton2.Location = new System.Drawing.Point(62, 12);
            emojiButton2.Size = new System.Drawing.Size(50, 50);
            emojiButton2.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emojiButton2.Text = "❤️";
            emojiButton2.Click += EmojiButton_Click;

            Button emojiButton3 = new Button();
            emojiButton3.Location = new System.Drawing.Point(112, 12);
            emojiButton3.Size = new System.Drawing.Size(50, 50);
            emojiButton3.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emojiButton3.Text = "🥰";
            emojiButton3.Click += EmojiButton_Click;

            Button emojiButton4 = new Button();
            emojiButton4.Location = new System.Drawing.Point(162, 12);
            emojiButton4.Size = new System.Drawing.Size(50, 50);
            emojiButton4.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emojiButton4.Text = "🤣";
            emojiButton4.Click += EmojiButton_Click;

            // Thêm các button vào form chứa emoji
            this.Controls.Add(emojiButton1);
            this.Controls.Add(emojiButton2);
            this.Controls.Add(emojiButton3);
            this.Controls.Add(emojiButton4);
        }

        private void EmojiButton_Click(object sender, EventArgs e)
        {
            Button emojiButton = (Button)sender;
            string emoji = emojiButton.Text;

            CommentTextBox.Text += emoji;
        }


        private void EmojiForm_EmojiSelected(object sender, string emoji)
        {
            CommentTextBox.Text += emoji;
        }
    }
}
