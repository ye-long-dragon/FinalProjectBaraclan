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
            pnlShop = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            SuspendLayout();
            // 
            // pnlShop
            // 
            pnlShop.CustomizableEdges = customizableEdges1;
            pnlShop.Dock = DockStyle.Fill;
            pnlShop.FillColor3 = Color.FromArgb(90, 178, 255);
            pnlShop.FillColor4 = Color.FromArgb(90, 178, 255);
            pnlShop.Location = new Point(0, 0);
            pnlShop.Name = "pnlShop";
            pnlShop.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pnlShop.Size = new Size(800, 450);
            pnlShop.TabIndex = 0;
            // 
            // FullShop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlShop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FullShop";
            Text = "FullShop";
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlShop;
    }
}