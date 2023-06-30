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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ptbImage22 = new System.Windows.Forms.PictureBox();
            this.ptbImage21 = new System.Windows.Forms.PictureBox();
            this.ptbImage1 = new System.Windows.Forms.PictureBox();
            this.lblContent = new System.Windows.Forms.Label();
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
            this.panelimage.BackColor = System.Drawing.Color.White;
            this.panelimage.BackgroundImage = global::Blog.Properties.Resources.cmt5;
            this.panelimage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelimage.Controls.Add(this.pictureBox1);
            this.panelimage.Controls.Add(this.ptbImage22);
            this.panelimage.Controls.Add(this.ptbImage21);
            this.panelimage.Controls.Add(this.ptbImage1);
            this.panelimage.Controls.Add(this.lblContent);
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
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(28, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 57);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ptbImage22
            // 
            this.ptbImage22.BackColor = System.Drawing.Color.Transparent;
            this.ptbImage22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbImage22.Location = new System.Drawing.Point(350, 224);
            this.ptbImage22.Name = "ptbImage22";
            this.ptbImage22.Size = new System.Drawing.Size(244, 347);
            this.ptbImage22.TabIndex = 9;
            this.ptbImage22.TabStop = false;
            this.ptbImage22.Visible = false;
            // 
            // ptbImage21
            // 
            this.ptbImage21.BackColor = System.Drawing.Color.Transparent;
            this.ptbImage21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbImage21.Location = new System.Drawing.Point(52, 224);
            this.ptbImage21.Name = "ptbImage21";
            this.ptbImage21.Size = new System.Drawing.Size(259, 347);
            this.ptbImage21.TabIndex = 8;
            this.ptbImage21.TabStop = false;
            this.ptbImage21.Visible = false;
            // 
            // ptbImage1
            // 
            this.ptbImage1.BackColor = System.Drawing.Color.White;
            this.ptbImage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbImage1.Location = new System.Drawing.Point(43, 224);
            this.ptbImage1.Name = "ptbImage1";
            this.ptbImage1.Size = new System.Drawing.Size(563, 347);
            this.ptbImage1.TabIndex = 7;
            this.ptbImage1.TabStop = false;
            // 
            // lblContent
            // 
            this.lblContent.AllowDrop = true;
            this.lblContent.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContent.Location = new System.Drawing.Point(24, 154);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(591, 67);
            this.lblContent.TabIndex = 6;
            this.lblContent.Text = resources.GetString("lblContent.Text");
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(131, 48);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(45, 18);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "date";
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(24, 78);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(48, 25);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "gàg";
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTag.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTag.Location = new System.Drawing.Point(24, 115);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(60, 25);
            this.lblTag.TabIndex = 1;
            this.lblTag.Text = "#tag";
            // 
            // lblUN
            // 
            this.lblUN.AutoSize = true;
            this.lblUN.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUN.Location = new System.Drawing.Point(129, 9);
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
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.PictureBox ptbImage1;
        private System.Windows.Forms.PictureBox ptbImage21;
        private System.Windows.Forms.PictureBox ptbImage22;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelimage;
    }
}