namespace Client
{
    partial class SignInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInForm));
            lblUsername = new Label();
            lblAppName = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            btnRegister = new Button();
            btnOK = new Button();
            btnCancel = new Button();
            panel1 = new Panel();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Tahoma", 10.2F);
            lblUsername.Location = new Point(113, 399);
            lblUsername.Margin = new Padding(5, 0, 5, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(0, 34);
            lblUsername.TabIndex = 4;
            lblUsername.Click += lblUsername_Click;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppName.ImageAlign = ContentAlignment.MiddleRight;
            lblAppName.Location = new Point(327, 285);
            lblAppName.Margin = new Padding(5, 0, 5, 0);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(0, 60);
            lblAppName.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Window;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Enabled = false;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.FromArgb(255, 192, 192);
            txtPassword.Location = new Point(5, 5);
            txtPassword.Margin = new Padding(5);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.ShortcutsEnabled = false;
            txtPassword.Size = new Size(641, 76);
            txtPassword.TabIndex = 8;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.Transparent;
            txtUsername.Location = new Point(5, 5);
            txtUsername.Margin = new Padding(5);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(641, 76);
            txtUsername.TabIndex = 7;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.White;
            btnRegister.FlatAppearance.BorderSize = 2;
            btnRegister.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.MidnightBlue;
            btnRegister.Location = new Point(124, 502);
            btnRegister.Margin = new Padding(5);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(193, 74);
            btnRegister.TabIndex = 12;
            btnRegister.Text = "Đăng ký...";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnOK
            // 
            btnOK.BackColor = Color.White;
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOK.ForeColor = Color.Navy;
            btnOK.Location = new Point(150, 743);
            btnOK.Margin = new Padding(5);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(171, 73);
            btnOK.TabIndex = 9;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderSize = 2;
            btnCancel.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.Navy;
            btnCancel.Location = new Point(448, 743);
            btnCancel.Margin = new Padding(5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(185, 74);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Hủy bỏ";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnOK);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(471, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1024, 1200);
            panel1.TabIndex = 14;
            panel1.Paint += panel1_Paint;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Black", 25.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(32, 64);
            label5.Name = "label5";
            label5.Size = new Size(712, 214);
            label5.TabIndex = 19;
            label5.Text = "Chào mừng đến với Cờ Tỷ Phú";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(74, 564);
            label3.Name = "label3";
            label3.Size = new Size(238, 45);
            label3.TabIndex = 15;
            label3.Text = "Nhập mật khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(74, 390);
            label2.Name = "label2";
            label2.Size = new Size(327, 45);
            label2.TabIndex = 14;
            label2.Text = "Nhập tên người dùng";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(69, 306);
            label1.Name = "label1";
            label1.Size = new Size(304, 71);
            label1.TabIndex = 13;
            label1.Text = "Đăng nhập";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(txtPassword);
            panel2.Location = new Point(69, 613);
            panel2.Name = "panel2";
            panel2.Size = new Size(651, 86);
            panel2.TabIndex = 16;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(txtUsername);
            panel3.Location = new Point(69, 438);
            panel3.Name = "panel3";
            panel3.Size = new Size(651, 86);
            panel3.TabIndex = 17;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(124, 104);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(203, 199);
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click_1;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(58, 306);
            label4.Name = "label4";
            label4.Size = new Size(387, 158);
            label4.TabIndex = 18;
            label4.Text = "Bạn chưa có tài khoản ?";
            label4.Click += label4_Click_1;
            // 
            // SignInForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1286, 895);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(lblAppName);
            Controls.Add(lblUsername);
            Controls.Add(panel1);
            Controls.Add(btnRegister);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            Name = "SignInForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            Load += SignInForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblAppName;
        private Label lblUsername;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Button btnRegister;
        private Button btnOK;
        private Button btnCancel;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label5;
    }
}
