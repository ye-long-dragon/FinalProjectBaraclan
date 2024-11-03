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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dbReservation));
            guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            btnAddRoom = new Guna.UI2.WinForms.Guna2Button();
            dgvRoomView = new Guna.UI2.WinForms.Guna2DataGridView();
            imgAdd = new DataGridViewImageColumn();
            imgDelete = new DataGridViewImageColumn();
            guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoomView).BeginInit();
            SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            guna2CustomGradientPanel1.Controls.Add(guna2TextBox1);
            guna2CustomGradientPanel1.Controls.Add(btnAddRoom);
            guna2CustomGradientPanel1.Controls.Add(dgvRoomView);
            guna2CustomGradientPanel1.CustomizableEdges = customizableEdges11;
            guna2CustomGradientPanel1.Dock = DockStyle.Fill;
            guna2CustomGradientPanel1.FillColor = Color.LawnGreen;
            guna2CustomGradientPanel1.Location = new Point(0, 0);
            guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2CustomGradientPanel1.Size = new Size(1400, 850);
            guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.AutoRoundedCorners = true;
            guna2TextBox1.BackColor = Color.Transparent;
            guna2TextBox1.BorderRadius = 27;
            guna2TextBox1.CustomizableEdges = customizableEdges7;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI", 9F);
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Location = new Point(462, 91);
            guna2TextBox1.Margin = new Padding(3, 4, 3, 4);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PasswordChar = '\0';
            guna2TextBox1.PlaceholderText = "";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2TextBox1.Size = new Size(286, 56);
            guna2TextBox1.TabIndex = 3;
            // 
            // btnAddRoom
            // 
            btnAddRoom.AutoRoundedCorners = true;
            btnAddRoom.BackColor = Color.Transparent;
            btnAddRoom.BorderRadius = 27;
            btnAddRoom.CustomizableEdges = customizableEdges9;
            btnAddRoom.DisabledState.BorderColor = Color.DarkGray;
            btnAddRoom.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddRoom.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddRoom.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddRoom.Font = new Font("Segoe UI", 9F);
            btnAddRoom.ForeColor = Color.White;
            btnAddRoom.Location = new Point(46, 91);
            btnAddRoom.Name = "btnAddRoom";
            btnAddRoom.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnAddRoom.Size = new Size(225, 56);
            btnAddRoom.TabIndex = 2;
            btnAddRoom.Text = "Add Room";
            btnAddRoom.Click += btnAddRoom_Click;
            // 
            // dgvRoomView
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dgvRoomView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvRoomView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvRoomView.ColumnHeadersHeight = 40;
            dgvRoomView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvRoomView.Columns.AddRange(new DataGridViewColumn[] { imgAdd, imgDelete });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvRoomView.DefaultCellStyle = dataGridViewCellStyle6;
            dgvRoomView.GridColor = Color.FromArgb(231, 229, 255);
            dgvRoomView.Location = new Point(46, 208);
            dgvRoomView.Name = "dgvRoomView";
            dgvRoomView.RowHeadersVisible = false;
            dgvRoomView.RowHeadersWidth = 51;
            dgvRoomView.RowTemplate.Height = 50;
            dgvRoomView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvRoomView.Size = new Size(1304, 630);
            dgvRoomView.TabIndex = 1;
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
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Button btnAddRoom;
        private Guna.UI2.WinForms.Guna2DataGridView dgvRoomView;
        private DataGridViewImageColumn imgAdd;
        private DataGridViewImageColumn imgDelete;
    }
}