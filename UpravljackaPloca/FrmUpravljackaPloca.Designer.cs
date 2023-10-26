namespace UpravljackaPloca
{
    partial class FrmUpravljackaPloca
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
            this.dgvPopisOtvora = new System.Windows.Forms.DataGridView();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnOtvori = new System.Windows.Forms.Button();
            this.btnZatvoriSve = new System.Windows.Forms.Button();
            this.btnOtvoriSve = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisOtvora)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Popis otvora:";
            // 
            // dgvPopisOtvora
            // 
            this.dgvPopisOtvora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisOtvora.Location = new System.Drawing.Point(12, 25);
            this.dgvPopisOtvora.Name = "dgvPopisOtvora";
            this.dgvPopisOtvora.Size = new System.Drawing.Size(328, 220);
            this.dgvPopisOtvora.TabIndex = 1;
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(265, 251);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 23);
            this.btnZatvori.TabIndex = 2;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // btnOtvori
            // 
            this.btnOtvori.Location = new System.Drawing.Point(184, 251);
            this.btnOtvori.Name = "btnOtvori";
            this.btnOtvori.Size = new System.Drawing.Size(75, 23);
            this.btnOtvori.TabIndex = 3;
            this.btnOtvori.Text = "Otvori";
            this.btnOtvori.UseVisualStyleBackColor = true;
            this.btnOtvori.Click += new System.EventHandler(this.btnOtvori_Click);
            // 
            // btnZatvoriSve
            // 
            this.btnZatvoriSve.Location = new System.Drawing.Point(265, 280);
            this.btnZatvoriSve.Name = "btnZatvoriSve";
            this.btnZatvoriSve.Size = new System.Drawing.Size(75, 23);
            this.btnZatvoriSve.TabIndex = 4;
            this.btnZatvoriSve.Text = "Zatvori sve";
            this.btnZatvoriSve.UseVisualStyleBackColor = true;
            this.btnZatvoriSve.Click += new System.EventHandler(this.btnZatvoriSve_Click);
            // 
            // btnOtvoriSve
            // 
            this.btnOtvoriSve.Location = new System.Drawing.Point(184, 280);
            this.btnOtvoriSve.Name = "btnOtvoriSve";
            this.btnOtvoriSve.Size = new System.Drawing.Size(75, 23);
            this.btnOtvoriSve.TabIndex = 5;
            this.btnOtvoriSve.Text = "Otvori sve";
            this.btnOtvoriSve.UseVisualStyleBackColor = true;
            this.btnOtvoriSve.Click += new System.EventHandler(this.btnOtvoriSve_Click);
            // 
            // FrmUpravljackaPloca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 321);
            this.Controls.Add(this.btnOtvoriSve);
            this.Controls.Add(this.btnZatvoriSve);
            this.Controls.Add(this.btnOtvori);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.dgvPopisOtvora);
            this.Controls.Add(this.label1);
            this.Name = "FrmUpravljackaPloca";
            this.Text = "Upravljacka Ploca";
            this.Load += new System.EventHandler(this.FrmUpravljackaPloca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisOtvora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPopisOtvora;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnOtvori;
        private System.Windows.Forms.Button btnZatvoriSve;
        private System.Windows.Forms.Button btnOtvoriSve;
    }
}

