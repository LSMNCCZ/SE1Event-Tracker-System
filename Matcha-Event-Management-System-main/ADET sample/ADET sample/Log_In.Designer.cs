namespace ADET_sample
{
    partial class Log_In
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
            LoginBTN = new ADETADET_sample.RBButton();
            EquipmentPanel = new Panel();
            PasswordLabel = new Label();
            PasswordTB = new TextBox();
            ID_Label = new Label();
            EmpIDTB = new TextBox();
            EquipmentDetail = new Label();
            Logo = new PictureBox();
            EquipmentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // LoginBTN
            // 
            LoginBTN.BackColor = Color.FromArgb(46, 60, 24);
            LoginBTN.BackgroundColor = Color.FromArgb(46, 60, 24);
            LoginBTN.BorderColor = Color.PaleVioletRed;
            LoginBTN.BorderRadius = 8;
            LoginBTN.BorderSize = 0;
            LoginBTN.FlatAppearance.BorderSize = 0;
            LoginBTN.FlatStyle = FlatStyle.Flat;
            LoginBTN.ForeColor = Color.White;
            LoginBTN.Location = new Point(1, 196);
            LoginBTN.Margin = new Padding(2, 3, 2, 3);
            LoginBTN.Name = "LoginBTN";
            LoginBTN.Size = new Size(392, 39);
            LoginBTN.TabIndex = 68;
            LoginBTN.Text = "Log In";
            LoginBTN.TextColor = Color.White;
            LoginBTN.UseVisualStyleBackColor = false;
            LoginBTN.Click += LoginBTN_Click;
            // 
            // EquipmentPanel
            // 
            EquipmentPanel.BorderStyle = BorderStyle.FixedSingle;
            EquipmentPanel.Controls.Add(PasswordLabel);
            EquipmentPanel.Controls.Add(LoginBTN);
            EquipmentPanel.Controls.Add(PasswordTB);
            EquipmentPanel.Controls.Add(ID_Label);
            EquipmentPanel.Controls.Add(EmpIDTB);
            EquipmentPanel.Location = new Point(4, 197);
            EquipmentPanel.Name = "EquipmentPanel";
            EquipmentPanel.Size = new Size(397, 240);
            EquipmentPanel.TabIndex = 67;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            PasswordLabel.Location = new Point(13, 102);
            PasswordLabel.Margin = new Padding(4, 0, 4, 0);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(129, 32);
            PasswordLabel.TabIndex = 71;
            PasswordLabel.Text = "Password:";
            // 
            // PasswordTB
            // 
            PasswordTB.BackColor = Color.FromArgb(223, 232, 215);
            PasswordTB.BorderStyle = BorderStyle.FixedSingle;
            PasswordTB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PasswordTB.ForeColor = SystemColors.InactiveCaptionText;
            PasswordTB.Location = new Point(20, 137);
            PasswordTB.Margin = new Padding(2, 3, 2, 3);
            PasswordTB.MaxLength = 50;
            PasswordTB.Name = "PasswordTB";
            PasswordTB.PlaceholderText = "Password";
            PasswordTB.ScrollBars = ScrollBars.Both;
            PasswordTB.Size = new Size(355, 39);
            PasswordTB.TabIndex = 70;
            PasswordTB.TextAlign = HorizontalAlignment.Center;
            PasswordTB.UseSystemPasswordChar = true;
            PasswordTB.Click += PasswordTB_Click;
            // 
            // ID_Label
            // 
            ID_Label.AutoSize = true;
            ID_Label.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ID_Label.Location = new Point(13, 15);
            ID_Label.Margin = new Padding(4, 0, 4, 0);
            ID_Label.Name = "ID_Label";
            ID_Label.Size = new Size(165, 32);
            ID_Label.TabIndex = 69;
            ID_Label.Text = "Employee ID:";
            // 
            // EmpIDTB
            // 
            EmpIDTB.BackColor = Color.FromArgb(223, 232, 215);
            EmpIDTB.BorderStyle = BorderStyle.FixedSingle;
            EmpIDTB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmpIDTB.ForeColor = SystemColors.InactiveCaptionText;
            EmpIDTB.Location = new Point(20, 50);
            EmpIDTB.Margin = new Padding(2, 3, 2, 3);
            EmpIDTB.MaxLength = 5;
            EmpIDTB.Name = "EmpIDTB";
            EmpIDTB.PlaceholderText = "Employee ID";
            EmpIDTB.Size = new Size(355, 39);
            EmpIDTB.TabIndex = 68;
            EmpIDTB.TextAlign = HorizontalAlignment.Center;
            EmpIDTB.Click += EmpIDTB_Click;
            // 
            // EquipmentDetail
            // 
            EquipmentDetail.AutoSize = true;
            EquipmentDetail.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            EquipmentDetail.Location = new Point(70, 145);
            EquipmentDetail.Margin = new Padding(4, 0, 4, 0);
            EquipmentDetail.Name = "EquipmentDetail";
            EquipmentDetail.Size = new Size(259, 45);
            EquipmentDetail.TabIndex = 66;
            EquipmentDetail.Text = "Employee Login";
            EquipmentDetail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Logo
            // 
            Logo.BackgroundImageLayout = ImageLayout.Center;
            Logo.Image = Properties.Resources.Front2;
            Logo.Location = new Point(12, 12);
            Logo.Name = "Logo";
            Logo.Size = new Size(377, 130);
            Logo.SizeMode = PictureBoxSizeMode.Zoom;
            Logo.TabIndex = 69;
            Logo.TabStop = false;
            // 
            // Log_In
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 232, 215);
            ClientSize = new Size(406, 443);
            Controls.Add(Logo);
            Controls.Add(EquipmentPanel);
            Controls.Add(EquipmentDetail);
            Name = "Log_In";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log In";
            EquipmentPanel.ResumeLayout(false);
            EquipmentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ADETADET_sample.RBButton LoginBTN;
        private Panel EquipmentPanel;
        private Label ID_Label;
        private TextBox EmpIDTB;
        private Label EquipmentDetail;
        private PictureBox Logo;
        private Label PasswordLabel;
        private TextBox PasswordTB;
    }
}