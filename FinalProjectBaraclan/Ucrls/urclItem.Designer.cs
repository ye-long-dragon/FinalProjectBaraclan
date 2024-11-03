namespace FinalProjectBaraclan.Ucrls
{
    partial class urclItem
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlUserControl = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            btnDropped = new Guna.UI2.WinForms.Guna2Button();
            lblQuantity = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnAdd = new Guna.UI2.WinForms.Guna2Button();
            lblItemName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            imgImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            pnlUserControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgImage).BeginInit();
            SuspendLayout();
            // 
            // pnlUserControl
            // 
            pnlUserControl.Controls.Add(btnDropped);
            pnlUserControl.Controls.Add(lblQuantity);
            pnlUserControl.Controls.Add(btnAdd);
            pnlUserControl.Controls.Add(lblItemName);
            pnlUserControl.Controls.Add(imgImage);
            pnlUserControl.CustomizableEdges = customizableEdges13;
            pnlUserControl.Dock = DockStyle.Fill;
            pnlUserControl.Location = new Point(0, 0);
            pnlUserControl.Name = "pnlUserControl";
            pnlUserControl.ShadowDecoration.CustomizableEdges = customizableEdges14;
            pnlUserControl.Size = new Size(229, 338);
            pnlUserControl.TabIndex = 0;
            // 
            // btnDropped
            // 
            btnDropped.AutoRoundedCorners = true;
            btnDropped.BackColor = Color.Transparent;
            btnDropped.BorderRadius = 20;
            btnDropped.CustomizableEdges = customizableEdges8;
            btnDropped.DisabledState.BorderColor = Color.DarkGray;
            btnDropped.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDropped.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDropped.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDropped.Font = new Font("Segoe UI", 9F);
            btnDropped.ForeColor = Color.White;
            btnDropped.Location = new Point(44, 266);
            btnDropped.Name = "btnDropped";
            btnDropped.ShadowDecoration.CustomizableEdges = customizableEdges9;
            btnDropped.Size = new Size(141, 42);
            btnDropped.TabIndex = 9;
            btnDropped.Text = "Drop";
            btnDropped.Click += guna2Button2_Click;
            // 
            // lblQuantity
            // 
            lblQuantity.BackColor = Color.Transparent;
            lblQuantity.Location = new Point(53, 190);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(121, 22);
            lblQuantity.TabIndex = 8;
            lblQuantity.Text = "guna2HtmlLabel2";
            // 
            // btnAdd
            // 
            btnAdd.AutoRoundedCorners = true;
            btnAdd.BackColor = Color.Transparent;
            btnAdd.BorderRadius = 20;
            btnAdd.CustomizableEdges = customizableEdges10;
            btnAdd.DisabledState.BorderColor = Color.DarkGray;
            btnAdd.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdd.Font = new Font("Segoe UI", 9F);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(44, 218);
            btnAdd.Name = "btnAdd";
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges11;
            btnAdd.Size = new Size(141, 42);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;
            // 
            // lblItemName
            // 
            lblItemName.BackColor = Color.Transparent;
            lblItemName.Location = new Point(53, 162);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(121, 22);
            lblItemName.TabIndex = 6;
            lblItemName.Text = "guna2HtmlLabel1";
            // 
            // imgImage
            // 
            imgImage.BackColor = Color.Transparent;
            imgImage.ImageRotate = 0F;
            imgImage.Location = new Point(53, 30);
            imgImage.Name = "imgImage";
            imgImage.ShadowDecoration.CustomizableEdges = customizableEdges12;
            imgImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            imgImage.Size = new Size(123, 117);
            imgImage.TabIndex = 5;
            imgImage.TabStop = false;
            // 
            // urclItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlUserControl);
            Name = "urclItem";
            Size = new Size(229, 338);
            pnlUserControl.ResumeLayout(false);
            pnlUserControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlUserControl;
        private Guna.UI2.WinForms.Guna2Button btnDropped;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblQuantity;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblItemName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox imgImage;
    }
}
