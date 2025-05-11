namespace FinalProjectBaraclan.MainMenuViews
{
    partial class dbCalendar
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            flpCalendar = new FlowLayoutPanel();
            btnNext = new Guna.UI2.WinForms.Guna2Button();
            btnPrevious = new Guna.UI2.WinForms.Guna2Button();
            lblSunday = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblMonday = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblTuesday = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblWednesday = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblThursday = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblSaturday = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblFriday = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblMonthYear = new Guna.UI2.WinForms.Guna2HtmlLabel();
            SuspendLayout();
            // 
            // flpCalendar
            // 
            flpCalendar.Location = new Point(12, 187);
            flpCalendar.Name = "flpCalendar";
            flpCalendar.Size = new Size(1376, 651);
            flpCalendar.TabIndex = 0;
            // 
            // btnNext
            // 
            btnNext.AutoRoundedCorners = true;
            btnNext.BorderRadius = 27;
            btnNext.CustomizableEdges = customizableEdges1;
            btnNext.DisabledState.BorderColor = Color.DarkGray;
            btnNext.DisabledState.CustomBorderColor = Color.DarkGray;
            btnNext.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnNext.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnNext.Font = new Font("Segoe UI", 9F);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(1163, 12);
            btnNext.Name = "btnNext";
            btnNext.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnNext.Size = new Size(225, 56);
            btnNext.TabIndex = 1;
            btnNext.Text = "Next";
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.AutoRoundedCorners = true;
            btnPrevious.BorderRadius = 27;
            btnPrevious.CustomizableEdges = customizableEdges3;
            btnPrevious.DisabledState.BorderColor = Color.DarkGray;
            btnPrevious.DisabledState.CustomBorderColor = Color.DarkGray;
            btnPrevious.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnPrevious.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnPrevious.Font = new Font("Segoe UI", 9F);
            btnPrevious.ForeColor = Color.White;
            btnPrevious.Location = new Point(12, 12);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnPrevious.Size = new Size(225, 56);
            btnPrevious.TabIndex = 2;
            btnPrevious.Text = "Previous";
            btnPrevious.Click += btnPrevious_Click;
            // 
            // lblSunday
            // 
            lblSunday.BackColor = Color.Transparent;
            lblSunday.Location = new Point(61, 139);
            lblSunday.Name = "lblSunday";
            lblSunday.Size = new Size(51, 22);
            lblSunday.TabIndex = 3;
            lblSunday.Text = "Sunday";
            // 
            // lblMonday
            // 
            lblMonday.BackColor = Color.Transparent;
            lblMonday.Location = new Point(254, 139);
            lblMonday.Name = "lblMonday";
            lblMonday.Size = new Size(57, 22);
            lblMonday.TabIndex = 4;
            lblMonday.Text = "Monday";
            // 
            // lblTuesday
            // 
            lblTuesday.BackColor = Color.Transparent;
            lblTuesday.Location = new Point(438, 139);
            lblTuesday.Name = "lblTuesday";
            lblTuesday.Size = new Size(57, 22);
            lblTuesday.TabIndex = 5;
            lblTuesday.Text = "Tuesday";
            // 
            // lblWednesday
            // 
            lblWednesday.BackColor = Color.Transparent;
            lblWednesday.Location = new Point(637, 139);
            lblWednesday.Name = "lblWednesday";
            lblWednesday.Size = new Size(80, 22);
            lblWednesday.TabIndex = 6;
            lblWednesday.Text = "Wednesday";
            // 
            // lblThursday
            // 
            lblThursday.BackColor = Color.Transparent;
            lblThursday.Location = new Point(861, 139);
            lblThursday.Name = "lblThursday";
            lblThursday.Size = new Size(62, 22);
            lblThursday.TabIndex = 7;
            lblThursday.Text = "Thursday";
            // 
            // lblSaturday
            // 
            lblSaturday.BackColor = Color.Transparent;
            lblSaturday.Location = new Point(1233, 139);
            lblSaturday.Name = "lblSaturday";
            lblSaturday.Size = new Size(61, 22);
            lblSaturday.TabIndex = 8;
            lblSaturday.Text = "Saturday";
            // 
            // lblFriday
            // 
            lblFriday.BackColor = Color.Transparent;
            lblFriday.Location = new Point(1061, 139);
            lblFriday.Name = "lblFriday";
            lblFriday.Size = new Size(43, 22);
            lblFriday.TabIndex = 9;
            lblFriday.Text = "Friday";
            // 
            // lblMonthYear
            // 
            lblMonthYear.BackColor = Color.Transparent;
            lblMonthYear.Font = new Font("Segoe UI", 24F);
            lblMonthYear.Location = new Point(619, 44);
            lblMonthYear.Name = "lblMonthYear";
            lblMonthYear.Size = new Size(122, 56);
            lblMonthYear.TabIndex = 10;
            lblMonthYear.Text = "Month";
            // 
            // dbCalendar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 850);
            Controls.Add(lblMonthYear);
            Controls.Add(lblFriday);
            Controls.Add(lblSaturday);
            Controls.Add(lblThursday);
            Controls.Add(lblWednesday);
            Controls.Add(lblTuesday);
            Controls.Add(lblMonday);
            Controls.Add(lblSunday);
            Controls.Add(btnPrevious);
            Controls.Add(btnNext);
            Controls.Add(flpCalendar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "dbCalendar";
            Text = "dbCalendar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpCalendar;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2Button btnPrevious;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSunday;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMonday;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTuesday;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblWednesday;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblThursday;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSaturday;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblFriday;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMonthYear;
    }
}