namespace StreamingServis
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
            this.dgvFilmovi = new System.Windows.Forms.DataGridView();
            this.btnOsvjezi = new System.Windows.Forms.Button();
            this.btnPogledaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmovi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Neodgledani filmovi:";
            // 
            // dgvFilmovi
            // 
            this.dgvFilmovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilmovi.Location = new System.Drawing.Point(12, 29);
            this.dgvFilmovi.Name = "dgvFilmovi";
            this.dgvFilmovi.Size = new System.Drawing.Size(325, 167);
            this.dgvFilmovi.TabIndex = 1;
            // 
            // btnOsvjezi
            // 
            this.btnOsvjezi.Location = new System.Drawing.Point(242, 202);
            this.btnOsvjezi.Name = "btnOsvjezi";
            this.btnOsvjezi.Size = new System.Drawing.Size(95, 33);
            this.btnOsvjezi.TabIndex = 2;
            this.btnOsvjezi.Text = "Osvježi prikaz";
            this.btnOsvjezi.UseVisualStyleBackColor = true;
            this.btnOsvjezi.Click += new System.EventHandler(this.btnOsvjezi_Click);
            // 
            // btnPogledaj
            // 
            this.btnPogledaj.Location = new System.Drawing.Point(141, 202);
            this.btnPogledaj.Name = "btnPogledaj";
            this.btnPogledaj.Size = new System.Drawing.Size(95, 33);
            this.btnPogledaj.TabIndex = 3;
            this.btnPogledaj.Text = "Pogledaj film";
            this.btnPogledaj.UseVisualStyleBackColor = true;
            this.btnPogledaj.Click += new System.EventHandler(this.btnPogledaj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 244);
            this.Controls.Add(this.btnPogledaj);
            this.Controls.Add(this.btnOsvjezi);
            this.Controls.Add(this.dgvFilmovi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Filmovi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvFilmovi;
        private System.Windows.Forms.Button btnOsvjezi;
        private System.Windows.Forms.Button btnPogledaj;
    }
}

