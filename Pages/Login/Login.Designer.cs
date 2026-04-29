namespace HOTEL_RESERVATION.Pages.Login
{
    partial class Login
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
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            loginbtn = new Button();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            passwordlogin = new MaskedTextBox();
            groupBox1 = new GroupBox();
            emaillogin = new MaskedTextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1199, 150);
            panel1.TabIndex = 0;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.Image = Properties.Resources.no;
            pictureBox4.Location = new Point(1010, 50);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(127, 55);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.holiday_inn_logo_png_transparent__1_;
            pictureBox1.Location = new Point(61, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.InactiveBorder;
            panel2.Controls.Add(loginbtn);
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 150);
            panel2.Name = "panel2";
            panel2.Size = new Size(1199, 633);
            panel2.TabIndex = 1;
            // 
            // loginbtn
            // 
            loginbtn.Anchor = AnchorStyles.None;
            loginbtn.Location = new Point(538, 481);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(133, 50);
            loginbtn.TabIndex = 7;
            loginbtn.Text = "LOGIN";
            loginbtn.UseVisualStyleBackColor = true;
            loginbtn.Click += loginbtn_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.None;
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(660, 564);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(138, 25);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "RGISTER NOW !";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(421, 564);
            label2.Name = "label2";
            label2.Size = new Size(203, 25);
            label2.TabIndex = 5;
            label2.Text = "Don`t have an account ?";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(520, 48);
            label1.Name = "label1";
            label1.Size = new Size(151, 54);
            label1.TabIndex = 4;
            label1.Text = "LOGIN";
            label1.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.None;
            groupBox2.Controls.Add(passwordlogin);
            groupBox2.Location = new Point(368, 316);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(503, 150);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "PASSWORD";
            // 
            // passwordlogin
            // 
            passwordlogin.Location = new Point(16, 72);
            passwordlogin.Name = "passwordlogin";
            passwordlogin.Size = new Size(454, 31);
            passwordlogin.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(emaillogin);
            groupBox1.Location = new Point(368, 125);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(503, 150);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "EMAIL";
            // 
            // emaillogin
            // 
            emaillogin.Location = new Point(15, 68);
            emaillogin.Name = "emaillogin";
            emaillogin.Size = new Size(455, 31);
            emaillogin.TabIndex = 0;
            emaillogin.MaskInputRejected += emaillogin_MaskInputRejected;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 783);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Login";
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
        private Label label1;
        private GroupBox groupBox2;
        private MaskedTextBox passwordlogin;
        private GroupBox groupBox1;
        private MaskedTextBox emaillogin;
        private LinkLabel linkLabel1;
        private Label label2;
        private Button loginbtn;
    }
}