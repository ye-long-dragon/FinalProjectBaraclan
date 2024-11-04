namespace FinalProjectBaraclan
{
    partial class dbReservation
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dbReservation));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            dgvRoomView = new Guna.UI2.WinForms.Guna2DataGridView();
            dataGridViewImageColumn1 = new DataGridViewImageColumn();
            dataGridViewImageColumn2 = new DataGridViewImageColumn();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            btnAddRoom = new Guna.UI2.WinForms.Guna2Button();
            dgvRoomHistoryView = new Guna.UI2.WinForms.Guna2DataGridView();
            imgAdd = new DataGridViewImageColumn();
            imgDelete = new DataGridViewImageColumn();
            btnReservation = new Guna.UI2.WinForms.Guna2Button();
            guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoomView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRoomHistoryView).BeginInit();
            SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            guna2CustomGradientPanel1.Controls.Add(btnReservation);
            guna2CustomGradientPanel1.Controls.Add(dgvRoomView);
            guna2CustomGradientPanel1.Controls.Add(guna2TextBox1);
            guna2CustomGradientPanel1.Controls.Add(btnAddRoom);
            guna2CustomGradientPanel1.Controls.Add(dgvRoomHistoryView);
            guna2CustomGradientPanel1.CustomizableEdges = customizableEdges7;
            guna2CustomGradientPanel1.Dock = DockStyle.Fill;
            guna2CustomGradientPanel1.FillColor = Color.LawnGreen;
            guna2CustomGradientPanel1.Location = new Point(0, 0);
            guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2CustomGradientPanel1.Size = new Size(1400, 850);
            guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // dgvRoomView
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dgvRoomView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvRoomView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvRoomView.ColumnHeadersHeight = 40;
            dgvRoomView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvRoomView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewImageColumn1, dataGridViewImageColumn2 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvRoomView.DefaultCellStyle = dataGridViewCellStyle3;
            dgvRoomView.GridColor = Color.FromArgb(231, 229, 255);
            dgvRoomView.Location = new Point(46, 153);
            dgvRoomView.Name = "dgvRoomView";
            dgvRoomView.RowHeadersVisible = false;
            dgvRoomView.RowHeadersWidth = 51;
            dgvRoomView.RowTemplate.Height = 50;
            dgvRoomView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvRoomView.Size = new Size(1304, 205);
            dgvRoomView.TabIndex = 4;
            dgvRoomView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvRoomView.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvRoomView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvRoomView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvRoomView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvRoomView.ThemeStyle.BackColor = Color.White;
            dgvRoomView.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvRoomView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvRoomView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvRoomView.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvRoomView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvRoomView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvRoomView.ThemeStyle.HeaderStyle.Height = 40;
            dgvRoomView.ThemeStyle.ReadOnly = false;
            dgvRoomView.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvRoomView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRoomView.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvRoomView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvRoomView.ThemeStyle.RowsStyle.Height = 50;
            dgvRoomView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvRoomView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewImageColumn1.FillWeight = 50F;
            dataGridViewImageColumn1.HeaderText = "";
            dataGridViewImageColumn1.Image = (Image)resources.GetObject("dataGridViewImageColumn1.Image");
            dataGridViewImageColumn1.MinimumWidth = 50;
            dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            dataGridViewImageColumn1.Resizable = DataGridViewTriState.False;
            // 
            // dataGridViewImageColumn2
            // 
            dataGridViewImageColumn2.FillWeight = 50F;
            dataGridViewImageColumn2.HeaderText = "";
            dataGridViewImageColumn2.Image = (Image)resources.GetObject("dataGridViewImageColumn2.Image");
            dataGridViewImageColumn2.MinimumWidth = 50;
            dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.AutoRoundedCorners = true;
            guna2TextBox1.BackColor = Color.Transparent;
            guna2TextBox1.BorderRadius = 27;
            guna2TextBox1.CustomizableEdges = customizableEdges3;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI", 9F);
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Location = new Point(290, 32);
            guna2TextBox1.Margin = new Padding(3, 4, 3, 4);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PasswordChar = '\0';
            guna2TextBox1.PlaceholderText = "";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2TextBox1.Size = new Size(286, 56);
            guna2TextBox1.TabIndex = 3;
            // 
            // btnAddRoom
            // 
            btnAddRoom.AutoRoundedCorners = true;
            btnAddRoom.BackColor = Color.Transparent;
            btnAddRoom.BorderRadius = 27;
            btnAddRoom.CustomizableEdges = customizableEdges5;
            btnAddRoom.DisabledState.BorderColor = Color.DarkGray;
            btnAddRoom.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddRoom.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddRoom.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddRoom.Font = new Font("Segoe UI", 9F);
            btnAddRoom.ForeColor = Color.White;
            btnAddRoom.Location = new Point(663, 32);
            btnAddRoom.Name = "btnAddRoom";
            btnAddRoom.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnAddRoom.Size = new Size(225, 56);
            btnAddRoom.TabIndex = 2;
            btnAddRoom.Text = "Add Room";
            btnAddRoom.Click += btnAddRoom_Click;
            // 
            // dgvRoomHistoryView
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dgvRoomHistoryView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvRoomHistoryView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvRoomHistoryView.ColumnHeadersHeight = 40;
            dgvRoomHistoryView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvRoomHistoryView.Columns.AddRange(new DataGridViewColumn[] { imgAdd, imgDelete });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvRoomHistoryView.DefaultCellStyle = dataGridViewCellStyle6;
            dgvRoomHistoryView.GridColor = Color.FromArgb(231, 229, 255);
            dgvRoomHistoryView.Location = new Point(46, 394);
            dgvRoomHistoryView.Name = "dgvRoomHistoryView";
            dgvRoomHistoryView.RowHeadersVisible = false;
            dgvRoomHistoryView.RowHeadersWidth = 51;
            dgvRoomHistoryView.RowTemplate.Height = 50;
            dgvRoomHistoryView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvRoomHistoryView.Size = new Size(1304, 444);
            dgvRoomHistoryView.TabIndex = 1;
            dgvRoomHistoryView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvRoomHistoryView.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvRoomHistoryView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvRoomHistoryView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvRoomHistoryView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvRoomHistoryView.ThemeStyle.BackColor = Color.White;
            dgvRoomHistoryView.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvRoomHistoryView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvRoomHistoryView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvRoomHistoryView.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvRoomHistoryView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvRoomHistoryView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvRoomHistoryView.ThemeStyle.HeaderStyle.Height = 40;
            dgvRoomHistoryView.ThemeStyle.ReadOnly = false;
            dgvRoomHistoryView.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvRoomHistoryView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRoomHistoryView.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvRoomHistoryView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvRoomHistoryView.ThemeStyle.RowsStyle.Height = 50;
            dgvRoomHistoryView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvRoomHistoryView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // imgAdd
            // 
            imgAdd.FillWeight = 50F;
            imgAdd.HeaderText = "";
            imgAdd.Image = (Image)resources.GetObject("imgAdd.Image");
            imgAdd.MinimumWidth = 50;
            imgAdd.Name = "imgAdd";
            imgAdd.Resizable = DataGridViewTriState.False;
            // 
            // imgDelete
            // 
            imgDelete.FillWeight = 50F;
            imgDelete.HeaderText = "";
            imgDelete.Image = (Image)resources.GetObject("imgDelete.Image");
            imgDelete.MinimumWidth = 50;
            imgDelete.Name = "imgDelete";
            // 
            // btnReservation
            // 
            btnReservation.AutoRoundedCorners = true;
            btnReservation.BackColor = Color.Transparent;
            btnReservation.BorderRadius = 27;
            btnReservation.CustomizableEdges = customizableEdges1;
            btnReservation.DisabledState.BorderColor = Color.DarkGray;
            btnReservation.DisabledState.CustomBorderColor = Color.DarkGray;
            btnReservation.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnReservation.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnReservation.Font = new Font("Segoe UI", 9F);
            btnReservation.ForeColor = Color.White;
            btnReservation.Location = new Point(46, 32);
            btnReservation.Name = "btnReservation";
            btnReservation.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnReservation.Size = new Size(225, 56);
            btnReservation.TabIndex = 5;
            btnReservation.Text = "Add Reservation";
            btnReservation.Click += btnReservation_Click;
            // 
            // dbReservation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 850);
            Controls.Add(guna2CustomGradientPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "dbReservation";
            Text = "dbReservation";
            guna2CustomGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRoomView).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRoomHistoryView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Button btnAddRoom;
        private Guna.UI2.WinForms.Guna2DataGridView dgvRoomHistoryView;
        private DataGridViewImageColumn imgAdd;
        private DataGridViewImageColumn imgDelete;
        private Guna.UI2.WinForms.Guna2DataGridView dgvRoomView;
        private DataGridViewImageColumn dataGridViewImageColumn1;
        private DataGridViewImageColumn dataGridViewImageColumn2;
        private Guna.UI2.WinForms.Guna2Button btnReservation;
    }
}