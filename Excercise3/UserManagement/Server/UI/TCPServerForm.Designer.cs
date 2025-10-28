namespace Server
{
    partial class TCPServerForm
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
            pnlInfor = new Panel();
            btnViewDetails = new Button();
            lblInfor = new Label();
            grpBoxActivityLog = new GroupBox();
            lstBoxDiaryLog = new ListBox();
            grpBoxTCPServer = new GroupBox();
            btnCloseConnect = new Button();
            btnOpenConnect = new Button();
            txtBoxStatus = new TextBox();
            txtBoxPort = new TextBox();
            txtBoxConnects = new TextBox();
            txtBoxIP = new TextBox();
            lblConnects = new Label();
            lblPort = new Label();
            lblStatus = new Label();
            lblIP = new Label();
            pnlHeader = new Panel();
            lblAppName = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pnlInfor.SuspendLayout();
            grpBoxActivityLog.SuspendLayout();
            grpBoxTCPServer.SuspendLayout();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlInfor
            // 
            pnlInfor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlInfor.BackColor = SystemColors.ButtonFace;
            pnlInfor.Controls.Add(btnViewDetails);
            pnlInfor.Controls.Add(lblInfor);
            pnlInfor.Controls.Add(grpBoxActivityLog);
            pnlInfor.Controls.Add(grpBoxTCPServer);
            pnlInfor.Location = new Point(0, 90);
            pnlInfor.Name = "pnlInfor";
            pnlInfor.Size = new Size(787, 543);
            pnlInfor.TabIndex = 1;
            // 
            // btnViewDetails
            // 
            btnViewDetails.FlatAppearance.BorderColor = Color.White;
            btnViewDetails.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnViewDetails.Location = new Point(621, 496);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Size = new Size(130, 30);
            btnViewDetails.TabIndex = 9;
            btnViewDetails.Text = "Xem chi tiết...";
            btnViewDetails.UseVisualStyleBackColor = true;
            btnViewDetails.Click += btnViewDetails_Click;
            // 
            // lblInfor
            // 
            lblInfor.AutoSize = true;
            lblInfor.Font = new Font("Tahoma", 10.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblInfor.ForeColor = Color.Blue;
            lblInfor.Location = new Point(57, 501);
            lblInfor.Name = "lblInfor";
            lblInfor.Size = new Size(417, 21);
            lblInfor.TabIndex = 2;
            lblInfor.Text = "Hiển thị và quản lí các client đang kết nối và hoạt động";
            lblInfor.Click += lblInfor_Click;
            // 
            // grpBoxActivityLog
            // 
            grpBoxActivityLog.Controls.Add(lstBoxDiaryLog);
            grpBoxActivityLog.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpBoxActivityLog.Location = new Point(29, 164);
            grpBoxActivityLog.Name = "grpBoxActivityLog";
            grpBoxActivityLog.Size = new Size(722, 324);
            grpBoxActivityLog.TabIndex = 1;
            grpBoxActivityLog.TabStop = false;
            grpBoxActivityLog.Text = "Nhật ký hoạt động";
            // 
            // lstBoxDiaryLog
            // 
            lstBoxDiaryLog.FormattingEnabled = true;
            lstBoxDiaryLog.ItemHeight = 21;
            lstBoxDiaryLog.Location = new Point(18, 30);
            lstBoxDiaryLog.Name = "lstBoxDiaryLog";
            lstBoxDiaryLog.Size = new Size(688, 277);
            lstBoxDiaryLog.TabIndex = 0;
            // 
            // grpBoxTCPServer
            // 
            grpBoxTCPServer.Controls.Add(btnCloseConnect);
            grpBoxTCPServer.Controls.Add(btnOpenConnect);
            grpBoxTCPServer.Controls.Add(txtBoxStatus);
            grpBoxTCPServer.Controls.Add(txtBoxPort);
            grpBoxTCPServer.Controls.Add(txtBoxConnects);
            grpBoxTCPServer.Controls.Add(txtBoxIP);
            grpBoxTCPServer.Controls.Add(lblConnects);
            grpBoxTCPServer.Controls.Add(lblPort);
            grpBoxTCPServer.Controls.Add(lblStatus);
            grpBoxTCPServer.Controls.Add(lblIP);
            grpBoxTCPServer.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpBoxTCPServer.Location = new Point(29, 25);
            grpBoxTCPServer.Name = "grpBoxTCPServer";
            grpBoxTCPServer.Size = new Size(722, 120);
            grpBoxTCPServer.TabIndex = 0;
            grpBoxTCPServer.TabStop = false;
            grpBoxTCPServer.Text = "TCP Server";
            // 
            // btnCloseConnect
            // 
            btnCloseConnect.FlatAppearance.BorderColor = Color.White;
            btnCloseConnect.Location = new Point(581, 69);
            btnCloseConnect.Name = "btnCloseConnect";
            btnCloseConnect.Size = new Size(120, 30);
            btnCloseConnect.TabIndex = 9;
            btnCloseConnect.Text = "Đóng kết nối";
            btnCloseConnect.UseVisualStyleBackColor = true;
            btnCloseConnect.Click += btnCloseConnect_Click;
            // 
            // btnOpenConnect
            // 
            btnOpenConnect.FlatAppearance.BorderColor = Color.White;
            btnOpenConnect.Location = new Point(581, 32);
            btnOpenConnect.Name = "btnOpenConnect";
            btnOpenConnect.Size = new Size(120, 30);
            btnOpenConnect.TabIndex = 8;
            btnOpenConnect.Text = "Mở kết nối";
            btnOpenConnect.TextAlign = ContentAlignment.BottomCenter;
            btnOpenConnect.UseVisualStyleBackColor = true;
            btnOpenConnect.Click += btnOpenConnect_Click;
            // 
            // txtBoxStatus
            // 
            txtBoxStatus.BackColor = SystemColors.ControlLight;
            txtBoxStatus.Location = new Point(124, 69);
            txtBoxStatus.Name = "txtBoxStatus";
            txtBoxStatus.ReadOnly = true;
            txtBoxStatus.Size = new Size(181, 28);
            txtBoxStatus.TabIndex = 7;
            // 
            // txtBoxPort
            // 
            txtBoxPort.Location = new Point(424, 32);
            txtBoxPort.Name = "txtBoxPort";
            txtBoxPort.Size = new Size(125, 28);
            txtBoxPort.TabIndex = 6;
            // 
            // txtBoxConnects
            // 
            txtBoxConnects.BackColor = SystemColors.ControlLight;
            txtBoxConnects.Location = new Point(424, 69);
            txtBoxConnects.Name = "txtBoxConnects";
            txtBoxConnects.ReadOnly = true;
            txtBoxConnects.Size = new Size(125, 28);
            txtBoxConnects.TabIndex = 5;
            // 
            // txtBoxIP
            // 
            txtBoxIP.Location = new Point(124, 32);
            txtBoxIP.Name = "txtBoxIP";
            txtBoxIP.Size = new Size(181, 28);
            txtBoxIP.TabIndex = 4;
            // 
            // lblConnects
            // 
            lblConnects.AutoSize = true;
            lblConnects.Location = new Point(325, 69);
            lblConnects.Name = "lblConnects";
            lblConnects.Size = new Size(88, 21);
            lblConnects.TabIndex = 3;
            lblConnects.Text = "SL kết nối:";
            // 
            // lblPort
            // 
            lblPort.AutoSize = true;
            lblPort.Location = new Point(325, 32);
            lblPort.Name = "lblPort";
            lblPort.Size = new Size(53, 21);
            lblPort.TabIndex = 2;
            lblPort.Text = "Cổng:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(13, 69);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(92, 21);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Trạng thái:";
            // 
            // lblIP
            // 
            lblIP.AutoSize = true;
            lblIP.Location = new Point(13, 32);
            lblIP.Name = "lblIP";
            lblIP.Size = new Size(31, 21);
            lblIP.TabIndex = 0;
            lblIP.Text = "IP:";
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
            pnlHeader.Size = new Size(787, 90);
            pnlHeader.TabIndex = 2;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppName.ImageAlign = ContentAlignment.MiddleRight;
            lblAppName.Location = new Point(254, 11);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(281, 38);
            lblAppName.TabIndex = 2;
            lblAppName.Text = "Quản lý người dùng";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(191, 13);
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
            label1.Location = new Point(288, 50);
            label1.Name = "label1";
            label1.Size = new Size(239, 28);
            label1.TabIndex = 4;
            label1.Text = "TCP Server - Phiên bản 1.0";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TCPServerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 632);
            Controls.Add(pnlHeader);
            Controls.Add(pnlInfor);
            Name = "TCPServerForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Server";
            pnlInfor.ResumeLayout(false);
            pnlInfor.PerformLayout();
            grpBoxActivityLog.ResumeLayout(false);
            grpBoxTCPServer.ResumeLayout(false);
            grpBoxTCPServer.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlInfor;
        private GroupBox grpBoxTCPServer;
        private GroupBox grpBoxActivityLog;
        private Label lblIP;
        private Label lblConnects;
        private Label lblPort;
        private Label lblStatus;
        private Button btnCloseConnect;
        private Button btnOpenConnect;
        private TextBox txtBoxStatus;
        private TextBox txtBoxPort;
        private TextBox txtBoxConnects;
        private TextBox txtBoxIP;
        private Label lblInfor;
        private ListBox lstBoxDiaryLog;
        private Button btnViewDetails;
        private Panel pnlHeader;
        private Label lblAppName;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
