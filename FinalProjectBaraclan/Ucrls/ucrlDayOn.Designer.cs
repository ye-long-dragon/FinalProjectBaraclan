namespace FinalProjectBaraclan.Ucrls
{
    partial class ucrlDay
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
            btnReserve = new Guna.UI2.WinForms.Guna2Button();
            lblReservation = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblNumber = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2CustomGradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            guna2CustomGradientPanel1.Controls.Add(btnReserve);
            guna2CustomGradientPanel1.Controls.Add(lblReservation);
            guna2CustomGradientPanel1.Controls.Add(lblNumber);
            guna2CustomGradientPanel1.CustomizableEdges = customizableEdges3;
            guna2CustomGradientPanel1.Dock = DockStyle.Fill;
            guna2CustomGradientPanel1.FillColor3 = Color.DeepSkyBlue;
            guna2CustomGradientPanel1.Location = new Point(0, 0);
            guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2CustomGradientPanel1.Size = new Size(180, 118);
            guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // btnReserve
            // 
            btnReserve.AutoRoundedCorners = true;
            btnReserve.BackColor = Color.Transparent;
            btnReserve.BorderRadius = 24;
            btnReserve.CustomizableEdges = customizableEdges1;
            btnReserve.DisabledState.BorderColor = Color.DarkGray;
            btnReserve.DisabledState.CustomBorderColor = Color.DarkGray;
            btnReserve.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnReserve.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnReserve.Font = new Font("Segoe UI", 9F);
            btnReserve.ForeColor = Color.White;
            btnReserve.Location = new Point(0, 68);
            btnReserve.Name = "btnReserve";
            btnReserve.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnReserve.Size = new Size(180, 50);
            btnReserve.TabIndex = 6;
            btnReserve.Text = "Reserve";
            btnReserve.Click += btnReserve_Click;
            // 
            // lblReservation
            // 
            lblReservation.BackColor = Color.Transparent;
            lblReservation.Location = new Point(27, 40);
            lblReservation.Name = "lblReservation";
            lblReservation.Size = new Size(121, 22);
            lblReservation.TabIndex = 5;
            lblReservation.Text = "guna2HtmlLabel2";
            // 
            // lblNumber
            // 
            lblNumber.BackColor = Color.Transparent;
            lblNumber.Location = new Point(59, 12);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(121, 22);
            lblNumber.TabIndex = 4;
            lblNumber.Text = "guna2HtmlLabel1";
            // 
            // ucrlDay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2CustomGradientPanel1);
            Name = "ucrlDay";
            Size = new Size(180, 118);
            guna2CustomGradientPanel1.ResumeLayout(false);
            guna2CustomGradientPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2Button btnReserve;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblReservation;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNumber;
    }
}
