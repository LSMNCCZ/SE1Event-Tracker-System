namespace ADET_sample
{
    partial class EmployeeDetails
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
            UNEmpName = new TextBox();
            UNEmpID = new TextBox();
            EmpContactNumLabel = new Label();
            EmpName_Label = new Label();
            EmpID_Label = new Label();
            EmployeeDetail = new Label();
            EmployeePanel = new Panel();
            UNPassword = new TextBox();
            PasswordTB = new TextBox();
            PasswordLabel = new Label();
            EmpRoleTB = new ComboBox();
            UNempRole = new TextBox();
            empRoleLabel = new Label();
            EmpFBTB = new TextBox();
            EmpAddTB = new TextBox();
            EmpEmailTB = new TextBox();
            EmpNumTB = new TextBox();
            EmpIDTB = new TextBox();
            EmpNameTB = new TextBox();
            UNEmpAdd = new TextBox();
            UNEmpEmail = new TextBox();
            UNEmpFBName = new TextBox();
            UNEmpNum = new TextBox();
            Remove_EmployeeBTN = new ADETADET_sample.RBButton();
            Edit_EmployeeInfo = new ADETADET_sample.RBButton();
            EmpFBName = new Label();
            EmpAddressLabel = new Label();
            EmpEmailLabel = new Label();
            ExitButton = new ADETADET_sample.RBButton();
            EmployeePanel.SuspendLayout();
            SuspendLayout();
            // 
            // UNEmpName
            // 
            UNEmpName.BackColor = Color.FromArgb(223, 232, 215);
            UNEmpName.BorderStyle = BorderStyle.None;
            UNEmpName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UNEmpName.Location = new Point(92, 14);
            UNEmpName.Margin = new Padding(2, 3, 2, 3);
            UNEmpName.Name = "UNEmpName";
            UNEmpName.Size = new Size(355, 32);
            UNEmpName.TabIndex = 40;
            UNEmpName.Text = "__________________________________________";
            UNEmpName.ReadOnly = true;
            // 
            // UNEmpID
            // 
            UNEmpID.BackColor = Color.FromArgb(223, 232, 215);
            UNEmpID.BorderStyle = BorderStyle.None;
            UNEmpID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UNEmpID.Location = new Point(630, 14);
            UNEmpID.Margin = new Padding(2, 3, 2, 3);
            UNEmpID.Name = "UNEmpID";
            UNEmpID.Size = new Size(162, 32);
            UNEmpID.TabIndex = 39;
            UNEmpID.Text = "____________________________";
            UNEmpID.ReadOnly = true;
            // 
            // EmpContactNumLabel
            // 
            EmpContactNumLabel.AutoSize = true;
            EmpContactNumLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmpContactNumLabel.Location = new Point(470, 73);
            EmpContactNumLabel.Margin = new Padding(4, 0, 4, 0);
            EmpContactNumLabel.Name = "EmpContactNumLabel";
            EmpContactNumLabel.Size = new Size(150, 32);
            EmpContactNumLabel.TabIndex = 36;
            EmpContactNumLabel.Text = "Contact No.:";
            // 
            // EmpName_Label
            // 
            EmpName_Label.AutoSize = true;
            EmpName_Label.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            EmpName_Label.Location = new Point(7, 11);
            EmpName_Label.Margin = new Padding(4, 0, 4, 0);
            EmpName_Label.Name = "EmpName_Label";
            EmpName_Label.Size = new Size(88, 32);
            EmpName_Label.TabIndex = 34;
            EmpName_Label.Text = "Name:";
            // 
            // EmpID_Label
            // 
            EmpID_Label.AutoSize = true;
            EmpID_Label.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            EmpID_Label.Location = new Point(470, 11);
            EmpID_Label.Margin = new Padding(4, 0, 4, 0);
            EmpID_Label.Name = "EmpID_Label";
            EmpID_Label.Size = new Size(172, 32);
            EmpID_Label.TabIndex = 33;
            EmpID_Label.Text = "Employee ID: ";
            // 
            // EmployeeDetail
            // 
            EmployeeDetail.AutoSize = true;
            EmployeeDetail.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            EmployeeDetail.Location = new Point(15, 8);
            EmployeeDetail.Margin = new Padding(4, 0, 4, 0);
            EmployeeDetail.Name = "EmployeeDetail";
            EmployeeDetail.Size = new Size(263, 45);
            EmployeeDetail.TabIndex = 26;
            EmployeeDetail.Text = "Employee Detail";
            // 
            // EmployeePanel
            // 
            EmployeePanel.BorderStyle = BorderStyle.FixedSingle;
            EmployeePanel.Controls.Add(PasswordTB);
            EmployeePanel.Controls.Add(PasswordLabel);
            EmployeePanel.Controls.Add(EmpRoleTB);
            EmployeePanel.Controls.Add(UNempRole);
            EmployeePanel.Controls.Add(empRoleLabel);
            EmployeePanel.Controls.Add(EmpFBTB);
            EmployeePanel.Controls.Add(EmpAddTB);
            EmployeePanel.Controls.Add(EmpEmailTB);
            EmployeePanel.Controls.Add(EmpNumTB);
            EmployeePanel.Controls.Add(EmpIDTB);
            EmployeePanel.Controls.Add(EmpNameTB);
            EmployeePanel.Controls.Add(UNEmpAdd);
            EmployeePanel.Controls.Add(UNEmpEmail);
            EmployeePanel.Controls.Add(UNEmpFBName);
            EmployeePanel.Controls.Add(UNEmpNum);
            EmployeePanel.Controls.Add(Remove_EmployeeBTN);
            EmployeePanel.Controls.Add(Edit_EmployeeInfo);
            EmployeePanel.Controls.Add(EmpFBName);
            EmployeePanel.Controls.Add(EmpAddressLabel);
            EmployeePanel.Controls.Add(EmpEmailLabel);
            EmployeePanel.Controls.Add(UNEmpName);
            EmployeePanel.Controls.Add(UNEmpID);
            EmployeePanel.Controls.Add(EmpName_Label);
            EmployeePanel.Controls.Add(EmpContactNumLabel);
            EmployeePanel.Controls.Add(EmpID_Label);
            EmployeePanel.Controls.Add(UNPassword);
            EmployeePanel.Location = new Point(8, 52);
            EmployeePanel.Name = "EmployeePanel";
            EmployeePanel.Size = new Size(810, 328);
            EmployeePanel.TabIndex = 45;
            // 
            // UNPassword
            // 
            UNPassword.BackColor = Color.FromArgb(223, 232, 215);
            UNPassword.BorderStyle = BorderStyle.None;
            UNPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UNPassword.Location = new Point(573, 205);
            UNPassword.Margin = new Padding(2, 3, 2, 3);
            UNPassword.Name = "UNPassword";
            UNPassword.Size = new Size(219, 32);
            UNPassword.TabIndex = 72;
            UNPassword.Text = "____________________________";
            UNPassword.ReadOnly = true;
            // 
            // PasswordTB
            // 
            PasswordTB.BackColor = Color.FromArgb(223, 232, 215);
            PasswordTB.BorderStyle = BorderStyle.None;
            PasswordTB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PasswordTB.Location = new Point(573, 197);
            PasswordTB.Margin = new Padding(2, 3, 2, 3);
            PasswordTB.Name = "PasswordTB";
            PasswordTB.ReadOnly = true;
            PasswordTB.Size = new Size(219, 32);
            PasswordTB.TabIndex = 71;
            PasswordTB.Visible = false;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PasswordLabel.Location = new Point(460, 201);
            PasswordLabel.Margin = new Padding(4, 0, 4, 0);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(121, 32);
            PasswordLabel.TabIndex = 70;
            PasswordLabel.Text = "Password:";
            PasswordLabel.Visible = false;
            // 
            // EmpRoleTB
            // 
            EmpRoleTB.BackColor = Color.FromArgb(223, 232, 215);
            EmpRoleTB.DropDownStyle = ComboBoxStyle.DropDownList;
            EmpRoleTB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            EmpRoleTB.FormattingEnabled = true;
            EmpRoleTB.Items.AddRange(new object[] { "Admin", "Employee" });
            EmpRoleTB.Location = new Point(609, 131);
            EmpRoleTB.Margin = new Padding(2, 3, 2, 3);
            EmpRoleTB.Name = "EmpRoleTB";
            EmpRoleTB.Size = new Size(183, 40);
            EmpRoleTB.Sorted = true;
            EmpRoleTB.TabIndex = 69;
            EmpRoleTB.SelectedIndexChanged += EmpRoleTB_SelectedIndexChanged;
            // 
            // UNempRole
            // 
            UNempRole.BackColor = Color.FromArgb(223, 232, 215);
            UNempRole.BorderStyle = BorderStyle.None;
            UNempRole.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UNempRole.Location = new Point(609, 143);
            UNempRole.Margin = new Padding(2, 3, 2, 3);
            UNempRole.Name = "UNempRole";
            UNempRole.Size = new Size(183, 32);
            UNempRole.TabIndex = 68;
            UNempRole.Text = "____________________________";
            UNempRole.ReadOnly = true;
            // 
            // empRoleLabel
            // 
            empRoleLabel.AutoSize = true;
            empRoleLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            empRoleLabel.Location = new Point(470, 139);
            empRoleLabel.Margin = new Padding(4, 0, 4, 0);
            empRoleLabel.Name = "empRoleLabel";
            empRoleLabel.Size = new Size(143, 32);
            empRoleLabel.TabIndex = 67;
            empRoleLabel.Text = "Studio Role:";
            // 
            // EmpFBTB
            // 
            EmpFBTB.BackColor = Color.FromArgb(223, 232, 215);
            EmpFBTB.BorderStyle = BorderStyle.None;
            EmpFBTB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmpFBTB.Location = new Point(121, 72);
            EmpFBTB.Margin = new Padding(2, 3, 2, 3);
            EmpFBTB.Name = "EmpFBTB";
            EmpFBTB.ReadOnly = true;
            EmpFBTB.Size = new Size(326, 32);
            EmpFBTB.TabIndex = 66;
            // 
            // EmpAddTB
            // 
            EmpAddTB.BackColor = Color.FromArgb(223, 232, 215);
            EmpAddTB.BorderStyle = BorderStyle.None;
            EmpAddTB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmpAddTB.Location = new Point(14, 235);
            EmpAddTB.Margin = new Padding(2, 3, 2, 3);
            EmpAddTB.Name = "EmpAddTB";
            EmpAddTB.ReadOnly = true;
            EmpAddTB.Size = new Size(778, 32);
            EmpAddTB.TabIndex = 65;
            // 
            // EmpEmailTB
            // 
            EmpEmailTB.BackColor = Color.FromArgb(223, 232, 215);
            EmpEmailTB.BorderStyle = BorderStyle.None;
            EmpEmailTB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmpEmailTB.Location = new Point(92, 138);
            EmpEmailTB.Margin = new Padding(2, 3, 2, 3);
            EmpEmailTB.Name = "EmpEmailTB";
            EmpEmailTB.ReadOnly = true;
            EmpEmailTB.Size = new Size(355, 32);
            EmpEmailTB.TabIndex = 64;
            // 
            // EmpNumTB
            // 
            EmpNumTB.BackColor = Color.FromArgb(223, 232, 215);
            EmpNumTB.BorderStyle = BorderStyle.None;
            EmpNumTB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmpNumTB.Location = new Point(616, 72);
            EmpNumTB.Margin = new Padding(2, 3, 2, 3);
            EmpNumTB.Name = "EmpNumTB";
            EmpNumTB.ReadOnly = true;
            EmpNumTB.Size = new Size(176, 32);
            EmpNumTB.TabIndex = 63;
            // 
            // EmpIDTB
            // 
            EmpIDTB.BackColor = Color.FromArgb(223, 232, 215);
            EmpIDTB.BorderStyle = BorderStyle.None;
            EmpIDTB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmpIDTB.Location = new Point(630, 9);
            EmpIDTB.Margin = new Padding(2, 3, 2, 3);
            EmpIDTB.Name = "EmpIDTB";
            EmpIDTB.ReadOnly = true;
            EmpIDTB.Size = new Size(162, 32);
            EmpIDTB.TabIndex = 62;
            // 
            // EmpNameTB
            // 
            EmpNameTB.BackColor = Color.FromArgb(223, 232, 215);
            EmpNameTB.BorderStyle = BorderStyle.None;
            EmpNameTB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmpNameTB.Location = new Point(92, 9);
            EmpNameTB.Margin = new Padding(2, 3, 2, 3);
            EmpNameTB.Name = "EmpNameTB";
            EmpNameTB.ReadOnly = true;
            EmpNameTB.Size = new Size(355, 32);
            EmpNameTB.TabIndex = 61;
            // 
            // UNEmpAdd
            // 
            UNEmpAdd.BackColor = Color.FromArgb(223, 232, 215);
            UNEmpAdd.BorderStyle = BorderStyle.None;
            UNEmpAdd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UNEmpAdd.Location = new Point(14, 240);
            UNEmpAdd.Margin = new Padding(2, 3, 2, 3);
            UNEmpAdd.Name = "UNEmpAdd";
            UNEmpAdd.Size = new Size(778, 32);
            UNEmpAdd.TabIndex = 60;
            UNEmpAdd.Text = "____________________________________________________________________________________________________________";
            UNEmpAdd.ReadOnly = true;
            // 
            // UNEmpEmail
            // 
            UNEmpEmail.BackColor = Color.FromArgb(223, 232, 215);
            UNEmpEmail.BorderStyle = BorderStyle.None;
            UNEmpEmail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UNEmpEmail.Location = new Point(92, 143);
            UNEmpEmail.Margin = new Padding(2, 3, 2, 3);
            UNEmpEmail.Name = "UNEmpEmail";
            UNEmpEmail.Size = new Size(355, 32);
            UNEmpEmail.TabIndex = 59;
            UNEmpEmail.Text = "__________________________________________";
            UNEmpEmail.ReadOnly = true;
            // 
            // UNEmpFBName
            // 
            UNEmpFBName.BackColor = Color.FromArgb(223, 232, 215);
            UNEmpFBName.BorderStyle = BorderStyle.None;
            UNEmpFBName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UNEmpFBName.Location = new Point(121, 77);
            UNEmpFBName.Margin = new Padding(2, 3, 2, 3);
            UNEmpFBName.Name = "UNEmpFBName";
            UNEmpFBName.Size = new Size(326, 32);
            UNEmpFBName.TabIndex = 58;
            UNEmpFBName.Text = "__________________________________________";
            UNEmpFBName.ReadOnly = true;
            // 
            // UNEmpNum
            // 
            UNEmpNum.BackColor = Color.FromArgb(223, 232, 215);
            UNEmpNum.BorderStyle = BorderStyle.None;
            UNEmpNum.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UNEmpNum.Location = new Point(616, 77);
            UNEmpNum.Margin = new Padding(2, 3, 2, 3);
            UNEmpNum.Name = "UNEmpNum";
            UNEmpNum.Size = new Size(176, 32);
            UNEmpNum.TabIndex = 57;
            UNEmpNum.Text = "____________________________";
            UNEmpNum.ReadOnly = true;
            // 
            // Remove_EmployeeBTN
            // 
            Remove_EmployeeBTN.BackColor = Color.Firebrick;
            Remove_EmployeeBTN.BackgroundColor = Color.Firebrick;
            Remove_EmployeeBTN.BorderColor = Color.PaleVioletRed;
            Remove_EmployeeBTN.BorderRadius = 8;
            Remove_EmployeeBTN.BorderSize = 0;
            Remove_EmployeeBTN.FlatAppearance.BorderSize = 0;
            Remove_EmployeeBTN.FlatStyle = FlatStyle.Flat;
            Remove_EmployeeBTN.ForeColor = Color.White;
            Remove_EmployeeBTN.Location = new Point(408, 284);
            Remove_EmployeeBTN.Margin = new Padding(2, 3, 2, 3);
            Remove_EmployeeBTN.Name = "Remove_EmployeeBTN";
            Remove_EmployeeBTN.Size = new Size(398, 39);
            Remove_EmployeeBTN.TabIndex = 56;
            Remove_EmployeeBTN.Text = "Remove";
            Remove_EmployeeBTN.TextColor = Color.White;
            Remove_EmployeeBTN.UseVisualStyleBackColor = false;
            Remove_EmployeeBTN.Click += Remove_EmployeeBTN_Click;
            // 
            // Edit_EmployeeInfo
            // 
            Edit_EmployeeInfo.BackColor = Color.FromArgb(46, 60, 24);
            Edit_EmployeeInfo.BackgroundColor = Color.FromArgb(46, 60, 24);
            Edit_EmployeeInfo.BorderColor = Color.PaleVioletRed;
            Edit_EmployeeInfo.BorderRadius = 8;
            Edit_EmployeeInfo.BorderSize = 0;
            Edit_EmployeeInfo.FlatAppearance.BorderSize = 0;
            Edit_EmployeeInfo.FlatStyle = FlatStyle.Flat;
            Edit_EmployeeInfo.ForeColor = Color.White;
            Edit_EmployeeInfo.Location = new Point(2, 284);
            Edit_EmployeeInfo.Margin = new Padding(2, 3, 2, 3);
            Edit_EmployeeInfo.Name = "Edit_EmployeeInfo";
            Edit_EmployeeInfo.Size = new Size(398, 39);
            Edit_EmployeeInfo.TabIndex = 55;
            Edit_EmployeeInfo.Text = "Edit";
            Edit_EmployeeInfo.TextColor = Color.White;
            Edit_EmployeeInfo.UseVisualStyleBackColor = false;
            Edit_EmployeeInfo.Click += Edit_EmployeeInfo_Click;
            // 
            // EmpFBName
            // 
            EmpFBName.AutoSize = true;
            EmpFBName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            EmpFBName.Location = new Point(7, 73);
            EmpFBName.Margin = new Padding(4, 0, 4, 0);
            EmpFBName.Name = "EmpFBName";
            EmpFBName.Size = new Size(119, 32);
            EmpFBName.TabIndex = 54;
            EmpFBName.Text = "FB Name:";
            // 
            // EmpAddressLabel
            // 
            EmpAddressLabel.AutoSize = true;
            EmpAddressLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            EmpAddressLabel.Location = new Point(7, 201);
            EmpAddressLabel.Margin = new Padding(4, 0, 4, 0);
            EmpAddressLabel.Name = "EmpAddressLabel";
            EmpAddressLabel.Size = new Size(106, 32);
            EmpAddressLabel.TabIndex = 53;
            EmpAddressLabel.Text = "Address:";
            // 
            // EmpEmailLabel
            // 
            EmpEmailLabel.AutoSize = true;
            EmpEmailLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            EmpEmailLabel.Location = new Point(7, 139);
            EmpEmailLabel.Margin = new Padding(4, 0, 4, 0);
            EmpEmailLabel.Name = "EmpEmailLabel";
            EmpEmailLabel.Size = new Size(88, 32);
            EmpEmailLabel.TabIndex = 52;
            EmpEmailLabel.Text = "E-mail:";
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.FromArgb(46, 60, 24);
            ExitButton.BackgroundColor = Color.FromArgb(46, 60, 24);
            ExitButton.BorderColor = Color.PaleVioletRed;
            ExitButton.BorderRadius = 8;
            ExitButton.BorderSize = 0;
            ExitButton.FlatAppearance.BorderSize = 0;
            ExitButton.FlatStyle = FlatStyle.Flat;
            ExitButton.ForeColor = Color.White;
            ExitButton.Location = new Point(7, 383);
            ExitButton.Margin = new Padding(2, 3, 2, 3);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(811, 39);
            ExitButton.TabIndex = 57;
            ExitButton.Text = "Done";
            ExitButton.TextColor = Color.White;
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // EmployeeDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 232, 215);
            ClientSize = new Size(829, 425);
            Controls.Add(ExitButton);
            Controls.Add(EmployeePanel);
            Controls.Add(EmployeeDetail);
            Margin = new Padding(4);
            Name = "EmployeeDetails";
            Text = "Employee Detail";
            EmployeePanel.ResumeLayout(false);
            EmployeePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox UNEmpName;
        private TextBox UNEmpID;
        private Label EmpContactNumLabel;
        private Label EmpName_Label;
        private Label EmpID_Label;
        private Label EmployeeDetail;
        private Panel EmployeePanel;
        private Label EmpEmailLabel;
        private Label EmpAddressLabel;
        private Label EmpFBName;
        private ADETADET_sample.RBButton Remove_EmployeeBTN;
        private ADETADET_sample.RBButton Edit_EmployeeInfo;
        private ADETADET_sample.RBButton ExitButton;
        private TextBox UNEmpAdd;
        private TextBox UNEmpEmail;
        private TextBox UNEmpFBName;
        private TextBox UNEmpNum;
        private TextBox EmpIDTB;
        private TextBox EmpNameTB;
        private TextBox EmpAddTB;
        private TextBox EmpEmailTB;
        private TextBox EmpNumTB;
        private TextBox EmpFBTB;
        private TextBox UNempRole;
        private Label empRoleLabel;
        private ComboBox EmpRoleTB;
        private TextBox UNPassword;
        private TextBox PasswordTB;
        private Label PasswordLabel;
        private DataGridView EmployeeListDataGrid;
    }
}