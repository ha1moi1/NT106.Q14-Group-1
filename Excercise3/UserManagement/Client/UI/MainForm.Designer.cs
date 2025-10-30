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
            pnlInfor = new Panel();
            btnSignOut = new Button();
            btnExit = new Button();
            btnChangePassword = new Button();
            label1 = new Label();
            grBoxUserInfo = new GroupBox();
            lblDisplayUsername = new Label();
            lblDisplayBirthday = new Label();
            lblDisplayEmail = new Label();
            lblDisplayFullName = new Label();
            lblUsername = new Label();
            lblBirthday = new Label();
            lblEmail = new Label();
            lblFullName = new Label();
            pnlHeader = new Panel();
            lblAppName = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            pnlInfor.SuspendLayout();
            grBoxUserInfo.SuspendLayout();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlInfor
            // 
            pnlInfor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlInfor.BorderStyle = BorderStyle.FixedSingle;
            pnlInfor.Controls.Add(btnSignOut);
            pnlInfor.Controls.Add(btnExit);
            pnlInfor.Controls.Add(btnChangePassword);
            pnlInfor.Controls.Add(label1);
            pnlInfor.Controls.Add(grBoxUserInfo);
            pnlInfor.Location = new Point(0, 90);
            pnlInfor.Name = "pnlInfor";
            pnlInfor.Size = new Size(588, 318);
            pnlInfor.TabIndex = 3;
            // 
            // btnSignOut
            // 
            btnSignOut.BackColor = SystemColors.ButtonHighlight;
            btnSignOut.FlatAppearance.BorderColor = Color.White;
            btnSignOut.FlatAppearance.BorderSize = 2;
            btnSignOut.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignOut.Location = new Point(209, 265);
            btnSignOut.Name = "btnSignOut";
            btnSignOut.Size = new Size(165, 35);
            btnSignOut.TabIndex = 15;
            btnSignOut.Text = "Đăng xuất...";
            btnSignOut.UseVisualStyleBackColor = false;
            btnSignOut.Click += btnSignOut_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ButtonHighlight;
            btnExit.FlatAppearance.BorderColor = Color.White;
            btnExit.FlatAppearance.BorderSize = 2;
            btnExit.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(384, 265);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(165, 35);
            btnExit.TabIndex = 14;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnChangePassword
            // 
            btnChangePassword.BackColor = SystemColors.ButtonHighlight;
            btnChangePassword.FlatAppearance.BorderColor = Color.White;
            btnChangePassword.FlatAppearance.BorderSize = 2;
            btnChangePassword.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnChangePassword.Location = new Point(34, 265);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(165, 35);
            btnChangePassword.TabIndex = 13;
            btnChangePassword.Text = "Đổi mật khẩu";
            btnChangePassword.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 218);
            label1.Name = "label1";
            label1.Size = new Size(460, 21);
            label1.TabIndex = 1;
            label1.Text = "Sử dụng các tùy chọn bên dưới để quản lý tài khoản của bạn.";
            // 
            // grBoxUserInfo
            // 
            grBoxUserInfo.Controls.Add(lblDisplayUsername);
            grBoxUserInfo.Controls.Add(lblDisplayBirthday);
            grBoxUserInfo.Controls.Add(lblDisplayEmail);
            grBoxUserInfo.Controls.Add(lblDisplayFullName);
            grBoxUserInfo.Controls.Add(lblUsername);
            grBoxUserInfo.Controls.Add(lblBirthday);
            grBoxUserInfo.Controls.Add(lblEmail);
            grBoxUserInfo.Controls.Add(lblFullName);
            grBoxUserInfo.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grBoxUserInfo.Location = new Point(34, 30);
            grBoxUserInfo.Name = "grBoxUserInfo";
            grBoxUserInfo.Size = new Size(525, 168);
            grBoxUserInfo.TabIndex = 0;
            grBoxUserInfo.TabStop = false;
            grBoxUserInfo.Text = "Thông tin người dùng";
            // 
            // lblDisplayUsername
            // 
            lblDisplayUsername.Location = new Point(167, 35);
            lblDisplayUsername.Name = "lblDisplayUsername";
            lblDisplayUsername.Size = new Size(340, 20);
            lblDisplayUsername.TabIndex = 8;
            // 
            // lblDisplayBirthday
            // 
            lblDisplayBirthday.Location = new Point(167, 95);
            lblDisplayBirthday.Name = "lblDisplayBirthday";
            lblDisplayBirthday.Size = new Size(340, 20);
            lblDisplayBirthday.TabIndex = 7;
            // 
            // lblDisplayEmail
            // 
            lblDisplayEmail.Location = new Point(167, 125);
            lblDisplayEmail.Name = "lblDisplayEmail";
            lblDisplayEmail.Size = new Size(340, 20);
            lblDisplayEmail.TabIndex = 6;
            // 
            // lblDisplayFullName
            // 
            lblDisplayFullName.Location = new Point(167, 65);
            lblDisplayFullName.Name = "lblDisplayFullName";
            lblDisplayFullName.Size = new Size(340, 20);
            lblDisplayFullName.TabIndex = 5;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(20, 35);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(131, 21);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "Tên người dùng:";
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBirthday.Location = new Point(20, 95);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(88, 21);
            lblBirthday.TabIndex = 3;
            lblBirthday.Text = "Ngày sinh:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(20, 125);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(57, 21);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFullName.Location = new Point(20, 65);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(87, 21);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Họ và tên:";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = SystemColors.ButtonHighlight;
            pnlHeader.Controls.Add(lblAppName);
            pnlHeader.Controls.Add(pictureBox1);
            pnlHeader.Controls.Add(label2);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(588, 90);
            pnlHeader.TabIndex = 4;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(201, 50);
            label2.Name = "label2";
            label2.Size = new Size(234, 28);
            label2.TabIndex = 4;
            label2.Text = "TCP Client - Phiên bản 1.0";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 409);
            Controls.Add(pnlHeader);
            Controls.Add(pnlInfor);
            Name = "MainForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TCP Client";
            pnlInfor.ResumeLayout(false);
            pnlInfor.PerformLayout();
            grBoxUserInfo.ResumeLayout(false);
            grBoxUserInfo.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlInfor;
        private GroupBox grBoxUserInfo;
        private Label lblFullName;
        private Label lblUsername;
        private Label lblBirthday;
        private Label lblEmail;
        private Label lblDisplayUsername;
        private Label lblDisplayBirthday;
        private Label lblDisplayEmail;
        private Label lblDisplayFullName;
        private Label label1;
        private Button btnSignOut;
        private Button btnExit;
        private Button btnChangePassword;
        private Panel pnlHeader;
        private Label lblAppName;
        private PictureBox pictureBox1;
        private Label label2;
    }
}