namespace Client.UI
{
    partial class SignOutForm
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
            label1 = new Label();
            btnYes = new Button();
            btnNo = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(99, 41);
            label1.Name = "label1";
            label1.Size = new Size(272, 21);
            label1.TabIndex = 0;
            label1.Text = "Bạn có chắc chắn muốn đăng xuất?";
            // 
            // btnYes
            // 
            btnYes.BackColor = SystemColors.ButtonHighlight;
            btnYes.DialogResult = DialogResult.OK;
            btnYes.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnYes.ForeColor = Color.Black;
            btnYes.Location = new Point(125, 82);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(100, 35);
            btnYes.TabIndex = 10;
            btnYes.Text = "Có";
            btnYes.UseVisualStyleBackColor = false;
            btnYes.Click += btnYes_Click;
            // 
            // btnNo
            // 
            btnNo.BackColor = SystemColors.ButtonHighlight;
            btnNo.DialogResult = DialogResult.Cancel;
            btnNo.FlatAppearance.BorderColor = Color.White;
            btnNo.FlatAppearance.BorderSize = 2;
            btnNo.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNo.Location = new Point(238, 82);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(100, 35);
            btnNo.TabIndex = 13;
            btnNo.Text = "Không";
            btnNo.UseVisualStyleBackColor = false;
            btnNo.Click += btnNo_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icon_logout;
            pictureBox1.Location = new Point(28, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // SignOutForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(389, 134);
            Controls.Add(pictureBox1);
            Controls.Add(btnNo);
            Controls.Add(btnYes);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SignOutForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng xuất";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnYes;
        private Button btnNo;
        private PictureBox pictureBox1;
    }
}