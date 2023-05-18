
namespace BBMS
{
    partial class UserIdentity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserIdentity));
            this.btnDonor = new System.Windows.Forms.Button();
            this.btnRecipient = new System.Windows.Forms.Button();
            this.btnHospital = new System.Windows.Forms.Button();
            this.btnBloodBank = new System.Windows.Forms.Button();
            this.lblChoose = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDonor
            // 
            this.btnDonor.BackColor = System.Drawing.Color.Snow;
            this.btnDonor.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonor.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnDonor.Location = new System.Drawing.Point(189, 135);
            this.btnDonor.Name = "btnDonor";
            this.btnDonor.Size = new System.Drawing.Size(141, 70);
            this.btnDonor.TabIndex = 0;
            this.btnDonor.Text = "Donor";
            this.btnDonor.UseVisualStyleBackColor = false;
            this.btnDonor.Click += new System.EventHandler(this.btnDonor_Click);
            // 
            // btnRecipient
            // 
            this.btnRecipient.BackColor = System.Drawing.Color.Snow;
            this.btnRecipient.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecipient.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnRecipient.Location = new System.Drawing.Point(636, 135);
            this.btnRecipient.Name = "btnRecipient";
            this.btnRecipient.Size = new System.Drawing.Size(141, 70);
            this.btnRecipient.TabIndex = 1;
            this.btnRecipient.Text = "Recipient";
            this.btnRecipient.UseVisualStyleBackColor = false;
            this.btnRecipient.Click += new System.EventHandler(this.btnRecipient_Click);
            // 
            // btnHospital
            // 
            this.btnHospital.BackColor = System.Drawing.Color.Snow;
            this.btnHospital.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHospital.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnHospital.Location = new System.Drawing.Point(189, 373);
            this.btnHospital.Name = "btnHospital";
            this.btnHospital.Size = new System.Drawing.Size(141, 70);
            this.btnHospital.TabIndex = 2;
            this.btnHospital.Text = "Hospital";
            this.btnHospital.UseVisualStyleBackColor = false;
            this.btnHospital.Click += new System.EventHandler(this.btnHospital_Click);
            // 
            // btnBloodBank
            // 
            this.btnBloodBank.BackColor = System.Drawing.Color.Snow;
            this.btnBloodBank.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBloodBank.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnBloodBank.Location = new System.Drawing.Point(636, 373);
            this.btnBloodBank.Name = "btnBloodBank";
            this.btnBloodBank.Size = new System.Drawing.Size(141, 70);
            this.btnBloodBank.TabIndex = 3;
            this.btnBloodBank.Text = "Blood Bank";
            this.btnBloodBank.UseVisualStyleBackColor = false;
            this.btnBloodBank.Click += new System.EventHandler(this.btnBloodBank_Click);
            // 
            // lblChoose
            // 
            this.lblChoose.AutoSize = true;
            this.lblChoose.BackColor = System.Drawing.Color.White;
            this.lblChoose.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoose.ForeColor = System.Drawing.Color.Black;
            this.lblChoose.Location = new System.Drawing.Point(33, 24);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(198, 31);
            this.lblChoose.TabIndex = 4;
            this.lblChoose.Text = "Your Identity - ";
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(12, 506);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(120, 35);
            this.btnGoBack.TabIndex = 5;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // UserIdentity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.lblChoose);
            this.Controls.Add(this.btnBloodBank);
            this.Controls.Add(this.btnHospital);
            this.Controls.Add(this.btnRecipient);
            this.Controls.Add(this.btnDonor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserIdentity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose Identity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDonor;
        private System.Windows.Forms.Button btnRecipient;
        private System.Windows.Forms.Button btnHospital;
        private System.Windows.Forms.Button btnBloodBank;
        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.Button btnGoBack;
    }
}