namespace FinalProjectBaraclan.MainMenuViews
{
    partial class dbUserCatalog
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dbUserCatalog));
            guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            btnAddUser = new Guna.UI2.WinForms.Guna2Button();
            dgvUsersView = new Guna.UI2.WinForms.Guna2DataGridView();
            imgAdd = new DataGridViewImageColumn();
            imgDelete = new DataGridViewImageColumn();
            guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsersView).BeginInit();
            SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            guna2CustomGradientPanel1.Controls.Add(btnAddUser);
            guna2CustomGradientPanel1.Controls.Add(dgvUsersView);
            guna2CustomGradientPanel1.CustomizableEdges = customizableEdges3;
            guna2CustomGradientPanel1.Dock = DockStyle.Fill;
            guna2CustomGradientPanel1.Location = new Point(0, 0);
            guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2CustomGradientPanel1.Size = new Size(1400, 850);
            guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // btnAddUser
            // 
            btnAddUser.AutoRoundedCorners = true;
            btnAddUser.BorderRadius = 27;
            btnAddUser.CustomizableEdges = customizableEdges1;
            btnAddUser.DisabledState.BorderColor = Color.DarkGray;
            btnAddUser.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddUser.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddUser.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddUser.Font = new Font("Segoe UI", 9F);
            btnAddUser.ForeColor = Color.White;
            btnAddUser.Location = new Point(48, 33);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAddUser.Size = new Size(225, 56);
            btnAddUser.TabIndex = 2;
            btnAddUser.Text = "Add User";
            btnAddUser.Click += btnAddUser_Click;
            // 
            // dgvUsersView
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dgvUsersView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvUsersView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvUsersView.ColumnHeadersHeight = 40;
            dgvUsersView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvUsersView.Columns.AddRange(new DataGridViewColumn[] { imgAdd, imgDelete });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvUsersView.DefaultCellStyle = dataGridViewCellStyle3;
            dgvUsersView.GridColor = Color.FromArgb(231, 229, 255);
            dgvUsersView.Location = new Point(48, 110);
            dgvUsersView.Name = "dgvUsersView";
            dgvUsersView.RowHeadersVisible = false;
            dgvUsersView.RowHeadersWidth = 51;
            dgvUsersView.RowTemplate.Height = 50;
            dgvUsersView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvUsersView.Size = new Size(1304, 630);
            dgvUsersView.TabIndex = 1;
            dgvUsersView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvUsersView.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvUsersView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvUsersView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvUsersView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvUsersView.ThemeStyle.BackColor = Color.White;
            dgvUsersView.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvUsersView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvUsersView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvUsersView.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvUsersView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvUsersView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvUsersView.ThemeStyle.HeaderStyle.Height = 40;
            dgvUsersView.ThemeStyle.ReadOnly = false;
            dgvUsersView.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvUsersView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUsersView.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvUsersView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvUsersView.ThemeStyle.RowsStyle.Height = 50;
            dgvUsersView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvUsersView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvUsersView.CellClick += dgvUsersView_CellClick;
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
            // dbUserCatalog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 850);
            Controls.Add(guna2CustomGradientPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "dbUserCatalog";
            Text = "dbUserCatalog";
            guna2CustomGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsersView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvUsersView;
        private DataGridViewImageColumn imgAdd;
        private DataGridViewImageColumn imgDelete;
        private Guna.UI2.WinForms.Guna2Button btnAddUser;
    }
}