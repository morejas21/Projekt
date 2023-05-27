namespace GymVertical
{
    partial class FrmInsert
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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtLivingPlace = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtStatusGoldMember = new System.Windows.Forms.TextBox();
            this.txtBenefit = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(203, 82);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.Text = "Mirjana";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(344, 82);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.Text = "Tozovac";
            // 
            // txtLivingPlace
            // 
            this.txtLivingPlace.Location = new System.Drawing.Point(203, 145);
            this.txtLivingPlace.Name = "txtLivingPlace";
            this.txtLivingPlace.Size = new System.Drawing.Size(100, 20);
            this.txtLivingPlace.TabIndex = 2;
            this.txtLivingPlace.Text = "Travnička 115, Orehovec";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(344, 145);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNumber.TabIndex = 3;
            this.txtPhoneNumber.Text = "0912738416";
            // 
            // txtStatusGoldMember
            // 
            this.txtStatusGoldMember.Location = new System.Drawing.Point(203, 207);
            this.txtStatusGoldMember.Name = "txtStatusGoldMember";
            this.txtStatusGoldMember.Size = new System.Drawing.Size(100, 20);
            this.txtStatusGoldMember.TabIndex = 4;
            this.txtStatusGoldMember.Text = "DA";
            // 
            // txtBenefit
            // 
            this.txtBenefit.Location = new System.Drawing.Point(344, 207);
            this.txtBenefit.Name = "txtBenefit";
            this.txtBenefit.Size = new System.Drawing.Size(100, 20);
            this.txtBenefit.TabIndex = 5;
            this.txtBenefit.Text = "Popust";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(245, 275);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(141, 54);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Unesi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBenefit);
            this.Controls.Add(this.txtStatusGoldMember);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtLivingPlace);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Name = "FrmInsert";
            this.Text = "FrmInsert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtLivingPlace;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtStatusGoldMember;
        private System.Windows.Forms.TextBox txtBenefit;
        private System.Windows.Forms.Button btnSave;
    }
}