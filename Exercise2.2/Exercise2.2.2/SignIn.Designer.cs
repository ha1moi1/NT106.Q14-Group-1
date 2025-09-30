
namespace Monopoly
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            btnDangNhap = new Button();
            label4 = new Label();
            llblDangKi = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1262, 712);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 13.090909F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(385, 245);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(452, 32);
            textBox1.TabIndex = 3;
            textBox1.Text = "Tên người dùng";
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 15.7090893F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(346, 145);
            label1.Margin = new Padding(3);
            label1.Name = "label1";
            label1.Padding = new Padding(20, 21, 20, 21);
            label1.Size = new Size(520, 396);
            label1.TabIndex = 2;
            label1.Text = "ĐĂNG NHẬP";
            label1.TextAlign = ContentAlignment.TopCenter;

            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft Sans Serif", 13.090909F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(385, 335);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(452, 32);
            textBox2.TabIndex = 6;
            textBox2.Text = "Mật khẩu";

            // 
            // btnDangNhap
            // 
            btnDangNhap.Font = new Font("Microsoft Sans Serif", 13.090909F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDangNhap.Location = new Point(546, 416);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(129, 42);
            btnDangNhap.TabIndex = 8;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 11.1272726F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(592, 479);
            label4.Name = "label4";
            label4.Size = new Size(171, 24);
            label4.TabIndex = 10;
            label4.Text = "Chưa có tài khoản?";
            label4.Click += label4_Click;
            // 
            // llblDangKi
            // 
            llblDangKi.AutoSize = true;
            llblDangKi.Font = new Font("Microsoft Sans Serif", 11.1272726F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llblDangKi.Location = new Point(757, 479);
            llblDangKi.Name = "llblDangKi";
            llblDangKi.Size = new Size(78, 24);
            llblDangKi.TabIndex = 11;
            llblDangKi.TabStop = true;
            llblDangKi.Text = "Đăng ký";
            llblDangKi.LinkClicked += linkLabel1_LinkClicked;
            // 
            // SignIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 712);
            Controls.Add(llblDangKi);
            Controls.Add(label4);
            Controls.Add(btnDangNhap);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "SignIn";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Button btnDangNhap;
        private Label label4;
        private LinkLabel llblDangKi;
    }
}
