namespace Monopoly
{
    partial class AfterSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AfterSignUp));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(0, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1893, 1007);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Be Vietnam Pro Black", 16.875F, FontStyle.Bold);
            label1.Location = new Point(730, 199);
            label1.Name = "label1";
            label1.Size = new Size(457, 574);
            label1.TabIndex = 1;
            label1.Text = "CỜ TỶ PHÚ";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Be Vietnam Pro Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(820, 371);
            button1.Name = "button1";
            button1.Size = new Size(262, 90);
            button1.TabIndex = 2;
            button1.Text = "Cá nhân";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Be Vietnam Pro Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(820, 532);
            button2.Name = "button2";
            button2.Size = new Size(262, 90);
            button2.TabIndex = 3;
            button2.Text = "Đồng đội";
            button2.UseVisualStyleBackColor = true;
            // 
            // AfterSignUp
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1894, 1009);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "AfterSignUp";
            Text = "AfterSignUp";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}