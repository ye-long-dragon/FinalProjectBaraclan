namespace FinalProjectBaraclan
{
    partial class dbTransactionHistory
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
            guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            lblTransaction = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblInputUserId = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblUserId = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblInputName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblUser = new Guna.UI2.WinForms.Guna2HtmlLabel();
            flpReceiptList = new FlowLayoutPanel();
            guna2CustomGradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            guna2CustomGradientPanel1.Controls.Add(lblTransaction);
            guna2CustomGradientPanel1.Controls.Add(lblInputUserId);
            guna2CustomGradientPanel1.Controls.Add(lblUserId);
            guna2CustomGradientPanel1.Controls.Add(lblInputName);
            guna2CustomGradientPanel1.Controls.Add(lblUser);
            guna2CustomGradientPanel1.Controls.Add(flpReceiptList);
            guna2CustomGradientPanel1.CustomizableEdges = customizableEdges3;
            guna2CustomGradientPanel1.Dock = DockStyle.Fill;
            guna2CustomGradientPanel1.FillColor4 = Color.Aqua;
            guna2CustomGradientPanel1.Location = new Point(0, 0);
            guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2CustomGradientPanel1.Size = new Size(1400, 850);
            guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // lblTransaction
            // 
            lblTransaction.BackColor = Color.Transparent;
            lblTransaction.Location = new Point(54, 34);
            lblTransaction.Name = "lblTransaction";
            lblTransaction.Size = new Size(85, 22);
            lblTransaction.TabIndex = 5;
            lblTransaction.Text = "Transactions";
            // 
            // lblInputUserId
            // 
            lblInputUserId.BackColor = Color.Transparent;
            lblInputUserId.Location = new Point(122, 138);
            lblInputUserId.Name = "lblInputUserId";
            lblInputUserId.Size = new Size(15, 22);
            lblInputUserId.TabIndex = 4;
            lblInputUserId.Text = "--";
            // 
            // lblUserId
            // 
            lblUserId.BackColor = Color.Transparent;
            lblUserId.Location = new Point(54, 138);
            lblUserId.Name = "lblUserId";
            lblUserId.Size = new Size(52, 22);
            lblUserId.TabIndex = 3;
            lblUserId.Text = "User Id:";
            // 
            // lblInputName
            // 
            lblInputName.BackColor = Color.Transparent;
            lblInputName.Location = new Point(122, 95);
            lblInputName.Name = "lblInputName";
            lblInputName.Size = new Size(15, 22);
            lblInputName.TabIndex = 2;
            lblInputName.Text = "--";
            // 
            // lblUser
            // 
            lblUser.BackColor = Color.Transparent;
            lblUser.Location = new Point(54, 95);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(35, 22);
            lblUser.TabIndex = 1;
            lblUser.Text = "User:";
            // 
            // flpReceiptList
            // 
            flpReceiptList.BackColor = Color.Transparent;
            flpReceiptList.Location = new Point(12, 215);
            flpReceiptList.Name = "flpReceiptList";
            flpReceiptList.Size = new Size(1376, 623);
            flpReceiptList.TabIndex = 0;
            // 
            // dbTransactionHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 850);
            Controls.Add(guna2CustomGradientPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "dbTransactionHistory";
            Text = "dbShoppingCart";
            guna2CustomGradientPanel1.ResumeLayout(false);
            guna2CustomGradientPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private FlowLayoutPanel flpReceiptList;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUser;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblInputUserId;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUserId;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblInputName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTransaction;
    }
}