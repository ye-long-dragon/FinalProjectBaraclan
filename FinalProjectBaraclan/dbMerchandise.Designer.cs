namespace FinalProjectBaraclan
{
    partial class dbMerchandise
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
            pnlMerchMain = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            SuspendLayout();
            // 
            // pnlMerchMain
            // 
            pnlMerchMain.CustomizableEdges = customizableEdges1;
            pnlMerchMain.Dock = DockStyle.Fill;
            pnlMerchMain.Location = new Point(0, 0);
            pnlMerchMain.Name = "pnlMerchMain";
            pnlMerchMain.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pnlMerchMain.Size = new Size(800, 450);
            pnlMerchMain.TabIndex = 0;
            // 
            // dbMerchandise
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlMerchMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "dbMerchandise";
            Text = "dbMerchandise";
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlMerchMain;
    }
}