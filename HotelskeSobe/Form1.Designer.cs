namespace HotelskeSobe
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
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.btnPrikaziSlobodne = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSlobodneSobe = new System.Windows.Forms.DataGridView();
            this.btnRezerviraj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlobodneSobe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datum rezervacije:";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(12, 25);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 20);
            this.dtpDatum.TabIndex = 1;
            // 
            // btnPrikaziSlobodne
            // 
            this.btnPrikaziSlobodne.Location = new System.Drawing.Point(219, 25);
            this.btnPrikaziSlobodne.Name = "btnPrikaziSlobodne";
            this.btnPrikaziSlobodne.Size = new System.Drawing.Size(137, 23);
            this.btnPrikaziSlobodne.TabIndex = 2;
            this.btnPrikaziSlobodne.Text = "Prikazi slobodne sobe";
            this.btnPrikaziSlobodne.UseVisualStyleBackColor = true;
            this.btnPrikaziSlobodne.Click += new System.EventHandler(this.btnPrikaziSlobodne_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Slobodne sobe:";
            // 
            // dgvSlobodneSobe
            // 
            this.dgvSlobodneSobe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSlobodneSobe.Location = new System.Drawing.Point(12, 68);
            this.dgvSlobodneSobe.Name = "dgvSlobodneSobe";
            this.dgvSlobodneSobe.Size = new System.Drawing.Size(344, 158);
            this.dgvSlobodneSobe.TabIndex = 4;
            // 
            // btnRezerviraj
            // 
            this.btnRezerviraj.Location = new System.Drawing.Point(281, 232);
            this.btnRezerviraj.Name = "btnRezerviraj";
            this.btnRezerviraj.Size = new System.Drawing.Size(75, 23);
            this.btnRezerviraj.TabIndex = 5;
            this.btnRezerviraj.Text = "Rezerviraj";
            this.btnRezerviraj.UseVisualStyleBackColor = true;
            this.btnRezerviraj.Click += new System.EventHandler(this.btnRezerviraj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 267);
            this.Controls.Add(this.btnRezerviraj);
            this.Controls.Add(this.dgvSlobodneSobe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPrikaziSlobodne);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Rezervacija sobe";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlobodneSobe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Button btnPrikaziSlobodne;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSlobodneSobe;
        private System.Windows.Forms.Button btnRezerviraj;
    }
}

