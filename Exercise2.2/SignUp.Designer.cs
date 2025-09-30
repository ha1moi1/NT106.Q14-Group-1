namespace Monopoly
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            label2 = new Label();
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
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Be Vietnam Pro SemiBold", 15.7090893F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(346, 94);
            label1.Name = "label1";
            label1.Padding = new Padding(20);
            label1.Size = new Size(520, 486);
            label1.TabIndex = 1;
            label1.Text = "ĐĂNG KÝ";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Be Vietnam Pro", 13.090909F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(386, 187);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(452, 33);
            textBox1.TabIndex = 2;
            textBox1.Text = "Tên người dùng";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Be Vietnam Pro", 13.090909F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(386, 257);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(452, 33);
            textBox2.TabIndex = 3;
            textBox2.Text = "Email";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Be Vietnam Pro", 13.090909F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(386, 332);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(452, 33);
            textBox3.TabIndex = 4;
            textBox3.Text = "Mật khẩu";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Be Vietnam Pro", 13.090909F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(386, 410);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(452, 33);
            textBox4.TabIndex = 5;
            textBox4.Text = "Nhập lại mật khẩu";
            // 
            // button1
            // 
            button1.Font = new Font("Be Vietnam Pro", 13.090909F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(541, 480);
            button1.Name = "button1";
            button1.Size = new Size(129, 40);
            button1.TabIndex = 6;
            button1.Text = "Đăng ký";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Be Vietnam Pro", 11.1272726F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(606, 523);
            label2.Name = "label2";
            label2.Size = new Size(152, 26);
            label2.TabIndex = 7;
            label2.Text = "Đã có tài khoản?";
            label2.Click += label2_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Be Vietnam Pro", 11.1272726F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(750, 523);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(103, 26);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Đăng nhập";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 676);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "SignUp";
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
        private TextBox textBox4;
        private Button button1;
        private Label label2;
        private LinkLabel linkLabel1;
    }
}