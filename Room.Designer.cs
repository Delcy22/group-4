namespace new_windows_forms_app
{
    partial class Room
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Room));
            panel1 = new Panel();
            pictureBox5 = new PictureBox();
            panel3 = new Panel();
            homebtn = new Button();
            pictureBox4 = new PictureBox();
            label7 = new Label();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label17 = new Label();
            label6 = new Label();
            panel4 = new Panel();
            panel6 = new Panel();
            button2 = new Button();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel5 = new Panel();
            button1 = new Button();
            label5 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            pictureBox9 = new PictureBox();
            pictureBox7 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 830);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(35, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(171, 118);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LimeGreen;
            panel3.Controls.Add(homebtn);
            panel3.Controls.Add(pictureBox4);
            panel3.Location = new Point(0, 743);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 87);
            panel3.TabIndex = 3;
            // 
            // homebtn
            // 
            homebtn.Location = new Point(143, 30);
            homebtn.Name = "homebtn";
            homebtn.Size = new Size(112, 34);
            homebtn.TabIndex = 11;
            homebtn.Text = "HOME";
            homebtn.UseVisualStyleBackColor = true;
            homebtn.Click += gotohome;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(47, 21);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(72, 54);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(35, 169);
            label7.Name = "label7";
            label7.Size = new Size(142, 48);
            label7.TabIndex = 7;
            label7.Text = "OFFERS";
            label7.Click += label7_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(35, 536);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(95, 94);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(152, 565);
            label4.Name = "label4";
            label4.Size = new Size(108, 28);
            label4.TabIndex = 7;
            label4.Text = "BOOKING";
            label4.Click += label4_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(35, 394);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(95, 94);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(152, 423);
            label3.Name = "label3";
            label3.Size = new Size(88, 28);
            label3.TabIndex = 5;
            label3.Text = "DINING";
            label3.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(35, 261);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(95, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(152, 290);
            label2.Name = "label2";
            label2.Size = new Size(87, 28);
            label2.TabIndex = 3;
            label2.Text = "ROOMS";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(37, 31);
            label1.Name = "label1";
            label1.Size = new Size(494, 48);
            label1.TabIndex = 1;
            label1.Text = "HOTEL RESERVATION SYSTEM";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGreen;
            panel2.Controls.Add(label17);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(300, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1006, 118);
            panel2.TabIndex = 2;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label17.ForeColor = SystemColors.ButtonFace;
            label17.Location = new Point(650, 50);
            label17.Name = "label17";
            label17.Size = new Size(97, 25);
            label17.TabIndex = 15;
            label17.Text = "version 2.0";
            label17.Click += label17_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 25F);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(942, 17);
            label6.Name = "label6";
            label6.Size = new Size(52, 67);
            label6.TabIndex = 6;
            label6.Text = "x";
            // 
            // panel4
            // 
            panel4.AutoScroll = true;
            panel4.AutoScrollMinSize = new Size(0, 1000);
            panel4.BackColor = Color.Snow;
            panel4.BackgroundImageLayout = ImageLayout.None;
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(flowLayoutPanel1);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(300, 114);
            panel4.Name = "panel4";
            panel4.Size = new Size(1006, 716);
            panel4.TabIndex = 3;
            panel4.Paint += panel4_Paint;
            // 
            // panel6
            // 
            panel6.BackColor = Color.LightGray;
            panel6.Controls.Add(button2);
            panel6.Controls.Add(label11);
            panel6.Controls.Add(label12);
            panel6.Controls.Add(label13);
            panel6.Controls.Add(pictureBox9);
            panel6.Location = new Point(536, 84);
            panel6.Name = "panel6";
            panel6.Size = new Size(364, 305);
            panel6.TabIndex = 16;
            // 
            // button2
            // 
            button2.BackColor = Color.Goldenrod;
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(224, 179);
            button2.Name = "button2";
            button2.Size = new Size(128, 91);
            button2.TabIndex = 17;
            button2.Text = "BOOK NOW";
            button2.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.Location = new Point(237, 128);
            label11.Name = "label11";
            label11.Size = new Size(96, 25);
            label11.TabIndex = 16;
            label11.Text = "AVAILABLE";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Gainsboro;
            label12.Font = new Font("Segoe UI", 10F);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(233, 82);
            label12.Name = "label12";
            label12.Padding = new Padding(5);
            label12.Size = new Size(104, 38);
            label12.TabIndex = 12;
            label12.Text = "Per Night";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 20F);
            label13.ForeColor = Color.White;
            label13.Location = new Point(226, 24);
            label13.Name = "label13";
            label13.Size = new Size(111, 54);
            label13.TabIndex = 11;
            label13.Text = "$100";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Silver;
            flowLayoutPanel1.Location = new Point(41, 58);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(859, 10);
            flowLayoutPanel1.TabIndex = 15;
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightGray;
            panel5.Controls.Add(pictureBox7);
            panel5.Controls.Add(button1);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(label9);
            panel5.Location = new Point(40, 84);
            panel5.Name = "panel5";
            panel5.Size = new Size(364, 305);
            panel5.TabIndex = 14;
            // 
            // button1
            // 
            button1.BackColor = Color.Goldenrod;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(224, 179);
            button1.Name = "button1";
            button1.Size = new Size(128, 91);
            button1.TabIndex = 17;
            button1.Text = "BOOK NOW";
            button1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(237, 128);
            label5.Name = "label5";
            label5.Size = new Size(96, 25);
            label5.TabIndex = 16;
            label5.Text = "AVAILABLE";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Gainsboro;
            label10.Font = new Font("Segoe UI", 10F);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(233, 82);
            label10.Name = "label10";
            label10.Padding = new Padding(5);
            label10.Size = new Size(104, 38);
            label10.TabIndex = 12;
            label10.Text = "Per Night";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 20F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(226, 24);
            label9.Name = "label9";
            label9.Size = new Size(111, 54);
            label9.TabIndex = 11;
            label9.Text = "$100";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 12F);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(37, 23);
            label8.Name = "label8";
            label8.Size = new Size(225, 32);
            label8.TabIndex = 13;
            label8.Text = "STANDARD ROOMS";
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.interior_modern_comfortable_hotel_room;
            pictureBox9.Location = new Point(18, 27);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(193, 128);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 9;
            pictureBox9.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.interior_modern_comfortable_hotel_room;
            pictureBox7.Location = new Point(14, 29);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(193, 128);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 18;
            pictureBox7.TabStop = false;
            // 
            // Room
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1306, 830);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Room";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Label label4;
        private PictureBox pictureBox2;
        private Label label3;
        private Panel panel3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label label6;
        private Label label7;
        private Label label17;
        private Button homebtn;
        private Panel panel4;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel5;
        private Label label10;
        private Label label9;
        private Label label8;
        private Button button1;
        private Label label5;
        private Panel panel6;
        private Button button2;
        private Label label11;
        private Label label12;
        private Label label13;
        private PictureBox pictureBox9;
        private PictureBox pictureBox7;
    }
}
