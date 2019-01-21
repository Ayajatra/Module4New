namespace Module4New
{
    partial class DetailedForm
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
            this.rv = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxGender = new System.Windows.Forms.CheckBox();
            this.cbTimePeriod = new System.Windows.Forms.ComboBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.cbxAge = new System.Windows.Forms.CheckBox();
            this.cbAge = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // rv
            // 
            this.rv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rv.Location = new System.Drawing.Point(12, 55);
            this.rv.Name = "rv";
            this.rv.ServerReport.BearerToken = null;
            this.rv.Size = new System.Drawing.Size(599, 334);
            this.rv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(403, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time Period :";
            // 
            // cbxGender
            // 
            this.cbxGender.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbxGender.AutoSize = true;
            this.cbxGender.Checked = true;
            this.cbxGender.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxGender.Location = new System.Drawing.Point(92, 398);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(71, 20);
            this.cbxGender.TabIndex = 3;
            this.cbxGender.Text = "Gender";
            this.cbxGender.UseVisualStyleBackColor = true;
            // 
            // cbTimePeriod
            // 
            this.cbTimePeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTimePeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimePeriod.FormattingEnabled = true;
            this.cbTimePeriod.Location = new System.Drawing.Point(490, 22);
            this.cbTimePeriod.Name = "cbTimePeriod";
            this.cbTimePeriod.Size = new System.Drawing.Size(121, 23);
            this.cbTimePeriod.TabIndex = 4;
            // 
            // cbGender
            // 
            this.cbGender.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(183, 395);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(121, 23);
            this.cbGender.TabIndex = 4;
            // 
            // cbxAge
            // 
            this.cbxAge.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbxAge.AutoSize = true;
            this.cbxAge.Checked = true;
            this.cbxAge.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxAge.Location = new System.Drawing.Point(348, 398);
            this.cbxAge.Name = "cbxAge";
            this.cbxAge.Size = new System.Drawing.Size(50, 20);
            this.cbxAge.TabIndex = 3;
            this.cbxAge.Text = "Age";
            this.cbxAge.UseVisualStyleBackColor = true;
            // 
            // cbAge
            // 
            this.cbAge.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbAge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAge.FormattingEnabled = true;
            this.cbAge.Location = new System.Drawing.Point(404, 397);
            this.cbAge.Name = "cbAge";
            this.cbAge.Size = new System.Drawing.Size(121, 23);
            this.cbAge.TabIndex = 4;
            // 
            // DetailedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 430);
            this.Controls.Add(this.cbAge);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.cbxAge);
            this.Controls.Add(this.cbTimePeriod);
            this.Controls.Add(this.cbxGender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetailedForm";
            this.Text = "DetailedForm";
            this.Load += new System.EventHandler(this.DetailedForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbxGender;
        private System.Windows.Forms.ComboBox cbTimePeriod;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.CheckBox cbxAge;
        private System.Windows.Forms.ComboBox cbAge;
    }
}