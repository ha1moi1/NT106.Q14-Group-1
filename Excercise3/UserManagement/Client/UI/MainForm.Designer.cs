namespace Client.UI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnExit = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            Signout = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.White;
            btnExit.FlatAppearance.BorderColor = Color.White;
            btnExit.FlatAppearance.BorderSize = 2;
            btnExit.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Navy;
            btnExit.Location = new Point(106, 468);
            btnExit.Margin = new Padding(5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(236, 91);
            btnExit.TabIndex = 14;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-24, 736);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(192, 168);
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1144, -10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 157);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Navy;
            button2.Location = new Point(713, 519);
            button2.Name = "button2";
            button2.Size = new Size(278, 109);
            button2.TabIndex = 21;
            button2.Text = "Đồng đội";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Navy;
            button1.Location = new Point(713, 366);
            button1.Name = "button1";
            button1.Size = new Size(278, 114);
            button1.TabIndex = 20;
            button1.Text = "Chơi đơn";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(523, 171);
            label1.Name = "label1";
            label1.Size = new Size(693, 193);
            label1.TabIndex = 19;
            label1.Text = "Bắt đầu khởi nghiệp cùng Cờ tỷ phú !!!";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, -21);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(200, 136);
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(btnExit);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(469, 904);
            panel1.TabIndex = 22;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.LinkColor = Color.Blue;
            linkLabel1.Location = new Point(84, 394);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(289, 32);
            linkLabel1.TabIndex = 21;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Thể lệ của trò chơi ở đây..";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkBlue;
            label2.Location = new Point(40, 326);
            label2.Name = "label2";
            label2.Size = new Size(693, 68);
            label2.TabIndex = 20;
            label2.Text = "Hướng dẫn chơi";
            label2.Click += label2_Click;
            // 
            // Signout
            // 
            Signout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Signout.ForeColor = Color.Navy;
            Signout.Location = new Point(713, 660);
            Signout.Name = "Signout";
            Signout.Size = new Size(278, 109);
            Signout.TabIndex = 23;
            Signout.Text = "Đăng xuất";
            Signout.UseVisualStyleBackColor = true;
            Signout.Click += Signout_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1286, 895);
            Controls.Add(Signout);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(button2);
            Margin = new Padding(5);
            Name = "MainForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giao diện chính";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnExit;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel1;
        private Label label2;
        private LinkLabel linkLabel1;
        private Button Signout;
    }
}