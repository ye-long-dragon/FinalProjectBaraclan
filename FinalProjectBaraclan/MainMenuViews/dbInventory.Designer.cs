namespace FinalProjectBaraclan
{
    partial class dbInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dbInventory));
            pnlMain = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            btnAddInventory = new Guna.UI2.WinForms.Guna2Button();
            dgvInventoryView = new Guna.UI2.WinForms.Guna2DataGridView();
            imgAdd = new DataGridViewImageColumn();
            imgDelete = new DataGridViewImageColumn();
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventoryView).BeginInit();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(btnAddInventory);
            pnlMain.Controls.Add(dgvInventoryView);
            pnlMain.CustomizableEdges = customizableEdges3;
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.FillColor4 = Color.DeepPink;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.ShadowDecoration.CustomizableEdges = customizableEdges4;
            pnlMain.Size = new Size(1400, 850);
            pnlMain.TabIndex = 0;
            // 
            // btnAddInventory
            // 
            btnAddInventory.AutoRoundedCorners = true;
            btnAddInventory.BackColor = Color.Transparent;
            btnAddInventory.BorderRadius = 27;
            btnAddInventory.CustomizableEdges = customizableEdges1;
            btnAddInventory.DisabledState.BorderColor = Color.DarkGray;
            btnAddInventory.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddInventory.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddInventory.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddInventory.Font = new Font("Segoe UI", 9F);
            btnAddInventory.ForeColor = Color.White;
            btnAddInventory.Location = new Point(56, 87);
            btnAddInventory.Name = "btnAddInventory";
            btnAddInventory.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAddInventory.Size = new Size(225, 56);
            btnAddInventory.TabIndex = 1;
            btnAddInventory.Text = "Add Item";
            btnAddInventory.Click += btnAddInventory_Click;
            // 
            // dgvInventoryView
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dgvInventoryView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvInventoryView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvInventoryView.ColumnHeadersHeight = 40;
            dgvInventoryView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvInventoryView.Columns.AddRange(new DataGridViewColumn[] { imgAdd, imgDelete });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvInventoryView.DefaultCellStyle = dataGridViewCellStyle3;
            dgvInventoryView.GridColor = Color.FromArgb(231, 229, 255);
            dgvInventoryView.Location = new Point(56, 178);
            dgvInventoryView.Name = "dgvInventoryView";
            dgvInventoryView.RowHeadersVisible = false;
            dgvInventoryView.RowHeadersWidth = 51;
            dgvInventoryView.Size = new Size(1304, 630);
            dgvInventoryView.TabIndex = 0;
            dgvInventoryView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvInventoryView.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvInventoryView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvInventoryView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvInventoryView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvInventoryView.ThemeStyle.BackColor = Color.White;
            dgvInventoryView.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvInventoryView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvInventoryView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvInventoryView.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvInventoryView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvInventoryView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvInventoryView.ThemeStyle.HeaderStyle.Height = 40;
            dgvInventoryView.ThemeStyle.ReadOnly = false;
            dgvInventoryView.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvInventoryView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvInventoryView.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvInventoryView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvInventoryView.ThemeStyle.RowsStyle.Height = 29;
            dgvInventoryView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvInventoryView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvInventoryView.CellClick += dgvInventoryView_CellClick;
            // 
            // imgAdd
            // 
            imgAdd.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            imgAdd.DividerWidth = 50;
            imgAdd.FillWeight = 50F;
            imgAdd.HeaderText = "";
            imgAdd.Image = (Image)resources.GetObject("imgAdd.Image");
            imgAdd.MinimumWidth = 50;
            imgAdd.Name = "imgAdd";
            imgAdd.Width = 50;
            // 
            // imgDelete
            // 
            imgDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            imgDelete.DividerWidth = 50;
            imgDelete.FillWeight = 50F;
            imgDelete.HeaderText = "";
            imgDelete.Image = (Image)resources.GetObject("imgDelete.Image");
            imgDelete.MinimumWidth = 50;
            imgDelete.Name = "imgDelete";
            imgDelete.Width = 50;
            // 
            // dbInventory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 850);
            Controls.Add(pnlMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "dbInventory";
            Text = "dbInventory";
            pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInventoryView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlMain;
        private Guna.UI2.WinForms.Guna2DataGridView dgvInventoryView;
        private Guna.UI2.WinForms.Guna2Button btnAddInventory;
        private DataGridViewImageColumn imgAdd;
        private DataGridViewImageColumn imgDelete;
    }
}