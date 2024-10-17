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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlAllItems = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            SuspendLayout();
            // 
            // pnlAllItems
            // 
            pnlAllItems.CustomizableEdges = customizableEdges1;
            pnlAllItems.Dock = DockStyle.Fill;
            pnlAllItems.FillColor = Color.IndianRed;
            pnlAllItems.Location = new Point(0, 0);
            pnlAllItems.Name = "pnlAllItems";
            pnlAllItems.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pnlAllItems.Size = new Size(1400, 850);
            pnlAllItems.TabIndex = 0;
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
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlAllItems;
    }
}