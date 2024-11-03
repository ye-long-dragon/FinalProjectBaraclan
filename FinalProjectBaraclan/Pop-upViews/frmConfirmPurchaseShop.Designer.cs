namespace FinalProjectBaraclan.MainMenuViews
{
    partial class frmConfirmPurchaseShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfirmPurchaseShop));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlTopBar = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            dgvFinalPurchase = new Guna.UI2.WinForms.Guna2DataGridView();
            lblGrandTotal = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblnoTotal = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblPayment = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtPayment = new Guna.UI2.WinForms.Guna2TextBox();
            btnConfirmTransaction = new Guna.UI2.WinForms.Guna2Button();
            pnlTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFinalPurchase).BeginInit();
            SuspendLayout();
            // 
            // pnlTopBar
            // 
            pnlTopBar.Controls.Add(btnClose);
            pnlTopBar.Controls.Add(guna2ImageButton1);
            pnlTopBar.CustomizableEdges = customizableEdges3;
            pnlTopBar.Dock = DockStyle.Top;
            pnlTopBar.Location = new Point(0, 0);
            pnlTopBar.Name = "pnlTopBar";
            pnlTopBar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            pnlTopBar.Size = new Size(823, 50);
            pnlTopBar.TabIndex = 1;
            pnlTopBar.MouseDown += pnlTopBar_MouseDown;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.None;
            btnClose.BackColor = Color.Transparent;
            btnClose.CheckedState.ImageSize = new Size(64, 64);
            btnClose.HoverState.ImageSize = new Size(64, 64);
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageOffset = new Point(0, 0);
            btnClose.ImageRotate = 0F;
            btnClose.Location = new Point(769, 9);
            btnClose.Name = "btnClose";
            btnClose.PressedState.ImageSize = new Size(64, 64);
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnClose.Size = new Size(42, 38);
            btnClose.TabIndex = 2;
            btnClose.Click += btnClose_Click;
            // 
            // guna2ImageButton1
            // 
            guna2ImageButton1.Anchor = AnchorStyles.None;
            guna2ImageButton1.BackColor = Color.Transparent;
            guna2ImageButton1.CheckedState.ImageSize = new Size(64, 64);
            guna2ImageButton1.HoverState.ImageSize = new Size(64, 64);
            guna2ImageButton1.Image = (Image)resources.GetObject("guna2ImageButton1.Image");
            guna2ImageButton1.ImageOffset = new Point(0, 0);
            guna2ImageButton1.ImageRotate = 0F;
            guna2ImageButton1.Location = new Point(1104, -66);
            guna2ImageButton1.Name = "guna2ImageButton1";
            guna2ImageButton1.PressedState.ImageSize = new Size(64, 64);
            guna2ImageButton1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ImageButton1.Size = new Size(42, 38);
            guna2ImageButton1.TabIndex = 1;
            // 
            // dgvFinalPurchase
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvFinalPurchase.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvFinalPurchase.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvFinalPurchase.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvFinalPurchase.DefaultCellStyle = dataGridViewCellStyle3;
            dgvFinalPurchase.GridColor = Color.FromArgb(231, 229, 255);
            dgvFinalPurchase.Location = new Point(12, 111);
            dgvFinalPurchase.Name = "dgvFinalPurchase";
            dgvFinalPurchase.ReadOnly = true;
            dgvFinalPurchase.RowHeadersVisible = false;
            dgvFinalPurchase.RowHeadersWidth = 51;
            dgvFinalPurchase.Size = new Size(799, 235);
            dgvFinalPurchase.TabIndex = 2;
            dgvFinalPurchase.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvFinalPurchase.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvFinalPurchase.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvFinalPurchase.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvFinalPurchase.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvFinalPurchase.ThemeStyle.BackColor = Color.White;
            dgvFinalPurchase.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvFinalPurchase.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvFinalPurchase.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvFinalPurchase.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvFinalPurchase.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvFinalPurchase.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvFinalPurchase.ThemeStyle.HeaderStyle.Height = 40;
            dgvFinalPurchase.ThemeStyle.ReadOnly = true;
            dgvFinalPurchase.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvFinalPurchase.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvFinalPurchase.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvFinalPurchase.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvFinalPurchase.ThemeStyle.RowsStyle.Height = 29;
            dgvFinalPurchase.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvFinalPurchase.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // lblGrandTotal
            // 
            lblGrandTotal.BackColor = Color.Transparent;
            lblGrandTotal.Location = new Point(41, 69);
            lblGrandTotal.Name = "lblGrandTotal";
            lblGrandTotal.Size = new Size(84, 22);
            lblGrandTotal.TabIndex = 3;
            lblGrandTotal.Text = "Grand Total:";
            // 
            // lblnoTotal
            // 
            lblnoTotal.BackColor = Color.Transparent;
            lblnoTotal.Location = new Point(135, 71);
            lblnoTotal.Name = "lblnoTotal";
            lblnoTotal.Size = new Size(34, 22);
            lblnoTotal.TabIndex = 4;
            lblnoTotal.Text = "total";
            // 
            // lblPayment
            // 
            lblPayment.BackColor = Color.Transparent;
            lblPayment.Location = new Point(41, 387);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new Size(63, 22);
            lblPayment.TabIndex = 5;
            lblPayment.Text = "Payment:";
            // 
            // txtPayment
            // 
            txtPayment.AutoRoundedCorners = true;
            txtPayment.BackColor = Color.Transparent;
            txtPayment.BorderRadius = 22;
            txtPayment.CustomizableEdges = customizableEdges5;
            txtPayment.DefaultText = "";
            txtPayment.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPayment.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPayment.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPayment.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPayment.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPayment.Font = new Font("Segoe UI", 9F);
            txtPayment.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPayment.Location = new Point(129, 376);
            txtPayment.Margin = new Padding(3, 4, 3, 4);
            txtPayment.Name = "txtPayment";
            txtPayment.PasswordChar = '\0';
            txtPayment.PlaceholderText = "";
            txtPayment.SelectedText = "";
            txtPayment.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtPayment.Size = new Size(286, 47);
            txtPayment.TabIndex = 6;
            // 
            // btnConfirmTransaction
            // 
            btnConfirmTransaction.AutoRoundedCorners = true;
            btnConfirmTransaction.BackColor = Color.Transparent;
            btnConfirmTransaction.BorderRadius = 22;
            btnConfirmTransaction.CustomizableEdges = customizableEdges7;
            btnConfirmTransaction.DisabledState.BorderColor = Color.DarkGray;
            btnConfirmTransaction.DisabledState.CustomBorderColor = Color.DarkGray;
            btnConfirmTransaction.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnConfirmTransaction.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnConfirmTransaction.Font = new Font("Segoe UI", 9F);
            btnConfirmTransaction.ForeColor = Color.White;
            btnConfirmTransaction.Location = new Point(548, 376);
            btnConfirmTransaction.Name = "btnConfirmTransaction";
            btnConfirmTransaction.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnConfirmTransaction.Size = new Size(225, 47);
            btnConfirmTransaction.TabIndex = 7;
            btnConfirmTransaction.Text = "Confirm Transaction";
            btnConfirmTransaction.Click += btnConfirmTransaction_Click;
            // 
            // frmConfirmPurchaseShop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 473);
            Controls.Add(btnConfirmTransaction);
            Controls.Add(txtPayment);
            Controls.Add(lblPayment);
            Controls.Add(lblnoTotal);
            Controls.Add(lblGrandTotal);
            Controls.Add(dgvFinalPurchase);
            Controls.Add(pnlTopBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmConfirmPurchaseShop";
            Text = "frmConfirmPurchaseShop";
            pnlTopBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFinalPurchase).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlTopBar;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2ImageButton btnClose;
        private Guna.UI2.WinForms.Guna2DataGridView dgvFinalPurchase;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblGrandTotal;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblnoTotal;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPayment;
        private Guna.UI2.WinForms.Guna2TextBox txtPayment;
        private Guna.UI2.WinForms.Guna2Button btnConfirmTransaction;
    }
}