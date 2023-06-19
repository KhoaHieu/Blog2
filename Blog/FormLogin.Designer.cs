namespace Blog
{
    partial class FormLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbUN = new System.Windows.Forms.TextBox();
            this.txbPW = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panellogin = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panellogin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "User name";
            // 
            // txbUN
            // 
            this.txbUN.BackColor = System.Drawing.Color.White;
            this.txbUN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUN.ForeColor = System.Drawing.Color.Black;
            this.txbUN.Location = new System.Drawing.Point(65, 59);
            this.txbUN.Multiline = true;
            this.txbUN.Name = "txbUN";
            this.txbUN.Size = new System.Drawing.Size(303, 32);
            this.txbUN.TabIndex = 2;
            this.txbUN.TextChanged += new System.EventHandler(this.txbUN_TextChanged);
            // 
            // txbPW
            // 
            this.txbPW.BackColor = System.Drawing.Color.White;
            this.txbPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPW.ForeColor = System.Drawing.Color.Black;
            this.txbPW.Location = new System.Drawing.Point(63, 124);
            this.txbPW.Multiline = true;
            this.txbPW.Name = "txbPW";
            this.txbPW.PasswordChar = '*';
            this.txbPW.Size = new System.Drawing.Size(303, 32);
            this.txbPW.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSubmit.Location = new System.Drawing.Point(63, 167);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(115, 50);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnReg.FlatAppearance.BorderSize = 0;
            this.btnReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReg.ForeColor = System.Drawing.Color.White;
            this.btnReg.Location = new System.Drawing.Point(248, 167);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(118, 50);
            this.btnReg.TabIndex = 5;
            this.btnReg.Text = "Register";
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Forgot password?";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panellogin
            // 
            this.panellogin.BackColor = System.Drawing.Color.White;
            this.panellogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panellogin.Controls.Add(this.label3);
            this.panellogin.Controls.Add(this.btnReg);
            this.panellogin.Controls.Add(this.btnSubmit);
            this.panellogin.Controls.Add(this.txbPW);
            this.panellogin.Controls.Add(this.txbUN);
            this.panellogin.Controls.Add(this.label2);
            this.panellogin.Controls.Add(this.label1);
            this.panellogin.Location = new System.Drawing.Point(318, 263);
            this.panellogin.Name = "panellogin";
            this.panellogin.Size = new System.Drawing.Size(413, 269);
            this.panellogin.TabIndex = 8;
            this.panellogin.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Blog.Properties.Resources.background11;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(318, 52);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(413, 215);
            this.panel1.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(32, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(368, 26);
            this.label7.TabIndex = 3;
            this.label7.Text = "to welcome you to my blog hope you enjoy the fun we bring";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(32, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 26);
            this.label6.TabIndex = 2;
            this.label6.Text = "Welcome and it is my pleasure ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(30, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 37);
            this.label5.TabIndex = 1;
            this.label5.Text = "Welcome to Blog";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 48);
            this.label4.TabIndex = 0;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Blog.Properties.Resources.background11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1033, 676);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panellogin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panellogin.ResumeLayout(false);
            this.panellogin.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbUN;
        private System.Windows.Forms.TextBox txbPW;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panellogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

