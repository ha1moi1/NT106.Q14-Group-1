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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            BirthdayUser = new DateTimePicker();
            txtBoxFullName = new TextBox();
            txtBoxEmail = new TextBox();
            txtBoxCheckPassword = new TextBox();
            btnCancel = new Button();
            btnOK = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            panel2 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // BirthdayUser
            // 
            BirthdayUser.CustomFormat = "dd-MM-yyyy";
            BirthdayUser.Format = DateTimePickerFormat.Custom;
            BirthdayUser.Location = new Point(313, 328);
            BirthdayUser.Margin = new Padding(5);
            BirthdayUser.MaxDate = new DateTime(2025, 10, 25, 21, 44, 4, 914);
            BirthdayUser.Name = "BirthdayUser";
            BirthdayUser.ShowCheckBox = true;
            BirthdayUser.Size = new Size(404, 39);
            BirthdayUser.TabIndex = 22;
            BirthdayUser.TabStop = false;
            BirthdayUser.Value = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            BirthdayUser.ValueChanged += BirthdayUser_ValueChanged;
            // 
            // txtBoxFullName
            // 
            txtBoxFullName.Location = new Point(313, 100);
            txtBoxFullName.Margin = new Padding(5);
            txtBoxFullName.Multiline = true;
            txtBoxFullName.Name = "txtBoxFullName";
            txtBoxFullName.PasswordChar = '*';
            txtBoxFullName.Size = new Size(404, 40);
            txtBoxFullName.TabIndex = 21;
            txtBoxFullName.UseSystemPasswordChar = true;
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.Location = new Point(313, 250);
            txtBoxEmail.Margin = new Padding(5);
            txtBoxEmail.Multiline = true;
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.PasswordChar = '*';
            txtBoxEmail.Size = new Size(404, 40);
            txtBoxEmail.TabIndex = 19;
            txtBoxEmail.UseSystemPasswordChar = true;
            txtBoxEmail.TextChanged += txtBoxEmail_TextChanged;
            // 
            // txtBoxCheckPassword
            // 
            txtBoxCheckPassword.Location = new Point(313, 476);
            txtBoxCheckPassword.Margin = new Padding(5);
            txtBoxCheckPassword.Multiline = true;
            txtBoxCheckPassword.Name = "txtBoxCheckPassword";
            txtBoxCheckPassword.PasswordChar = '*';
            txtBoxCheckPassword.Size = new Size(404, 39);
            txtBoxCheckPassword.TabIndex = 18;
            txtBoxCheckPassword.UseSystemPasswordChar = true;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderColor = Color.White;
            btnCancel.FlatAppearance.BorderSize = 2;
            btnCancel.Font = new Font("Tahoma", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.Navy;
            btnCancel.Location = new Point(541, 548);
            btnCancel.Margin = new Padding(5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(191, 86);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Hủy bỏ";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOK
            // 
            btnOK.BackColor = Color.White;
            btnOK.DialogResult = DialogResult.OK;
            btnOK.FlatAppearance.BorderSize = 2;
            btnOK.Font = new Font("Tahoma", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOK.ForeColor = Color.Navy;
            btnOK.Location = new Point(285, 548);
            btnOK.Margin = new Padding(5);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(191, 86);
            btnOK.TabIndex = 9;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(313, 173);
            txtUsername.Margin = new Padding(5);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(404, 41);
            txtUsername.TabIndex = 7;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(313, 401);
            txtPassword.Margin = new Padding(5);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(404, 40);
            txtPassword.TabIndex = 8;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnOK);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(txtBoxFullName);
            panel2.Controls.Add(txtBoxCheckPassword);
            panel2.Controls.Add(BirthdayUser);
            panel2.Controls.Add(txtUsername);
            panel2.Controls.Add(txtBoxEmail);
            panel2.Controls.Add(txtPassword);
            panel2.Location = new Point(145, 169);
            panel2.Name = "panel2";
            panel2.Size = new Size(973, 687);
            panel2.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.AliceBlue;
            label7.Location = new Point(44, 479);
            label7.Name = "label7";
            label7.Size = new Size(243, 32);
            label7.TabIndex = 31;
            label7.Text = "Nhập lại mật khẩu : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.AliceBlue;
            label6.Location = new Point(78, 409);
            label6.Name = "label6";
            label6.Size = new Size(209, 32);
            label6.TabIndex = 30;
            label6.Text = "Nhập mật khẩu : ";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.AliceBlue;
            label5.Location = new Point(74, 333);
            label5.Name = "label5";
            label5.Size = new Size(213, 32);
            label5.TabIndex = 29;
            label5.Text = "Nhập ngày sinh : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.AliceBlue;
            label4.Location = new Point(122, 253);
            label4.Name = "label4";
            label4.Size = new Size(165, 32);
            label4.TabIndex = 28;
            label4.Text = "Nhập Email : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.AliceBlue;
            label3.Location = new Point(5, 182);
            label3.Name = "label3";
            label3.Size = new Size(282, 32);
            label3.TabIndex = 27;
            label3.Text = "Nhập tên người dùng : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.AliceBlue;
            label2.Location = new Point(78, 108);
            label2.Name = "label2";
            label2.Size = new Size(209, 32);
            label2.TabIndex = 26;
            label2.Text = "Nhập họ và tên : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(511, 64);
            label1.Name = "label1";
            label1.Size = new Size(285, 86);
            label1.TabIndex = 25;
            label1.Text = "Đăng ký";
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1286, 895);
            Controls.Add(label1);
            Controls.Add(panel2);
            Margin = new Padding(5);
            Name = "SignUpForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng ký";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCancel;
        private Button btnOK;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtBoxFullName;
        private TextBox txtBoxEmail;
        private TextBox txtBoxCheckPassword;
        private DateTimePicker BirthdayUser;
        private Panel panel2;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
    }
}