
namespace BBMS
{
    partial class SearchDonorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchDonorForm));
            this.lblCity = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblBloodGroup = new System.Windows.Forms.Label();
            this.comboBoxBloodGroup = new System.Windows.Forms.ComboBox();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.SearchInfoView = new System.Windows.Forms.DataGridView();
            this.btnDonorList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SearchInfoView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(68, 158);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(41, 17);
            this.lblCity.TabIndex = 10;
            this.lblCity.Text = "State";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(157, 232);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(124, 48);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblBloodGroup
            // 
            this.lblBloodGroup.AutoSize = true;
            this.lblBloodGroup.Location = new System.Drawing.Point(21, 80);
            this.lblBloodGroup.Name = "lblBloodGroup";
            this.lblBloodGroup.Size = new System.Drawing.Size(88, 17);
            this.lblBloodGroup.TabIndex = 7;
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
            this.comboBoxBloodGroup.Location = new System.Drawing.Point(157, 77);
            this.comboBoxBloodGroup.Name = "comboBoxBloodGroup";
            this.comboBoxBloodGroup.Size = new System.Drawing.Size(242, 24);
            this.comboBoxBloodGroup.TabIndex = 14;
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(24, 506);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(120, 35);
            this.btnGoBack.TabIndex = 28;
            this.btnGoBack.Text = "User Identity";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
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
            this.comboBoxState.Location = new System.Drawing.Point(157, 155);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(242, 24);
            this.comboBoxState.TabIndex = 29;
            // 
            // SearchInfoView
            // 
            this.SearchInfoView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchInfoView.Location = new System.Drawing.Point(427, 12);
            this.SearchInfoView.Name = "SearchInfoView";
            this.SearchInfoView.RowHeadersWidth = 51;
            this.SearchInfoView.RowTemplate.Height = 24;
            this.SearchInfoView.Size = new System.Drawing.Size(543, 529);
            this.SearchInfoView.TabIndex = 30;
            // 
            // btnDonorList
            // 
            this.btnDonorList.Location = new System.Drawing.Point(279, 506);
            this.btnDonorList.Name = "btnDonorList";
            this.btnDonorList.Size = new System.Drawing.Size(120, 35);
            this.btnDonorList.TabIndex = 31;
            this.btnDonorList.Text = "Donor List";
            this.btnDonorList.UseVisualStyleBackColor = true;
            this.btnDonorList.Click += new System.EventHandler(this.btnDonorList_Click);
            // 
            // SearchDonorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.btnDonorList);
            this.Controls.Add(this.SearchInfoView);
            this.Controls.Add(this.comboBoxState);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.comboBoxBloodGroup);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblBloodGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SearchDonorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search for Donor";
            ((System.ComponentModel.ISupportInitialize)(this.SearchInfoView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblBloodGroup;
        private System.Windows.Forms.ComboBox comboBoxBloodGroup;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.ComboBox comboBoxState;
        private System.Windows.Forms.DataGridView SearchInfoView;
        private System.Windows.Forms.Button btnDonorList;
    }
}