namespace DigitalnaBrava
{
    partial class BravaForm
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
            this.tbBrojKartice = new System.Windows.Forms.TextBox();
            this.tbPin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn501 = new System.Windows.Forms.Button();
            this.btn502 = new System.Windows.Forms.Button();
            this.btn503 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broj kartice:";
            // 
            // tbBrojKartice
            // 
            this.tbBrojKartice.Location = new System.Drawing.Point(126, 42);
            this.tbBrojKartice.Name = "tbBrojKartice";
            this.tbBrojKartice.Size = new System.Drawing.Size(171, 20);
            this.tbBrojKartice.TabIndex = 1;
            // 
            // tbPin
            // 
            this.tbPin.Location = new System.Drawing.Point(126, 68);
            this.tbPin.Name = "tbPin";
            this.tbPin.Size = new System.Drawing.Size(171, 20);
            this.tbPin.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "PIN:";
            // 
            // btn501
            // 
            this.btn501.Location = new System.Drawing.Point(60, 94);
            this.btn501.Name = "btn501";
            this.btn501.Size = new System.Drawing.Size(75, 45);
            this.btn501.TabIndex = 4;
            this.btn501.Text = "Otvori Vrata br. 501";
            this.btn501.UseVisualStyleBackColor = true;
            this.btn501.Click += new System.EventHandler(this.btn501_Click);
            // 
            // btn502
            // 
            this.btn502.Location = new System.Drawing.Point(141, 94);
            this.btn502.Name = "btn502";
            this.btn502.Size = new System.Drawing.Size(75, 45);
            this.btn502.TabIndex = 5;
            this.btn502.Text = "Otvori Vrata br. 502";
            this.btn502.UseVisualStyleBackColor = true;
            this.btn502.Click += new System.EventHandler(this.btn502_Click);
            // 
            // btn503
            // 
            this.btn503.Location = new System.Drawing.Point(222, 94);
            this.btn503.Name = "btn503";
            this.btn503.Size = new System.Drawing.Size(75, 45);
            this.btn503.TabIndex = 6;
            this.btn503.Text = "Otvori Vrata br. 503";
            this.btn503.UseVisualStyleBackColor = true;
            this.btn503.Click += new System.EventHandler(this.btn503_Click);
            // 
            // BravaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 189);
            this.Controls.Add(this.btn503);
            this.Controls.Add(this.btn502);
            this.Controls.Add(this.btn501);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPin);
            this.Controls.Add(this.tbBrojKartice);
            this.Controls.Add(this.label1);
            this.Name = "BravaForm";
            this.Text = "Otvaranje vrata";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBrojKartice;
        private System.Windows.Forms.TextBox tbPin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn501;
        private System.Windows.Forms.Button btn502;
        private System.Windows.Forms.Button btn503;
    }
}

