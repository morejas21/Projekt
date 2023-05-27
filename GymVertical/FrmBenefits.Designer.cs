namespace GymVertical
{
    partial class FrmBenefits
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
            this.rdbMembershipDuration = new System.Windows.Forms.RadioButton();
            this.rdbProteinSale = new System.Windows.Forms.RadioButton();
            this.rdbTreningNumber = new System.Windows.Forms.RadioButton();
            this.lblBenefits = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdbMembershipDuration
            // 
            this.rdbMembershipDuration.AutoSize = true;
            this.rdbMembershipDuration.Location = new System.Drawing.Point(100, 74);
            this.rdbMembershipDuration.Name = "rdbMembershipDuration";
            this.rdbMembershipDuration.Size = new System.Drawing.Size(121, 17);
            this.rdbMembershipDuration.TabIndex = 0;
            this.rdbMembershipDuration.TabStop = true;
            this.rdbMembershipDuration.Text = "Produljenje pretplate";
            this.rdbMembershipDuration.UseVisualStyleBackColor = true;
            // 
            // rdbProteinSale
            // 
            this.rdbProteinSale.AutoSize = true;
            this.rdbProteinSale.Location = new System.Drawing.Point(100, 112);
            this.rdbProteinSale.Name = "rdbProteinSale";
            this.rdbProteinSale.Size = new System.Drawing.Size(114, 17);
            this.rdbProteinSale.TabIndex = 1;
            this.rdbProteinSale.TabStop = true;
            this.rdbProteinSale.Text = "Popust na proteine";
            this.rdbProteinSale.UseVisualStyleBackColor = true;
            // 
            // rdbTreningNumber
            // 
            this.rdbTreningNumber.AutoSize = true;
            this.rdbTreningNumber.Location = new System.Drawing.Point(100, 151);
            this.rdbTreningNumber.Name = "rdbTreningNumber";
            this.rdbTreningNumber.Size = new System.Drawing.Size(122, 17);
            this.rdbTreningNumber.TabIndex = 2;
            this.rdbTreningNumber.TabStop = true;
            this.rdbTreningNumber.Text = "Više treninga u danu";
            this.rdbTreningNumber.UseVisualStyleBackColor = true;
            // 
            // lblBenefits
            // 
            this.lblBenefits.AutoSize = true;
            this.lblBenefits.Location = new System.Drawing.Point(69, 39);
            this.lblBenefits.Name = "lblBenefits";
            this.lblBenefits.Size = new System.Drawing.Size(203, 13);
            this.lblBenefits.TabIndex = 3;
            this.lblBenefits.Text = "Odaberite pogodnost za odabranog člana";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(90, 188);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(132, 42);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Odaberi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmBenefits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 242);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblBenefits);
            this.Controls.Add(this.rdbTreningNumber);
            this.Controls.Add(this.rdbProteinSale);
            this.Controls.Add(this.rdbMembershipDuration);
            this.Name = "FrmBenefits";
            this.Text = "FrmBenefits";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbMembershipDuration;
        private System.Windows.Forms.RadioButton rdbProteinSale;
        private System.Windows.Forms.RadioButton rdbTreningNumber;
        private System.Windows.Forms.Label lblBenefits;
        private System.Windows.Forms.Button btnSave;
    }
}