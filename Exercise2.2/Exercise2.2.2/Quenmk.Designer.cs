namespace Monopoly
{
    partial class Quenmk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quenmk));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1892, 1010);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Be Vietnam Pro Black", 13.1249981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(480, 226);
            label1.Name = "label1";
            label1.Size = new Size(819, 503);
            label1.TabIndex = 1;
            label1.Text = "QUÊN MẬT KHẨU";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            textBox1.ForeColor = Color.Silver;
            textBox1.Location = new Point(645, 344);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(500, 39);
            textBox1.TabIndex = 2;
            textBox1.Text = "Nhập địa chỉ Email";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.ForeColor = Color.DarkGray;
            textBox2.Location = new Point(645, 457);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(500, 39);
            textBox2.TabIndex = 3;
            textBox2.Text = "Nhập mật khẩu mới";
            // 
            // textBox3
            // 
            textBox3.ForeColor = Color.DarkGray;
            textBox3.Location = new Point(645, 560);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(500, 39);
            textBox3.TabIndex = 4;
            textBox3.Text = "Nhập lại mật khẩu";
            // 
            // button1
            // 
            button1.Font = new Font("Be Vietnam Pro Black", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(804, 639);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 5;
            button1.Text = "Tiếp tục";
            button1.UseVisualStyleBackColor = true;
            // 
            // AfterSignUp
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1894, 1009);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "AfterSignUp";
            Text = "AfterSignUp";
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
        private Button button1;
    }
}