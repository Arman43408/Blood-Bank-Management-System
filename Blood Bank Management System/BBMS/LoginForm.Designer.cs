
namespace BBMS
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.linkRegistration = new System.Windows.Forms.LinkLabel();
            this.btnShowPass = new System.Windows.Forms.Button();
            this.lblShowPass = new System.Windows.Forms.Label();
            this.rBtnDonor = new System.Windows.Forms.RadioButton();
            this.rBtnHospital = new System.Windows.Forms.RadioButton();
            this.rBtnBloodBank = new System.Windows.Forms.RadioButton();
            this.lblSelectOne = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(202, 394);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 28);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(62, 209);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(73, 17);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(202, 206);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(191, 22);
            this.txtUsername.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(66, 281);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 17);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(202, 278);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(191, 22);
            this.txtPassword.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblTitle.Location = new System.Drawing.Point(45, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(395, 30);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Blood Bank Management System";
            // 
            // linkRegistration
            // 
            this.linkRegistration.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkRegistration.AutoSize = true;
            this.linkRegistration.BackColor = System.Drawing.Color.White;
            this.linkRegistration.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkRegistration.Location = new System.Drawing.Point(165, 475);
            this.linkRegistration.Name = "linkRegistration";
            this.linkRegistration.Size = new System.Drawing.Size(141, 20);
            this.linkRegistration.TabIndex = 6;
            this.linkRegistration.TabStop = true;
            this.linkRegistration.Text = "Not a member yet? ";
            this.linkRegistration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRegistration_LinkClicked);
            // 
            // btnShowPass
            // 
            this.btnShowPass.Location = new System.Drawing.Point(270, 306);
            this.btnShowPass.Name = "btnShowPass";
            this.btnShowPass.Size = new System.Drawing.Size(123, 28);
            this.btnShowPass.TabIndex = 7;
            this.btnShowPass.Text = "Show Password";
            this.btnShowPass.UseVisualStyleBackColor = true;
            this.btnShowPass.Click += new System.EventHandler(this.btnShowPass_Click);
            // 
            // lblShowPass
            // 
            this.lblShowPass.AutoSize = true;
            this.lblShowPass.BackColor = System.Drawing.SystemColors.Window;
            this.lblShowPass.Location = new System.Drawing.Point(199, 340);
            this.lblShowPass.Name = "lblShowPass";
            this.lblShowPass.Size = new System.Drawing.Size(0, 17);
            this.lblShowPass.TabIndex = 8;
            // 
            // rBtnDonor
            // 
            this.rBtnDonor.AutoSize = true;
            this.rBtnDonor.BackColor = System.Drawing.Color.White;
            this.rBtnDonor.Location = new System.Drawing.Point(81, 142);
            this.rBtnDonor.Name = "rBtnDonor";
            this.rBtnDonor.Size = new System.Drawing.Size(68, 21);
            this.rBtnDonor.TabIndex = 9;
            this.rBtnDonor.TabStop = true;
            this.rBtnDonor.Text = "Donor";
            this.rBtnDonor.UseVisualStyleBackColor = false;
            this.rBtnDonor.CheckedChanged += new System.EventHandler(this.rBtnDonor_CheckedChanged);
            // 
            // rBtnHospital
            // 
            this.rBtnHospital.AutoSize = true;
            this.rBtnHospital.BackColor = System.Drawing.Color.White;
            this.rBtnHospital.Location = new System.Drawing.Point(169, 142);
            this.rBtnHospital.Name = "rBtnHospital";
            this.rBtnHospital.Size = new System.Drawing.Size(80, 21);
            this.rBtnHospital.TabIndex = 10;
            this.rBtnHospital.TabStop = true;
            this.rBtnHospital.Text = "Hospital";
            this.rBtnHospital.UseVisualStyleBackColor = false;
            this.rBtnHospital.CheckedChanged += new System.EventHandler(this.rBtnHospital_CheckedChanged);
            // 
            // rBtnBloodBank
            // 
            this.rBtnBloodBank.AutoSize = true;
            this.rBtnBloodBank.BackColor = System.Drawing.Color.White;
            this.rBtnBloodBank.Location = new System.Drawing.Point(273, 142);
            this.rBtnBloodBank.Name = "rBtnBloodBank";
            this.rBtnBloodBank.Size = new System.Drawing.Size(101, 21);
            this.rBtnBloodBank.TabIndex = 11;
            this.rBtnBloodBank.TabStop = true;
            this.rBtnBloodBank.Text = "Blood Bank";
            this.rBtnBloodBank.UseVisualStyleBackColor = false;
            this.rBtnBloodBank.CheckedChanged += new System.EventHandler(this.rBtnBloodBank_CheckedChanged);
            // 
            // lblSelectOne
            // 
            this.lblSelectOne.AutoSize = true;
            this.lblSelectOne.BackColor = System.Drawing.Color.White;
            this.lblSelectOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectOne.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblSelectOne.Location = new System.Drawing.Point(77, 112);
            this.lblSelectOne.Name = "lblSelectOne";
            this.lblSelectOne.Size = new System.Drawing.Size(79, 17);
            this.lblSelectOne.TabIndex = 12;
            this.lblSelectOne.Text = "Select one:";
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.lblSelectOne);
            this.Controls.Add(this.rBtnBloodBank);
            this.Controls.Add(this.rBtnHospital);
            this.Controls.Add(this.rBtnDonor);
            this.Controls.Add(this.lblShowPass);
            this.Controls.Add(this.btnShowPass);
            this.Controls.Add(this.linkRegistration);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnLogin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.LinkLabel linkRegistration;
        private System.Windows.Forms.Button btnShowPass;
        private System.Windows.Forms.Label lblShowPass;
        private System.Windows.Forms.RadioButton rBtnDonor;
        private System.Windows.Forms.RadioButton rBtnHospital;
        private System.Windows.Forms.RadioButton rBtnBloodBank;
        private System.Windows.Forms.Label lblSelectOne;
    }
}

