namespace Client.UI
{
    partial class SignUpForm
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
            pnlRegister = new Panel();
            BirthdayUser = new DateTimePicker();
            txtBoxFullName = new TextBox();
            txtBoxEmail = new TextBox();
            txtBoxCheckPassword = new TextBox();
            lblFullName = new Label();
            lblCheckPassword = new Label();
            lblBirthday = new Label();
            lblEmail = new Label();
            btnSignIn = new Button();
            btnCancel = new Button();
            lblUsername = new Label();
            lblPassword = new Label();
            btnOK = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            pnlHeader = new Panel();
            lblAppName = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pnlRegister.SuspendLayout();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlRegister
            // 
            pnlRegister.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlRegister.BackColor = SystemColors.ButtonFace;
            pnlRegister.BorderStyle = BorderStyle.FixedSingle;
            pnlRegister.Controls.Add(BirthdayUser);
            pnlRegister.Controls.Add(txtBoxFullName);
            pnlRegister.Controls.Add(txtBoxEmail);
            pnlRegister.Controls.Add(txtBoxCheckPassword);
            pnlRegister.Controls.Add(lblFullName);
            pnlRegister.Controls.Add(lblCheckPassword);
            pnlRegister.Controls.Add(lblBirthday);
            pnlRegister.Controls.Add(lblEmail);
            pnlRegister.Controls.Add(btnSignIn);
            pnlRegister.Controls.Add(btnCancel);
            pnlRegister.Controls.Add(lblUsername);
            pnlRegister.Controls.Add(lblPassword);
            pnlRegister.Controls.Add(btnOK);
            pnlRegister.Controls.Add(txtUsername);
            pnlRegister.Controls.Add(txtPassword);
            pnlRegister.Location = new Point(0, 90);
            pnlRegister.Name = "pnlRegister";
            pnlRegister.Size = new Size(585, 326);
            pnlRegister.TabIndex = 7;
            // 
            // BirthdayUser
            // 
            BirthdayUser.CustomFormat = "dd-MM-yyyy";
            BirthdayUser.Format = DateTimePickerFormat.Custom;
            BirthdayUser.Location = new Point(180, 100);
            BirthdayUser.MaxDate = new DateTime(2025, 10, 25, 21, 44, 4, 914);
            BirthdayUser.Name = "BirthdayUser";
            BirthdayUser.Size = new Size(250, 27);
            BirthdayUser.TabIndex = 22;
            BirthdayUser.Value = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            // 
            // txtBoxFullName
            // 
            txtBoxFullName.Location = new Point(180, 60);
            txtBoxFullName.Name = "txtBoxFullName";
            txtBoxFullName.PasswordChar = '*';
            txtBoxFullName.Size = new Size(250, 27);
            txtBoxFullName.TabIndex = 21;
            txtBoxFullName.UseSystemPasswordChar = true;
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.Location = new Point(180, 140);
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.PasswordChar = '*';
            txtBoxEmail.Size = new Size(250, 27);
            txtBoxEmail.TabIndex = 19;
            txtBoxEmail.UseSystemPasswordChar = true;
            // 
            // txtBoxCheckPassword
            // 
            txtBoxCheckPassword.Location = new Point(180, 220);
            txtBoxCheckPassword.Name = "txtBoxCheckPassword";
            txtBoxCheckPassword.PasswordChar = '*';
            txtBoxCheckPassword.Size = new Size(250, 27);
            txtBoxCheckPassword.TabIndex = 18;
            txtBoxCheckPassword.UseSystemPasswordChar = true;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Tahoma", 10.2F);
            lblFullName.Location = new Point(20, 60);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(87, 21);
            lblFullName.TabIndex = 17;
            lblFullName.Text = "Họ và tên:";
            // 
            // lblCheckPassword
            // 
            lblCheckPassword.AutoSize = true;
            lblCheckPassword.Font = new Font("Tahoma", 10.2F);
            lblCheckPassword.Location = new Point(20, 220);
            lblCheckPassword.Name = "lblCheckPassword";
            lblCheckPassword.Size = new Size(150, 21);
            lblCheckPassword.TabIndex = 16;
            lblCheckPassword.Text = "Nhập lại mật khẩu:";
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Font = new Font("Tahoma", 10.2F);
            lblBirthday.Location = new Point(20, 100);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(88, 21);
            lblBirthday.TabIndex = 15;
            lblBirthday.Text = "Ngày sinh:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Tahoma", 10.2F);
            lblEmail.Location = new Point(20, 140);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(57, 21);
            lblEmail.TabIndex = 14;
            lblEmail.Text = "Email:";
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = SystemColors.ButtonHighlight;
            btnSignIn.FlatAppearance.BorderColor = Color.White;
            btnSignIn.FlatAppearance.BorderSize = 2;
            btnSignIn.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignIn.ForeColor = SystemColors.ActiveCaptionText;
            btnSignIn.Location = new Point(440, 275);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(120, 35);
            btnSignIn.TabIndex = 12;
            btnSignIn.Text = "Đăng nhập...";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ButtonHighlight;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderColor = Color.White;
            btnCancel.FlatAppearance.BorderSize = 2;
            btnCancel.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.ActiveCaptionText;
            btnCancel.Location = new Point(310, 275);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 35);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Hủy bỏ";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Tahoma", 10.2F);
            lblUsername.Location = new Point(20, 20);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(131, 21);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "Tên người dùng:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Tahoma", 10.2F);
            lblPassword.Location = new Point(20, 180);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(84, 21);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Mật khẩu:";
            // 
            // btnOK
            // 
            btnOK.BackColor = SystemColors.ButtonHighlight;
            btnOK.DialogResult = DialogResult.OK;
            btnOK.FlatAppearance.BorderSize = 2;
            btnOK.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOK.ForeColor = SystemColors.ActiveCaptionText;
            btnOK.Location = new Point(180, 275);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(120, 35);
            btnOK.TabIndex = 9;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(180, 20);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(250, 27);
            txtUsername.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(180, 180);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(250, 27);
            txtPassword.TabIndex = 8;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = SystemColors.ButtonHighlight;
            pnlHeader.Controls.Add(lblAppName);
            pnlHeader.Controls.Add(pictureBox1);
            pnlHeader.Controls.Add(label1);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(585, 90);
            pnlHeader.TabIndex = 8;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppName.ImageAlign = ContentAlignment.MiddleRight;
            lblAppName.Location = new Point(158, 11);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(281, 38);
            lblAppName.TabIndex = 2;
            lblAppName.Text = "Quản lý người dùng";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(94, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(201, 50);
            label1.Name = "label1";
            label1.Size = new Size(234, 28);
            label1.TabIndex = 4;
            label1.Text = "TCP Client - Phiên bản 1.0";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 414);
            Controls.Add(pnlHeader);
            Controls.Add(pnlRegister);
            Name = "SignUpForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng kí";
            pnlRegister.ResumeLayout(false);
            pnlRegister.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlRegister;
        private Button btnSignIn;
        private Button btnCancel;
        private Label lblUsername;
        private Label lblPassword;
        private Button btnOK;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtBoxFullName;
        private TextBox txtBoxEmail;
        private TextBox txtBoxCheckPassword;
        private Label lblFullName;
        private Label lblCheckPassword;
        private Label lblBirthday;
        private Label lblEmail;
        private DateTimePicker BirthdayUser;
        private Panel pnlHeader;
        private Label lblAppName;
        private PictureBox pictureBox1;
        private Label label1;
    }
}