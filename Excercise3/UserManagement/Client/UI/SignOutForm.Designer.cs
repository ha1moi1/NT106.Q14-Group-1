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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignOutForm));
            btnYes = new Button();
            btnNo = new Button();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnYes
            // 
            btnYes.BackColor = Color.White;
            btnYes.DialogResult = DialogResult.OK;
            btnYes.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnYes.ForeColor = Color.Navy;
            btnYes.Location = new Point(221, 287);
            btnYes.Margin = new Padding(5);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(162, 74);
            btnYes.TabIndex = 10;
            btnYes.Text = "Có";
            btnYes.UseVisualStyleBackColor = false;
            btnYes.Click += btnYes_Click;
            // 
            // btnNo
            // 
            btnNo.BackColor = Color.White;
            btnNo.DialogResult = DialogResult.Cancel;
            btnNo.FlatAppearance.BorderColor = Color.White;
            btnNo.FlatAppearance.BorderSize = 2;
            btnNo.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNo.ForeColor = Color.Navy;
            btnNo.Location = new Point(410, 190);
            btnNo.Margin = new Padding(5);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(162, 74);
            btnNo.TabIndex = 13;
            btnNo.Text = "Không";
            btnNo.UseVisualStyleBackColor = false;
            btnNo.Click += btnNo_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-169, 217);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(0, 0);
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SkyBlue;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnNo);
            panel1.Location = new Point(118, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(676, 296);
            panel1.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.GhostWhite;
            label1.Location = new Point(60, 81);
            label1.Name = "label1";
            label1.Size = new Size(558, 45);
            label1.TabIndex = 14;
            label1.Text = "Bạn có chắc chắn muốn đăng xuất ?";
            // 
            // SignOutForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(909, 472);
            Controls.Add(btnYes);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Margin = new Padding(5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SignOutForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng xuất";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private Button btnYes;
        private Button btnNo;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label1;
    }
}