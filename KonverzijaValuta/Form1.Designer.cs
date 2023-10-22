namespace KonverzijaValuta
{
    partial class Form1
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
            this.cbFirstCurr = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSecondCurr = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbConverted = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose first currency:";
            // 
            // cbFirstCurr
            // 
            this.cbFirstCurr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFirstCurr.FormattingEnabled = true;
            this.cbFirstCurr.Location = new System.Drawing.Point(12, 29);
            this.cbFirstCurr.Name = "cbFirstCurr";
            this.cbFirstCurr.Size = new System.Drawing.Size(121, 21);
            this.cbFirstCurr.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose second currency:";
            // 
            // cbSecondCurr
            // 
            this.cbSecondCurr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSecondCurr.FormattingEnabled = true;
            this.cbSecondCurr.Location = new System.Drawing.Point(13, 70);
            this.cbSecondCurr.Name = "cbSecondCurr";
            this.cbSecondCurr.Size = new System.Drawing.Size(121, 21);
            this.cbSecondCurr.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter amount:";
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(12, 110);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(121, 20);
            this.tbAmount.TabIndex = 5;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(11, 152);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(122, 23);
            this.btnConvert.TabIndex = 6;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Converted amount:";
            // 
            // tbConverted
            // 
            this.tbConverted.Location = new System.Drawing.Point(13, 225);
            this.tbConverted.Name = "tbConverted";
            this.tbConverted.ReadOnly = true;
            this.tbConverted.Size = new System.Drawing.Size(120, 20);
            this.tbConverted.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 257);
            this.Controls.Add(this.tbConverted);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbSecondCurr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFirstCurr);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Money Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFirstCurr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSecondCurr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbConverted;
    }
}

