namespace HOTEL_RESERVATION.Pages.Profile
{
    partial class Profile
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
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            deletebtn = new Button();
            updatebtn = new Button();
            label1 = new Label();
            profileview = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profileview).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1348, 150);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.no;
            pictureBox2.Location = new Point(1044, 48);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(150, 75);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.holiday_inn_logo_png_transparent__1_;
            pictureBox1.Location = new Point(154, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(deletebtn);
            panel2.Controls.Add(updatebtn);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(profileview);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 150);
            panel2.Name = "panel2";
            panel2.Size = new Size(1348, 723);
            panel2.TabIndex = 1;
            // 
            // deletebtn
            // 
            deletebtn.Anchor = AnchorStyles.None;
            deletebtn.Location = new Point(1072, 80);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(122, 51);
            deletebtn.TabIndex = 3;
            deletebtn.Text = "DELETE";
            deletebtn.UseVisualStyleBackColor = true;
            deletebtn.Click += deletebtn_Click;
            // 
            // updatebtn
            // 
            updatebtn.Anchor = AnchorStyles.None;
            updatebtn.Location = new Point(918, 80);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(125, 51);
            updatebtn.TabIndex = 2;
            updatebtn.Text = "UPDATE";
            updatebtn.UseVisualStyleBackColor = true;
            updatebtn.Click += updatebtn_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(154, 86);
            label1.Name = "label1";
            label1.Size = new Size(137, 45);
            label1.TabIndex = 1;
            label1.Text = "PROFILE";
            // 
            // profileview
            // 
            profileview.Anchor = AnchorStyles.None;
            profileview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            profileview.Location = new Point(154, 148);
            profileview.Name = "profileview";
            profileview.RowHeadersWidth = 62;
            profileview.Size = new Size(1040, 374);
            profileview.TabIndex = 0;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 873);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Profile";
            Text = "Profile";
            WindowState = FormWindowState.Maximized;
            Load += Profile_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)profileview).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView profileview;
        private Button deletebtn;
        private Button updatebtn;
    }
}