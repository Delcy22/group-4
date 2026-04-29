namespace HOTEL_RESERVATION.Pages.Registration
{
    partial class Registration
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
            registerbtn = new Button();
            groupBox6 = new GroupBox();
            password = new MaskedTextBox();
            groupBox5 = new GroupBox();
            email = new MaskedTextBox();
            groupBox4 = new GroupBox();
            contact = new MaskedTextBox();
            groupBox3 = new GroupBox();
            nationalid = new MaskedTextBox();
            groupBox2 = new GroupBox();
            surname = new MaskedTextBox();
            groupBox1 = new GroupBox();
            firstname = new MaskedTextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
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
            panel1.Size = new Size(1212, 150);
            panel1.TabIndex = 0;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.Image = Properties.Resources.no;
            pictureBox4.Location = new Point(1014, 45);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(127, 55);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.holiday_inn_logo_png_transparent__1_;
            pictureBox1.Location = new Point(65, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.InactiveBorder;
            panel2.Controls.Add(registerbtn);
            panel2.Controls.Add(groupBox6);
            panel2.Controls.Add(groupBox5);
            panel2.Controls.Add(groupBox4);
            panel2.Controls.Add(groupBox3);
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 150);
            panel2.Name = "panel2";
            panel2.Size = new Size(1212, 619);
            panel2.TabIndex = 1;
            // 
            // registerbtn
            // 
            registerbtn.Anchor = AnchorStyles.None;
            registerbtn.Location = new Point(540, 575);
            registerbtn.Name = "registerbtn";
            registerbtn.Size = new Size(112, 34);
            registerbtn.TabIndex = 7;
            registerbtn.Text = "REGISTER";
            registerbtn.UseVisualStyleBackColor = true;
            registerbtn.Click += registerbtn_Click;
            // 
            // groupBox6
            // 
            groupBox6.Anchor = AnchorStyles.None;
            groupBox6.Controls.Add(password);
            groupBox6.Location = new Point(333, 496);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(516, 69);
            groupBox6.TabIndex = 6;
            groupBox6.TabStop = false;
            groupBox6.Text = "PASSWORD";
            // 
            // password
            // 
            password.Location = new Point(13, 30);
            password.Name = "password";
            password.Size = new Size(482, 31);
            password.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Anchor = AnchorStyles.None;
            groupBox5.Controls.Add(email);
            groupBox5.Location = new Point(333, 421);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(516, 69);
            groupBox5.TabIndex = 6;
            groupBox5.TabStop = false;
            groupBox5.Text = "EMAIL";
            // 
            // email
            // 
            email.Location = new Point(13, 30);
            email.Name = "email";
            email.Size = new Size(482, 31);
            email.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.None;
            groupBox4.Controls.Add(contact);
            groupBox4.Location = new Point(333, 346);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(516, 69);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "CONTACT";
            // 
            // contact
            // 
            contact.Location = new Point(13, 30);
            contact.Name = "contact";
            contact.Size = new Size(481, 31);
            contact.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.None;
            groupBox3.Controls.Add(nationalid);
            groupBox3.Location = new Point(333, 271);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(516, 69);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "NATIONAL ID NUMBER";
            // 
            // nationalid
            // 
            nationalid.Location = new Point(13, 30);
            nationalid.Name = "nationalid";
            nationalid.Size = new Size(482, 31);
            nationalid.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.None;
            groupBox2.Controls.Add(surname);
            groupBox2.Location = new Point(333, 196);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(516, 69);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "SURNAME";
            // 
            // surname
            // 
            surname.Location = new Point(13, 32);
            surname.Name = "surname";
            surname.Size = new Size(482, 31);
            surname.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(firstname);
            groupBox1.Location = new Point(333, 121);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(516, 69);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "NAME";
            // 
            // firstname
            // 
            firstname.Anchor = AnchorStyles.None;
            firstname.Location = new Point(13, 31);
            firstname.Name = "firstname";
            firstname.Size = new Size(481, 31);
            firstname.TabIndex = 0;
            firstname.MaskInputRejected += firstname_MaskInputRejected;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(434, 31);
            label1.Name = "label1";
            label1.Size = new Size(322, 54);
            label1.TabIndex = 5;
            label1.Text = "REGISTRATION";
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1212, 769);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Registration";
            Text = "Registration";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
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
        private GroupBox groupBox5;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Label label1;
        private Button registerbtn;
        private GroupBox groupBox6;
        private MaskedTextBox password;
        private MaskedTextBox email;
        private MaskedTextBox contact;
        private MaskedTextBox nationalid;
        private MaskedTextBox surname;
        private MaskedTextBox firstname;
    }
}