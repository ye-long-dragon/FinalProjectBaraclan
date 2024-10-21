namespace FinalProjectBaraclan
{
    partial class dbAllItems
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
            pnlAllItems = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            flpItemView = new FlowLayoutPanel();
            pnlInvoice = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            dgvInvoicing = new Guna.UI2.WinForms.Guna2DataGridView();
            lblnoTotal = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lbltxtGrandTotal = new Guna.UI2.WinForms.Guna2HtmlLabel();
            pnlAllItems.SuspendLayout();
            pnlInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInvoicing).BeginInit();
            SuspendLayout();
            // 
            // pnlAllItems
            // 
            pnlAllItems.Controls.Add(flpItemView);
            pnlAllItems.Controls.Add(pnlInvoice);
            pnlAllItems.CustomizableEdges = customizableEdges3;
            pnlAllItems.Dock = DockStyle.Fill;
            pnlAllItems.Location = new Point(0, 0);
            pnlAllItems.Name = "pnlAllItems";
            pnlAllItems.ShadowDecoration.CustomizableEdges = customizableEdges4;
            pnlAllItems.Size = new Size(1400, 850);
            pnlAllItems.TabIndex = 0;
            // 
            // flpItemView
            // 
            flpItemView.AutoScroll = true;
            flpItemView.Location = new Point(42, 198);
            flpItemView.Name = "flpItemView";
            flpItemView.Size = new Size(821, 616);
            flpItemView.TabIndex = 1;
            // 
            // pnlInvoice
            // 
            pnlInvoice.Controls.Add(dgvInvoicing);
            pnlInvoice.Controls.Add(lblnoTotal);
            pnlInvoice.Controls.Add(lbltxtGrandTotal);
            pnlInvoice.CustomizableEdges = customizableEdges1;
            pnlInvoice.Dock = DockStyle.Right;
            pnlInvoice.FillColor = Color.Blue;
            pnlInvoice.Location = new Point(992, 0);
            pnlInvoice.Name = "pnlInvoice";
            pnlInvoice.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pnlInvoice.Size = new Size(408, 850);
            pnlInvoice.TabIndex = 0;
            // 
            // dgvInvoicing
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvInvoicing.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvInvoicing.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvInvoicing.ColumnHeadersHeight = 4;
            dgvInvoicing.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvInvoicing.DefaultCellStyle = dataGridViewCellStyle3;
            dgvInvoicing.GridColor = Color.FromArgb(231, 229, 255);
            dgvInvoicing.Location = new Point(60, 134);
            dgvInvoicing.Name = "dgvInvoicing";
            dgvInvoicing.RowHeadersVisible = false;
            dgvInvoicing.RowHeadersWidth = 51;
            dgvInvoicing.Size = new Size(300, 680);
            dgvInvoicing.TabIndex = 2;
            dgvInvoicing.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvInvoicing.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvInvoicing.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvInvoicing.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvInvoicing.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvInvoicing.ThemeStyle.BackColor = Color.White;
            dgvInvoicing.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvInvoicing.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvInvoicing.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvInvoicing.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvInvoicing.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvInvoicing.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvInvoicing.ThemeStyle.HeaderStyle.Height = 4;
            dgvInvoicing.ThemeStyle.ReadOnly = false;
            dgvInvoicing.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvInvoicing.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvInvoicing.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvInvoicing.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvInvoicing.ThemeStyle.RowsStyle.Height = 29;
            dgvInvoicing.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvInvoicing.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // lblnoTotal
            // 
            lblnoTotal.BackColor = Color.Transparent;
            lblnoTotal.Location = new Point(193, 74);
            lblnoTotal.Name = "lblnoTotal";
            lblnoTotal.Size = new Size(34, 22);
            lblnoTotal.TabIndex = 1;
            lblnoTotal.Text = "total";
            // 
            // lbltxtGrandTotal
            // 
            lbltxtGrandTotal.BackColor = Color.Transparent;
            lbltxtGrandTotal.Location = new Point(29, 74);
            lbltxtGrandTotal.Name = "lbltxtGrandTotal";
            lbltxtGrandTotal.Size = new Size(84, 22);
            lbltxtGrandTotal.TabIndex = 0;
            lbltxtGrandTotal.Text = "Grand Total:";
            // 
            // dbAllItems
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 850);
            Controls.Add(pnlAllItems);
            FormBorderStyle = FormBorderStyle.None;
            Name = "dbAllItems";
            Text = "FullShop";
            Load += dbAllItems_Load;
            pnlAllItems.ResumeLayout(false);
            pnlInvoice.ResumeLayout(false);
            pnlInvoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInvoicing).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlAllItems;
        private FlowLayoutPanel flpItemView;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlInvoice;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbltxtGrandTotal;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblnoTotal;
        private Guna.UI2.WinForms.Guna2DataGridView dgvInvoicing;
    }
}