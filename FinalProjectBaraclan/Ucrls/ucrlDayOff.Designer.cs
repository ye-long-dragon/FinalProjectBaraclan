namespace FinalProjectBaraclan.Ucrls
{
    partial class ucrlDayOff
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
            lblReserve = new Guna.UI2.WinForms.Guna2HtmlLabel();
            SuspendLayout();
            // 
            // lblReserve
            // 
            lblReserve.BackColor = Color.Transparent;
            lblReserve.Location = new Point(41, 52);
            lblReserve.Name = "lblReserve";
            lblReserve.Size = new Size(121, 22);
            lblReserve.TabIndex = 0;
            lblReserve.Text = "guna2HtmlLabel1";
            // 
            // ucrlDayOff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblReserve);
            Name = "ucrlDayOff";
            Size = new Size(180, 118);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblReserve;
    }
}
