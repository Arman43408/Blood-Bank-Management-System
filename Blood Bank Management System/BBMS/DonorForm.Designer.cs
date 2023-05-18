
namespace BBMS
{
    partial class DonorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonorForm));
            this.lblDOB = new System.Windows.Forms.Label();
            this.txtOtherDisease = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblBMI = new System.Windows.Forms.Label();
            this.lblDisease = new System.Windows.Forms.Label();
            this.DonorDOB = new System.Windows.Forms.DateTimePicker();
            this.lblOtherDisease = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.comboBoxDisease = new System.Windows.Forms.ComboBox();
            this.txtBMI = new System.Windows.Forms.TextBox();
            this.lblBloodGroup = new System.Windows.Forms.Label();
            this.comboBoxBloodGroup = new System.Windows.Forms.ComboBox();
            this.lblState = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnCheckPass = new System.Windows.Forms.Button();
            this.lblContactMessage = new System.Windows.Forms.Label();
            this.lblRequirementMessage = new System.Windows.Forms.Label();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.donorInfoView = new System.Windows.Forms.DataGridView();
            this.lblEmailMessage = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donorInfoView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.BackColor = System.Drawing.Color.White;
            this.lblDOB.Location = new System.Drawing.Point(520, 48);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(87, 17);
            this.lblDOB.TabIndex = 0;
            this.lblDOB.Text = "Date of Birth";
            // 
            // txtOtherDisease
            // 
            this.txtOtherDisease.Location = new System.Drawing.Point(641, 337);
            this.txtOtherDisease.Name = "txtOtherDisease";
            this.txtOtherDisease.Size = new System.Drawing.Size(270, 22);
            this.txtOtherDisease.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(679, 440);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 31);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.Color.White;
            this.lblAge.Location = new System.Drawing.Point(574, 109);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(33, 17);
            this.lblAge.TabIndex = 3;
            this.lblAge.Text = "Age";
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.BackColor = System.Drawing.Color.White;
            this.lblBMI.Location = new System.Drawing.Point(576, 165);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(31, 17);
            this.lblBMI.TabIndex = 4;
            this.lblBMI.Text = "BMI";
            // 
            // lblDisease
            // 
            this.lblDisease.AutoSize = true;
            this.lblDisease.BackColor = System.Drawing.Color.White;
            this.lblDisease.Location = new System.Drawing.Point(548, 282);
            this.lblDisease.Name = "lblDisease";
            this.lblDisease.Size = new System.Drawing.Size(59, 17);
            this.lblDisease.TabIndex = 5;
            this.lblDisease.Text = "Disease";
            // 
            // DonorDOB
            // 
            this.DonorDOB.Location = new System.Drawing.Point(641, 43);
            this.DonorDOB.Name = "DonorDOB";
            this.DonorDOB.Size = new System.Drawing.Size(270, 22);
            this.DonorDOB.TabIndex = 6;
            this.DonorDOB.ValueChanged += new System.EventHandler(this.DonorDOB_ValueChanged);
            // 
            // lblOtherDisease
            // 
            this.lblOtherDisease.AutoSize = true;
            this.lblOtherDisease.BackColor = System.Drawing.Color.White;
            this.lblOtherDisease.Location = new System.Drawing.Point(508, 340);
            this.lblOtherDisease.Name = "lblOtherDisease";
            this.lblOtherDisease.Size = new System.Drawing.Size(99, 17);
            this.lblOtherDisease.TabIndex = 7;
            this.lblOtherDisease.Text = "Other Disease";
            // 
            // txtAge
            // 
            this.txtAge.Enabled = false;
            this.txtAge.Location = new System.Drawing.Point(641, 106);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(270, 22);
            this.txtAge.TabIndex = 8;
            this.txtAge.TextChanged += new System.EventHandler(this.txtAge_TextChanged);
            this.txtAge.MouseLeave += new System.EventHandler(this.txtAge_MouseLeave);
            this.txtAge.MouseHover += new System.EventHandler(this.txtAge_MouseHover);
            // 
            // comboBoxDisease
            // 
            this.comboBoxDisease.FormattingEnabled = true;
            this.comboBoxDisease.Items.AddRange(new object[] {
            "None",
            "High Pressure ",
            "Low Pressure",
            "Diabetes",
            "Lungs Problem",
            "Heart Problem",
            "Contagious Diseases",
            "Blood Infection",
            "Others"});
            this.comboBoxDisease.Location = new System.Drawing.Point(641, 279);
            this.comboBoxDisease.Name = "comboBoxDisease";
            this.comboBoxDisease.Size = new System.Drawing.Size(270, 24);
            this.comboBoxDisease.TabIndex = 11;
            // 
            // txtBMI
            // 
            this.txtBMI.Location = new System.Drawing.Point(641, 162);
            this.txtBMI.Name = "txtBMI";
            this.txtBMI.Size = new System.Drawing.Size(270, 22);
            this.txtBMI.TabIndex = 12;
            // 
            // lblBloodGroup
            // 
            this.lblBloodGroup.AutoSize = true;
            this.lblBloodGroup.BackColor = System.Drawing.Color.White;
            this.lblBloodGroup.Location = new System.Drawing.Point(519, 222);
            this.lblBloodGroup.Name = "lblBloodGroup";
            this.lblBloodGroup.Size = new System.Drawing.Size(88, 17);
            this.lblBloodGroup.TabIndex = 13;
            this.lblBloodGroup.Text = "Blood Group";
            // 
            // comboBoxBloodGroup
            // 
            this.comboBoxBloodGroup.FormattingEnabled = true;
            this.comboBoxBloodGroup.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.comboBoxBloodGroup.Location = new System.Drawing.Point(641, 219);
            this.comboBoxBloodGroup.Name = "comboBoxBloodGroup";
            this.comboBoxBloodGroup.Size = new System.Drawing.Size(270, 24);
            this.comboBoxBloodGroup.TabIndex = 14;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.BackColor = System.Drawing.Color.White;
            this.lblState.Location = new System.Drawing.Point(90, 162);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(41, 17);
            this.lblState.TabIndex = 15;
            this.lblState.Text = "State";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.BackColor = System.Drawing.Color.White;
            this.lblContact.Location = new System.Drawing.Point(75, 219);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(56, 17);
            this.lblContact.TabIndex = 16;
            this.lblContact.Text = "Contact";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(84, 279);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 17);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "E-mail";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(86, 46);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "Name";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(62, 106);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(73, 17);
            this.lblUsername.TabIndex = 19;
            this.lblUsername.Text = "Username";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(162, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(270, 22);
            this.txtName.TabIndex = 20;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(162, 103);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(270, 22);
            this.txtUsername.TabIndex = 21;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(162, 216);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(270, 22);
            this.txtContact.TabIndex = 23;
            this.txtContact.TextChanged += new System.EventHandler(this.txtContact_TextChanged);
            this.txtContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContact_KeyPress);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(162, 340);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(270, 22);
            this.txtPassword.TabIndex = 24;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.MouseLeave += new System.EventHandler(this.txtPassword_MouseLeave);
            this.txtPassword.MouseHover += new System.EventHandler(this.txtPassword_MouseHover);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(162, 276);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(270, 22);
            this.txtEmail.TabIndex = 25;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(62, 343);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 17);
            this.lblPassword.TabIndex = 26;
            this.lblPassword.Text = "Password";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(760, 440);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 31);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(841, 440);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 31);
            this.btnRemove.TabIndex = 28;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(4, 559);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(120, 35);
            this.btnGoBack.TabIndex = 29;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 597);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(982, 26);
            this.statusStrip1.TabIndex = 30;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // btnCheckPass
            // 
            this.btnCheckPass.Location = new System.Drawing.Point(230, 411);
            this.btnCheckPass.Name = "btnCheckPass";
            this.btnCheckPass.Size = new System.Drawing.Size(137, 31);
            this.btnCheckPass.TabIndex = 31;
            this.btnCheckPass.Text = "Check Password";
            this.btnCheckPass.UseVisualStyleBackColor = true;
            this.btnCheckPass.Click += new System.EventHandler(this.btnCheckPass_Click);
            // 
            // lblContactMessage
            // 
            this.lblContactMessage.AutoSize = true;
            this.lblContactMessage.BackColor = System.Drawing.Color.White;
            this.lblContactMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactMessage.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblContactMessage.Location = new System.Drawing.Point(159, 241);
            this.lblContactMessage.Name = "lblContactMessage";
            this.lblContactMessage.Size = new System.Drawing.Size(0, 17);
            this.lblContactMessage.TabIndex = 32;
            // 
            // lblRequirementMessage
            // 
            this.lblRequirementMessage.AutoSize = true;
            this.lblRequirementMessage.BackColor = System.Drawing.Color.White;
            this.lblRequirementMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequirementMessage.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblRequirementMessage.Location = new System.Drawing.Point(162, 369);
            this.lblRequirementMessage.Name = "lblRequirementMessage";
            this.lblRequirementMessage.Size = new System.Drawing.Size(0, 17);
            this.lblRequirementMessage.TabIndex = 33;
            // 
            // comboBoxState
            // 
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Items.AddRange(new object[] {
            "Dhaka",
            "Barishal",
            "Chattogram",
            "Khulna",
            "Rajshahi",
            "Rangpur",
            "Mymensingh",
            "Sylhet"});
            this.comboBoxState.Location = new System.Drawing.Point(162, 159);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(270, 24);
            this.comboBoxState.TabIndex = 34;
            // 
            // donorInfoView
            // 
            this.donorInfoView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.donorInfoView.Location = new System.Drawing.Point(365, 489);
            this.donorInfoView.Name = "donorInfoView";
            this.donorInfoView.RowHeadersWidth = 51;
            this.donorInfoView.RowTemplate.Height = 24;
            this.donorInfoView.Size = new System.Drawing.Size(551, 92);
            this.donorInfoView.TabIndex = 35;
            // 
            // lblEmailMessage
            // 
            this.lblEmailMessage.AutoSize = true;
            this.lblEmailMessage.BackColor = System.Drawing.Color.White;
            this.lblEmailMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailMessage.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblEmailMessage.Location = new System.Drawing.Point(159, 300);
            this.lblEmailMessage.Name = "lblEmailMessage";
            this.lblEmailMessage.Size = new System.Drawing.Size(0, 17);
            this.lblEmailMessage.TabIndex = 36;
            // 
            // DonorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(982, 623);
            this.Controls.Add(this.lblEmailMessage);
            this.Controls.Add(this.donorInfoView);
            this.Controls.Add(this.comboBoxState);
            this.Controls.Add(this.lblRequirementMessage);
            this.Controls.Add(this.lblContactMessage);
            this.Controls.Add(this.btnCheckPass);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.comboBoxBloodGroup);
            this.Controls.Add(this.lblBloodGroup);
            this.Controls.Add(this.txtBMI);
            this.Controls.Add(this.comboBoxDisease);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblOtherDisease);
            this.Controls.Add(this.DonorDOB);
            this.Controls.Add(this.lblDisease);
            this.Controls.Add(this.lblBMI);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtOtherDisease);
            this.Controls.Add(this.lblDOB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DonorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Donor Form";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donorInfoView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.TextBox txtOtherDisease;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Label lblDisease;
        private System.Windows.Forms.DateTimePicker DonorDOB;
        private System.Windows.Forms.Label lblOtherDisease;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.ComboBox comboBoxDisease;
        private System.Windows.Forms.TextBox txtBMI;
        private System.Windows.Forms.Label lblBloodGroup;
        private System.Windows.Forms.ComboBox comboBoxBloodGroup;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnCheckPass;
        private System.Windows.Forms.Label lblContactMessage;
        private System.Windows.Forms.Label lblRequirementMessage;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.ComboBox comboBoxState;
        private System.Windows.Forms.DataGridView donorInfoView;
        private System.Windows.Forms.Label lblEmailMessage;
    }
}