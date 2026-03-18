namespace new_windows_forms_app
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            listBox1 = new ListBox();
            exitbtn = new Button();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel3 = new Panel();
            offersbtn = new Button();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.AliceBlue;
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.ForeColor = Color.Transparent;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1284, 110);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(529, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = SystemColors.ButtonShadow;
            flowLayoutPanel2.Controls.Add(pictureBox2);
            flowLayoutPanel2.Controls.Add(pictureBox3);
            flowLayoutPanel2.Dock = DockStyle.Left;
            flowLayoutPanel2.Location = new Point(0, 110);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(532, 664);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.interior_modern_comfortable_hotel_room;
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(529, 339);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 348);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(529, 325);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(1011, 51);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 1;
            label1.Text = "BOOKING";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(1160, 51);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 2;
            label2.Text = "LOGIN";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(52, 52);
            label3.Name = "label3";
            label3.Size = new Size(635, 32);
            label3.TabIndex = 3;
            label3.Text = "WELCOME TO HOLIDAY INN HOTEL RESERVATION SYSTEM";
            label3.Click += label3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.Controls.Add(label3);
            panel1.Location = new Point(532, 109);
            panel1.Name = "panel1";
            panel1.Size = new Size(752, 148);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Snow;
            panel2.Controls.Add(listBox1);
            panel2.Controls.Add(exitbtn);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(532, 255);
            panel2.Name = "panel2";
            panel2.Size = new Size(370, 519);
            panel2.TabIndex = 5;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "Free WIFI", "Swimming Pool", "Luxury SPA", "Fitness Center", "24/7 Reception", "Free Dining Restaurant ", "Room Service" });
            listBox1.Location = new Point(52, 114);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(278, 229);
            listBox1.TabIndex = 1;
            // 
            // exitbtn
            // 
            exitbtn.BackColor = Color.PaleVioletRed;
            exitbtn.ForeColor = SystemColors.Control;
            exitbtn.Location = new Point(168, 433);
            exitbtn.Name = "exitbtn";
            exitbtn.Size = new Size(112, 34);
            exitbtn.TabIndex = 2;
            exitbtn.Text = "EXIT";
            exitbtn.UseVisualStyleBackColor = false;
            exitbtn.Click += exitpoint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(52, 438);
            label6.Name = "label6";
            label6.Size = new Size(88, 25);
            label6.TabIndex = 1;
            label6.Text = "SERVICES";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.Location = new Point(52, 45);
            label4.Name = "label4";
            label4.Size = new Size(196, 32);
            label4.TabIndex = 0;
            label4.Text = "HOTEL FEATURES";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 396);
            label5.Name = "label5";
            label5.Size = new Size(237, 25);
            label5.TabIndex = 0;
            label5.Text = "QUALITY AND AFFORDABLE";
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.Controls.Add(offersbtn);
            panel3.Location = new Point(902, 255);
            panel3.Name = "panel3";
            panel3.Size = new Size(382, 519);
            panel3.TabIndex = 6;
            // 
            // offersbtn
            // 
            offersbtn.BackColor = Color.ForestGreen;
            offersbtn.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            offersbtn.ForeColor = SystemColors.ButtonFace;
            offersbtn.Location = new Point(80, 160);
            offersbtn.Name = "offersbtn";
            offersbtn.Size = new Size(247, 139);
            offersbtn.TabIndex = 2;
            offersbtn.Text = "OFFERS ";
            offersbtn.UseVisualStyleBackColor = false;
            offersbtn.Click += gotoroom;
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 774);
            ControlBox = false;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Homepage";
            Text = "Homepage";
            Load += Homepage_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        public FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox3;
        private Panel panel1;
        private Panel panel2;
        private Label label4;
        private Panel panel3;
        private ListBox listBox1;
        private Label label6;
        private Label label5;
        private Button offersbtn;
        private Button exitbtn;
    }
}