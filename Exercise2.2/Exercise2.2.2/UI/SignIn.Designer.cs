
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
            txtUserName = new TextBox();
            label1 = new Label();
            txtPassword = new TextBox();
            btnSignIn = new Button();
            label4 = new Label();
            llblDangKi = new LinkLabel();
            label2 = new Label();
            label3 = new Label();
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
            // txtUserName
            // 
            txtUserName.Font = new Font("Microsoft Sans Serif", 13.090909F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(385, 245);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(452, 32);
            txtUserName.TabIndex = 3;
            txtUserName.TextChanged += txtUserName_TextChanged;
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
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft Sans Serif", 13.090909F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(385, 335);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(452, 32);
            txtPassword.TabIndex = 6;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnSignIn
            // 
            btnSignIn.Font = new Font("Microsoft Sans Serif", 13.090909F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignIn.Location = new Point(546, 416);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(129, 42);
            btnSignIn.TabIndex = 8;
            btnSignIn.Text = "Đăng nhập";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(385, 222);
            label2.Name = "label2";
            label2.Size = new Size(137, 23);
            label2.TabIndex = 12;
            label2.Text = "Tên người dùng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.Location = new Point(385, 312);
            label3.Name = "label3";
            label3.Size = new Size(86, 23);
            label3.TabIndex = 13;
            label3.Text = "Mật khẩu";
            // 
            // SignIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 712);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(llblDangKi);
            Controls.Add(label4);
            Controls.Add(btnSignIn);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "SignIn";
            StartPosition = FormStartPosition.CenterScreen;
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
        private TextBox txtUserName;
        private Label label1;
        private TextBox txtPassword;
        private Button btnSignIn;
        private Label label4;
        private LinkLabel llblDangKi;
        private Label label2;
        private Label label3;
    }
}
