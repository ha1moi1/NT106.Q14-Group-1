
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
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1262, 676);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            pictureBox1.Paint += pictureBox1_Paint;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11F);
            textBox1.Location = new Point(387, 240);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(452, 30);
            textBox1.TabIndex = 3;
            textBox1.Text = "Tên đăng nhập";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Be Vietnam Pro Medium", 15.7090893F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(348, 109);
            label1.Margin = new Padding(3);
            label1.Name = "label1";
            label1.Padding = new Padding(20);
            label1.Size = new Size(520, 397);
            label1.TabIndex = 2;
            label1.Text = "ĐĂNG NHẬP";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Be Vietnam Pro", 13.7454529F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(381, 205);
            label3.Name = "label3";
            label3.Size = new Size(167, 32);
            label3.TabIndex = 5;
            label3.Text = "Tên đăng nhập";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Be Vietnam Pro", 13.7454529F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(382, 289);
            label2.Name = "label2";
            label2.Size = new Size(110, 32);
            label2.TabIndex = 7;
            label2.Text = "Mật khẩu";
            label2.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 11F);
            textBox2.Location = new Point(387, 324);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(452, 30);
            textBox2.TabIndex = 6;
            textBox2.Text = "Mật khẩu";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Be Vietnam Pro", 13.090909F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(550, 396);
            button1.Name = "button1";
            button1.Size = new Size(129, 40);
            button1.TabIndex = 8;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Be Vietnam Pro", 11.1272726F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(600, 453);
            label4.Name = "label4";
            label4.Size = new Size(172, 26);
            label4.TabIndex = 10;
            label4.Text = "Chưa có tài khoản?";
            label4.Click += label4_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Be Vietnam Pro", 11.1272726F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(765, 453);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(80, 26);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Đăng ký";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // SignIn
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 676);
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label3);
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
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private Button button1;
        private Label label4;
        private LinkLabel linkLabel1;
    }
}
