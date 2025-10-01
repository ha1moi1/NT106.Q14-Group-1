namespace Monopoly
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            btnDangKi = new Button();
            label2 = new Label();
            llblDangNhap = new LinkLabel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1262, 676);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 15.7090893F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(346, 94);
            label1.Name = "label1";
            label1.Padding = new Padding(20, 20, 20, 20);
            label1.Size = new Size(520, 486);
            label1.TabIndex = 1;
            label1.Text = "ĐĂNG KÝ";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 13.090909F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(386, 187);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(452, 30);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft Sans Serif", 13.090909F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(386, 257);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(452, 30);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Microsoft Sans Serif", 13.090909F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(386, 332);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(452, 30);
            textBox3.TabIndex = 4;
            textBox3.UseSystemPasswordChar = true;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Microsoft Sans Serif", 13.090909F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(386, 410);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(452, 30);
            textBox4.TabIndex = 5;
            textBox4.UseSystemPasswordChar = true;
            // 
            // btnDangKi
            // 
            btnDangKi.Font = new Font("Microsoft Sans Serif", 13.090909F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDangKi.Location = new Point(541, 480);
            btnDangKi.Name = "btnDangKi";
            btnDangKi.Size = new Size(129, 40);
            btnDangKi.TabIndex = 6;
            btnDangKi.Text = "Đăng ký";
            btnDangKi.UseVisualStyleBackColor = true;
            btnDangKi.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 11.1272726F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(621, 533);
            label2.Name = "label2";
            label2.Size = new Size(134, 20);
            label2.TabIndex = 7;
            label2.Text = "Đã có tài khoản?";
            label2.Click += label2_Click;
            // 
            // llblDangNhap
            // 
            llblDangNhap.AutoSize = true;
            llblDangNhap.Font = new Font("Microsoft Sans Serif", 11.1272726F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llblDangNhap.Location = new Point(749, 533);
            llblDangNhap.Name = "llblDangNhap";
            llblDangNhap.Size = new Size(89, 20);
            llblDangNhap.TabIndex = 8;
            llblDangNhap.TabStop = true;
            llblDangNhap.Text = "Đăng nhập";
            llblDangNhap.LinkClicked += llblDangNhap_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.Location = new Point(386, 165);
            label3.Name = "label3";
            label3.Size = new Size(131, 21);
            label3.TabIndex = 9;
            label3.Text = "Tên người dùng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.Location = new Point(386, 236);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 10;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label5.Location = new Point(386, 310);
            label5.Name = "label5";
            label5.Size = new Size(82, 21);
            label5.TabIndex = 11;
            label5.Text = "Mật khẩu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label6.Location = new Point(386, 389);
            label6.Name = "label6";
            label6.Size = new Size(151, 21);
            label6.TabIndex = 12;
            label6.Text = "Nhập lại mật khẩu";
            label6.Click += label6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 676);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(llblDangNhap);
            Controls.Add(label2);
            Controls.Add(btnDangKi);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "SignUp";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button btnDangKi;
        private Label label2;
        private LinkLabel llblDangNhap;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}