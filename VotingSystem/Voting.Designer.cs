namespace VotingSystem
{
    partial class Voting
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
            this.tbOIB = new System.Windows.Forms.TextBox();
            this.cbOption = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVote = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFor = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAgainst = new System.Windows.Forms.Label();
            this.lblAbstained = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter OIB:";
            // 
            // tbOIB
            // 
            this.tbOIB.Location = new System.Drawing.Point(13, 26);
            this.tbOIB.Name = "tbOIB";
            this.tbOIB.Size = new System.Drawing.Size(225, 20);
            this.tbOIB.TabIndex = 1;
            // 
            // cbOption
            // 
            this.cbOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOption.FormattingEnabled = true;
            this.cbOption.Location = new System.Drawing.Point(12, 87);
            this.cbOption.Name = "cbOption";
            this.cbOption.Size = new System.Drawing.Size(145, 21);
            this.cbOption.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choose option:";
            // 
            // btnVote
            // 
            this.btnVote.Location = new System.Drawing.Point(163, 87);
            this.btnVote.Name = "btnVote";
            this.btnVote.Size = new System.Drawing.Size(75, 23);
            this.btnVote.TabIndex = 4;
            this.btnVote.Text = "Vote";
            this.btnVote.UseVisualStyleBackColor = true;
            this.btnVote.Click += new System.EventHandler(this.btnVote_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vote results:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "FOR:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblFor
            // 
            this.lblFor.AutoSize = true;
            this.lblFor.Location = new System.Drawing.Point(351, 26);
            this.lblFor.Name = "lblFor";
            this.lblFor.Size = new System.Drawing.Size(32, 13);
            this.lblFor.TabIndex = 7;
            this.lblFor.Text = "FOR:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(273, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "AGAINST:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(273, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "ABSTAINED:";
            // 
            // lblAgainst
            // 
            this.lblAgainst.AutoSize = true;
            this.lblAgainst.Location = new System.Drawing.Point(351, 49);
            this.lblAgainst.Name = "lblAgainst";
            this.lblAgainst.Size = new System.Drawing.Size(32, 13);
            this.lblAgainst.TabIndex = 10;
            this.lblAgainst.Text = "FOR:";
            // 
            // lblAbstained
            // 
            this.lblAbstained.AutoSize = true;
            this.lblAbstained.Location = new System.Drawing.Point(351, 71);
            this.lblAbstained.Name = "lblAbstained";
            this.lblAbstained.Size = new System.Drawing.Size(32, 13);
            this.lblAbstained.TabIndex = 11;
            this.lblAbstained.Text = "FOR:";
            // 
            // Voting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 134);
            this.Controls.Add(this.lblAbstained);
            this.Controls.Add(this.lblAgainst);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblFor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVote);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbOption);
            this.Controls.Add(this.tbOIB);
            this.Controls.Add(this.label1);
            this.Name = "Voting";
            this.Text = "Voting";
            this.Load += new System.EventHandler(this.Voting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbOIB;
        private System.Windows.Forms.ComboBox cbOption;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAgainst;
        private System.Windows.Forms.Label lblAbstained;
    }
}

