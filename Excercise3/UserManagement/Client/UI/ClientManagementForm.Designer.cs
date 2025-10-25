namespace LoginSystem.UI
{
    partial class ClientManagementForm
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            lblTitle = new Label();
            btnCloseConnect = new Button();
            btnClose = new Button();
            dataGridView1 = new DataGridView();
            CheckboxColumn = new DataGridViewCheckBoxColumn();
            UserColumn = new DataGridViewTextBoxColumn();
            IPColumn = new DataGridViewTextBoxColumn();
            PortColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(25, 13);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(294, 23);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Danh sách các client đã đăng nhập:";
            lblTitle.Click += lblTitle_Click;
            // 
            // btnCloseConnect
            // 
            btnCloseConnect.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCloseConnect.Location = new Point(194, 260);
            btnCloseConnect.Name = "btnCloseConnect";
            btnCloseConnect.Size = new Size(120, 30);
            btnCloseConnect.TabIndex = 1;
            btnCloseConnect.Text = "Ngắt kết nối";
            btnCloseConnect.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.DialogResult = DialogResult.Cancel;
            btnClose.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(332, 260);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(120, 30);
            btnClose.TabIndex = 2;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.ControlLight;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CheckboxColumn, UserColumn, IPColumn, PortColumn });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.White;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(25, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(420, 200);
            dataGridView1.TabIndex = 3;
            // 
            // CheckboxColumn
            // 
            CheckboxColumn.HeaderText = "";
            CheckboxColumn.MinimumWidth = 6;
            CheckboxColumn.Name = "CheckboxColumn";
            CheckboxColumn.Resizable = DataGridViewTriState.True;
            CheckboxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            CheckboxColumn.Width = 40;
            // 
            // UserColumn
            // 
            UserColumn.HeaderText = "Tên người dùng";
            UserColumn.MinimumWidth = 6;
            UserColumn.Name = "UserColumn";
            UserColumn.Width = 175;
            // 
            // IPColumn
            // 
            IPColumn.HeaderText = "Địa chỉ IP";
            IPColumn.MinimumWidth = 6;
            IPColumn.Name = "IPColumn";
            IPColumn.Width = 125;
            // 
            // PortColumn
            // 
            PortColumn.HeaderText = "Cổng";
            PortColumn.MinimumWidth = 6;
            PortColumn.Name = "PortColumn";
            PortColumn.Width = 80;
            // 
            // ClientManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 307);
            Controls.Add(dataGridView1);
            Controls.Add(btnClose);
            Controls.Add(btnCloseConnect);
            Controls.Add(lblTitle);
            Name = "ClientManagementForm";
            ShowIcon = false;
            Text = "Quản lý Client";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Button btnCloseConnect;
        private Button btnClose;
        private DataGridView dataGridView1;
        private DataGridViewCheckBoxColumn CheckboxColumn;
        private DataGridViewTextBoxColumn UserColumn;
        private DataGridViewTextBoxColumn IPColumn;
        private DataGridViewTextBoxColumn PortColumn;
    }
}