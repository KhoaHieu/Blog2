namespace Blog
{
    partial class FormPost
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPost));
            this.panelimage = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ptbImage22 = new System.Windows.Forms.PictureBox();
            this.ptbImage21 = new System.Windows.Forms.PictureBox();
            this.ptbImage1 = new System.Windows.Forms.PictureBox();
            this.lblContent = new System.Windows.Forms.Label();
            this.lblNumCmt = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTag = new System.Windows.Forms.Label();
            this.lblUN = new System.Windows.Forms.Label();
            this.panelimage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelimage
            // 
            this.panelimage.BackColor = System.Drawing.Color.Transparent;
            this.panelimage.BackgroundImage = global::Blog.Properties.Resources.Picture3;
            this.panelimage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelimage.Controls.Add(this.button1);
            this.panelimage.Controls.Add(this.pictureBox1);
            this.panelimage.Controls.Add(this.ptbImage22);
            this.panelimage.Controls.Add(this.ptbImage21);
            this.panelimage.Controls.Add(this.ptbImage1);
            this.panelimage.Controls.Add(this.lblContent);
            this.panelimage.Controls.Add(this.lblNumCmt);
            this.panelimage.Controls.Add(this.lblDate);
            this.panelimage.Controls.Add(this.lblTitle);
            this.panelimage.Controls.Add(this.lblTag);
            this.panelimage.Controls.Add(this.lblUN);
            this.panelimage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelimage.Location = new System.Drawing.Point(0, 0);
            this.panelimage.Name = "panelimage";
            this.panelimage.Size = new System.Drawing.Size(756, 644);
            this.panelimage.TabIndex = 11;
            this.panelimage.Paint += new System.Windows.Forms.PaintEventHandler(this.panelimage_Paint);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Blog.Properties.Resources.png_clipart_computer_icons_x_mark_others_miscellaneous_angle;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(638, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 35);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(28, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 57);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // ptbImage22
            // 
            this.ptbImage22.BackColor = System.Drawing.Color.Transparent;
            this.ptbImage22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbImage22.Location = new System.Drawing.Point(358, 201);
            this.ptbImage22.Name = "ptbImage22";
            this.ptbImage22.Size = new System.Drawing.Size(320, 347);
            this.ptbImage22.TabIndex = 9;
            this.ptbImage22.TabStop = false;
            this.ptbImage22.Visible = false;
            // 
            // ptbImage21
            // 
            this.ptbImage21.BackColor = System.Drawing.Color.Transparent;
            this.ptbImage21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbImage21.Location = new System.Drawing.Point(28, 201);
            this.ptbImage21.Name = "ptbImage21";
            this.ptbImage21.Size = new System.Drawing.Size(299, 347);
            this.ptbImage21.TabIndex = 8;
            this.ptbImage21.TabStop = false;
            this.ptbImage21.Visible = false;
            // 
            // ptbImage1
            // 
            this.ptbImage1.BackColor = System.Drawing.Color.White;
            this.ptbImage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbImage1.Location = new System.Drawing.Point(28, 201);
            this.ptbImage1.Name = "ptbImage1";
            this.ptbImage1.Size = new System.Drawing.Size(667, 347);
            this.ptbImage1.TabIndex = 7;
            this.ptbImage1.TabStop = false;
            // 
            // lblContent
            // 
            this.lblContent.AllowDrop = true;
            this.lblContent.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContent.Location = new System.Drawing.Point(23, 131);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(721, 67);
            this.lblContent.TabIndex = 6;
            this.lblContent.Text = resources.GetString("lblContent.Text");
            // 
            // lblNumCmt
            // 
            this.lblNumCmt.AutoSize = true;
            this.lblNumCmt.Location = new System.Drawing.Point(90, 108);
            this.lblNumCmt.Name = "lblNumCmt";
            this.lblNumCmt.Size = new System.Drawing.Size(110, 16);
            this.lblNumCmt.TabIndex = 5;
            this.lblNumCmt.Text = "number comment";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(106, 47);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(39, 19);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "date";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(23, 69);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(49, 27);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "gàg";
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTag.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTag.Location = new System.Drawing.Point(24, 103);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(49, 24);
            this.lblTag.TabIndex = 1;
            this.lblTag.Text = "#tag";
            // 
            // lblUN
            // 
            this.lblUN.AutoSize = true;
            this.lblUN.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUN.Location = new System.Drawing.Point(105, 9);
            this.lblUN.Name = "lblUN";
            this.lblUN.Size = new System.Drawing.Size(112, 27);
            this.lblUN.TabIndex = 0;
            this.lblUN.Text = "username";
            // 
            // FormPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 644);
            this.Controls.Add(this.panelimage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPost";
            this.Text = "Post";
            this.panelimage.ResumeLayout(false);
            this.panelimage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUN;
        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblNumCmt;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.PictureBox ptbImage1;
        private System.Windows.Forms.PictureBox ptbImage21;
        private System.Windows.Forms.PictureBox ptbImage22;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelimage;
        private System.Windows.Forms.Button button1;
    }
}