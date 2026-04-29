namespace HOTEL_RESERVATION
{
    partial class Homepage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            gotoroom = new Button();
            panel3 = new Panel();
            panel5 = new Panel();
            nameuser = new Label();
            label5 = new Label();
            pictureBox5 = new PictureBox();
            panel4 = new Panel();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1413, 150);
            panel1.TabIndex = 0;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.Image = Properties.Resources.no;
            pictureBox4.Location = new Point(1249, 32);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(127, 55);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.Image = Properties.Resources.login;
            pictureBox3.Location = new Point(1110, 32);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(127, 55);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.user;
            pictureBox2.Location = new Point(963, 32);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(124, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(1290, 102);
            label3.Name = "label3";
            label3.Size = new Size(46, 25);
            label3.TabIndex = 3;
            label3.Text = "EXIT";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(1146, 100);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 2;
            label2.Text = "LOGIN";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(989, 102);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 1;
            label1.Text = "PROFILE";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.holiday_inn_logo_png_transparent__1_;
            pictureBox1.Location = new Point(101, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // gotoroom
            // 
            gotoroom.Anchor = AnchorStyles.None;
            gotoroom.BackColor = Color.ForestGreen;
            gotoroom.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gotoroom.ForeColor = SystemColors.ControlLightLight;
            gotoroom.Location = new Point(567, 384);
            gotoroom.Name = "gotoroom";
            gotoroom.Padding = new Padding(10);
            gotoroom.Size = new Size(298, 99);
            gotoroom.TabIndex = 2;
            gotoroom.Text = "CONTINUE TO BOOKING";
            gotoroom.UseVisualStyleBackColor = false;
            gotoroom.Click += gotoroom_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLight;
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(gotoroom);
            panel3.Controls.Add(pictureBox5);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 150);
            panel3.Name = "panel3";
            panel3.Size = new Size(1413, 852);
            panel3.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = Color.ForestGreen;
            panel5.Controls.Add(nameuser);
            panel5.Controls.Add(label5);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1413, 73);
            panel5.TabIndex = 2;
            // 
            // nameuser
            // 
            nameuser.AutoSize = true;
            nameuser.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameuser.ForeColor = SystemColors.ButtonHighlight;
            nameuser.Location = new Point(101, 23);
            nameuser.Name = "nameuser";
            nameuser.Size = new Size(86, 28);
            nameuser.TabIndex = 1;
            nameuser.Text = "Hi Guest";
            nameuser.Click += nameuser_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(936, 23);
            label5.Name = "label5";
            label5.Size = new Size(437, 28);
            label5.TabIndex = 0;
            label5.Text = "WELCOME TO HOLIDAY INN RESERVATION PAGE";
            // 
            // pictureBox5
            // 
            pictureBox5.Dock = DockStyle.Fill;
            pictureBox5.Image = Properties.Resources.luxury_classic_modern_bedroom_suite_hotel;
            pictureBox5.Location = new Point(0, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(1413, 795);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.GradientInactiveCaption;
            panel4.Controls.Add(label4);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 795);
            panel4.Name = "panel4";
            panel4.Size = new Size(1413, 57);
            panel4.TabIndex = 0;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(681, 20);
            label4.Name = "label4";
            label4.Size = new Size(114, 25);
            label4.TabIndex = 0;
            label4.Text = "VERSION 2.1";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1413, 1002);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Homepage";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private Label label4;
        private Panel panel5;
        private Label label5;
        private Label nameuser;
        private Button gotoroom;
    }
}
