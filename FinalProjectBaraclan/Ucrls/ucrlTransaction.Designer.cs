namespace FinalProjectBaraclan.Ucrls
{
    partial class ucrlTransaction
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

        #region Component Designer generated code

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
            guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            btnDownload = new Guna.UI2.WinForms.Guna2Button();
            lblTransactionType = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblTransactionDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2CustomGradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            guna2CustomGradientPanel1.Controls.Add(btnDownload);
            guna2CustomGradientPanel1.Controls.Add(lblTransactionType);
            guna2CustomGradientPanel1.Controls.Add(lblTransactionDate);
            guna2CustomGradientPanel1.CustomizableEdges = customizableEdges3;
            guna2CustomGradientPanel1.Dock = DockStyle.Fill;
            guna2CustomGradientPanel1.FillColor = Color.Crimson;
            guna2CustomGradientPanel1.FillColor4 = Color.Crimson;
            guna2CustomGradientPanel1.Location = new Point(0, 0);
            guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2CustomGradientPanel1.Size = new Size(1300, 150);
            guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // btnDownload
            // 
            btnDownload.AutoRoundedCorners = true;
            btnDownload.BackColor = Color.Transparent;
            btnDownload.BorderRadius = 27;
            btnDownload.CustomizableEdges = customizableEdges1;
            btnDownload.DisabledState.BorderColor = Color.DarkGray;
            btnDownload.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDownload.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDownload.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDownload.Font = new Font("Segoe UI", 9F);
            btnDownload.ForeColor = Color.White;
            btnDownload.Location = new Point(881, 55);
            btnDownload.Name = "btnDownload";
            btnDownload.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnDownload.Size = new Size(382, 56);
            btnDownload.TabIndex = 7;
            btnDownload.Text = "Download Receipt";
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // lblTransactionType
            // 
            lblTransactionType.BackColor = Color.Transparent;
            lblTransactionType.Location = new Point(38, 40);
            lblTransactionType.Name = "lblTransactionType";
            lblTransactionType.Size = new Size(35, 22);
            lblTransactionType.TabIndex = 6;
            lblTransactionType.Text = "User:";
            // 
            // lblTransactionDate
            // 
            lblTransactionDate.BackColor = Color.Transparent;
            lblTransactionDate.Location = new Point(38, 89);
            lblTransactionDate.Name = "lblTransactionDate";
            lblTransactionDate.Size = new Size(35, 22);
            lblTransactionDate.TabIndex = 5;
            lblTransactionDate.Text = "User:";
            // 
            // ucrlTransaction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2CustomGradientPanel1);
            Name = "ucrlTransaction";
            Size = new Size(1300, 150);
            guna2CustomGradientPanel1.ResumeLayout(false);
            guna2CustomGradientPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2Button btnDownload;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTransactionType;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTransactionDate;
    }
}
