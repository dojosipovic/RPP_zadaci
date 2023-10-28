namespace ProjectsReport
{
    partial class ProjectRepotForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMentors = new System.Windows.Forms.ComboBox();
            this.btnDisplayAll = new System.Windows.Forms.Button();
            this.btnDisplaySelected = new System.Windows.Forms.Button();
            this.txtReport = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose mentor:";
            // 
            // cmbMentors
            // 
            this.cmbMentors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMentors.FormattingEnabled = true;
            this.cmbMentors.Location = new System.Drawing.Point(116, 17);
            this.cmbMentors.Name = "cmbMentors";
            this.cmbMentors.Size = new System.Drawing.Size(128, 21);
            this.cmbMentors.TabIndex = 1;
            // 
            // btnDisplayAll
            // 
            this.btnDisplayAll.Location = new System.Drawing.Point(397, 15);
            this.btnDisplayAll.Name = "btnDisplayAll";
            this.btnDisplayAll.Size = new System.Drawing.Size(124, 23);
            this.btnDisplayAll.TabIndex = 2;
            this.btnDisplayAll.Text = "Display All";
            this.btnDisplayAll.UseVisualStyleBackColor = true;
            this.btnDisplayAll.Click += new System.EventHandler(this.btnDisplayAll_Click);
            // 
            // btnDisplaySelected
            // 
            this.btnDisplaySelected.Location = new System.Drawing.Point(250, 15);
            this.btnDisplaySelected.Name = "btnDisplaySelected";
            this.btnDisplaySelected.Size = new System.Drawing.Size(141, 23);
            this.btnDisplaySelected.TabIndex = 3;
            this.btnDisplaySelected.Text = "Display Selected";
            this.btnDisplaySelected.UseVisualStyleBackColor = true;
            this.btnDisplaySelected.Click += new System.EventHandler(this.btnDisplaySelected_Click);
            // 
            // txtReport
            // 
            this.txtReport.Location = new System.Drawing.Point(12, 44);
            this.txtReport.Multiline = true;
            this.txtReport.Name = "txtReport";
            this.txtReport.Size = new System.Drawing.Size(509, 394);
            this.txtReport.TabIndex = 4;
            // 
            // ProjectRepotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 450);
            this.Controls.Add(this.txtReport);
            this.Controls.Add(this.btnDisplaySelected);
            this.Controls.Add(this.btnDisplayAll);
            this.Controls.Add(this.cmbMentors);
            this.Controls.Add(this.label1);
            this.Name = "ProjectRepotForm";
            this.Text = "Project Report";
            this.Load += new System.EventHandler(this.ProjectRepotForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMentors;
        private System.Windows.Forms.Button btnDisplayAll;
        private System.Windows.Forms.Button btnDisplaySelected;
        private System.Windows.Forms.TextBox txtReport;
    }
}

