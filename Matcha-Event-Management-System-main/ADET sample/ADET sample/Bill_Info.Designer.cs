namespace ADET_sample
{
    partial class Bill_Info
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
            ExitButton = new ADETADET_sample.RBButton();
            EquipmentPanel = new Panel();
            BillBudgetTB = new TextBox();
            PesoSign = new Label();
            UNBudget = new TextBox();
            BudgetLabel = new Label();
            BillTypeTB = new TextBox();
            UNBillType = new TextBox();
            BillDueDateTB = new TextBox();
            UNdDate = new TextBox();
            BillerNameTB = new TextBox();
            UNBiller = new TextBox();
            BillerNameLabel = new Label();
            BillTypeLabel = new Label();
            BillID_Label = new Label();
            BillIDTB = new TextBox();
            DeleteBTN = new ADETADET_sample.RBButton();
            SaveBTN = new ADETADET_sample.RBButton();
            UNID = new TextBox();
            DDateLabel = new Label();
            EquipmentDetail = new Label();
            EquipmentPanel.SuspendLayout();
            SuspendLayout();
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
            ExitButton.Location = new Point(12, 275);
            ExitButton.Margin = new Padding(2, 3, 2, 3);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(492, 39);
            ExitButton.TabIndex = 65;
            ExitButton.Text = "Done";
            ExitButton.TextColor = Color.White;
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // EquipmentPanel
            // 
            EquipmentPanel.BorderStyle = BorderStyle.FixedSingle;
            EquipmentPanel.Controls.Add(BillBudgetTB);
            EquipmentPanel.Controls.Add(PesoSign);
            EquipmentPanel.Controls.Add(UNBudget);
            EquipmentPanel.Controls.Add(BudgetLabel);
            EquipmentPanel.Controls.Add(BillTypeTB);
            EquipmentPanel.Controls.Add(UNBillType);
            EquipmentPanel.Controls.Add(BillDueDateTB);
            EquipmentPanel.Controls.Add(UNdDate);
            EquipmentPanel.Controls.Add(BillerNameTB);
            EquipmentPanel.Controls.Add(UNBiller);
            EquipmentPanel.Controls.Add(BillerNameLabel);
            EquipmentPanel.Controls.Add(BillTypeLabel);
            EquipmentPanel.Controls.Add(BillID_Label);
            EquipmentPanel.Controls.Add(BillIDTB);
            EquipmentPanel.Controls.Add(DeleteBTN);
            EquipmentPanel.Controls.Add(SaveBTN);
            EquipmentPanel.Controls.Add(UNID);
            EquipmentPanel.Controls.Add(DDateLabel);
            EquipmentPanel.Location = new Point(12, 43);
            EquipmentPanel.Name = "EquipmentPanel";
            EquipmentPanel.Size = new Size(492, 226);
            EquipmentPanel.TabIndex = 64;
            // 
            // BillBudgetTB
            // 
            BillBudgetTB.BackColor = Color.FromArgb(223, 232, 215);
            BillBudgetTB.BorderStyle = BorderStyle.None;
            BillBudgetTB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BillBudgetTB.Location = new Point(257, 139);
            BillBudgetTB.Margin = new Padding(2, 3, 2, 3);
            BillBudgetTB.MaxLength = 50;
            BillBudgetTB.Name = "BillBudgetTB";
            BillBudgetTB.PlaceholderText = "00";
            BillBudgetTB.ReadOnly = true;
            BillBudgetTB.Size = new Size(134, 32);
            BillBudgetTB.TabIndex = 91;
            // 
            // PesoSign
            // 
            PesoSign.AutoSize = true;
            PesoSign.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            PesoSign.Location = new Point(227, 139);
            PesoSign.Margin = new Padding(4, 0, 4, 0);
            PesoSign.Name = "PesoSign";
            PesoSign.Size = new Size(29, 32);
            PesoSign.TabIndex = 92;
            PesoSign.Text = "₱";
            // 
            // UNBudget
            // 
            UNBudget.BackColor = Color.FromArgb(223, 232, 215);
            UNBudget.BorderStyle = BorderStyle.None;
            UNBudget.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UNBudget.Location = new Point(227, 143);
            UNBudget.Margin = new Padding(2, 3, 2, 3);
            UNBudget.Name = "UNBudget";
            UNBudget.ReadOnly = true;
            UNBudget.Size = new Size(164, 32);
            UNBudget.TabIndex = 90;
            UNBudget.Text = "__________________________________________";
            // 
            // BudgetLabel
            // 
            BudgetLabel.AutoSize = true;
            BudgetLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BudgetLabel.Location = new Point(6, 141);
            BudgetLabel.Margin = new Padding(4, 0, 4, 0);
            BudgetLabel.Name = "BudgetLabel";
            BudgetLabel.Size = new Size(222, 32);
            BudgetLabel.TabIndex = 89;
            BudgetLabel.Text = "Estimated Amount:";
            // 
            // BillTypeTB
            // 
            BillTypeTB.BackColor = Color.FromArgb(223, 232, 215);
            BillTypeTB.BorderStyle = BorderStyle.None;
            BillTypeTB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BillTypeTB.Location = new Point(116, 93);
            BillTypeTB.Margin = new Padding(2, 3, 2, 3);
            BillTypeTB.MaxLength = 50;
            BillTypeTB.Name = "BillTypeTB";
            BillTypeTB.PlaceholderText = "--";
            BillTypeTB.ReadOnly = true;
            BillTypeTB.Size = new Size(212, 32);
            BillTypeTB.TabIndex = 88;
            // 
            // UNBillType
            // 
            UNBillType.BackColor = Color.FromArgb(223, 232, 215);
            UNBillType.BorderStyle = BorderStyle.None;
            UNBillType.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UNBillType.Location = new Point(114, 97);
            UNBillType.Margin = new Padding(2, 3, 2, 3);
            UNBillType.Name = "UNBillType";
            UNBillType.ReadOnly = true;
            UNBillType.Size = new Size(214, 32);
            UNBillType.TabIndex = 87;
            UNBillType.Text = "__________________________________________";
            // 
            // BillDueDateTB
            // 
            BillDueDateTB.BackColor = Color.FromArgb(223, 232, 215);
            BillDueDateTB.BorderStyle = BorderStyle.None;
            BillDueDateTB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BillDueDateTB.Location = new Point(319, 4);
            BillDueDateTB.Margin = new Padding(2, 3, 2, 3);
            BillDueDateTB.MaxLength = 10;
            BillDueDateTB.Name = "BillDueDateTB";
            BillDueDateTB.PlaceholderText = "YYYY-MM-DD";
            BillDueDateTB.ReadOnly = true;
            BillDueDateTB.Size = new Size(163, 32);
            BillDueDateTB.TabIndex = 85;
            // 
            // UNdDate
            // 
            UNdDate.BackColor = Color.FromArgb(223, 232, 215);
            UNdDate.BorderStyle = BorderStyle.None;
            UNdDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UNdDate.Location = new Point(317, 8);
            UNdDate.Margin = new Padding(2, 3, 2, 3);
            UNdDate.Name = "UNdDate";
            UNdDate.ReadOnly = true;
            UNdDate.Size = new Size(162, 32);
            UNdDate.TabIndex = 84;
            UNdDate.Text = "__________________________________________";
            // 
            // BillerNameTB
            // 
            BillerNameTB.BackColor = Color.FromArgb(223, 232, 215);
            BillerNameTB.BorderStyle = BorderStyle.None;
            BillerNameTB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BillerNameTB.Location = new Point(159, 45);
            BillerNameTB.Margin = new Padding(2, 3, 2, 3);
            BillerNameTB.MaxLength = 50;
            BillerNameTB.Name = "BillerNameTB";
            BillerNameTB.PlaceholderText = "--";
            BillerNameTB.ReadOnly = true;
            BillerNameTB.Size = new Size(212, 32);
            BillerNameTB.TabIndex = 81;
            // 
            // UNBiller
            // 
            UNBiller.BackColor = Color.FromArgb(223, 232, 215);
            UNBiller.BorderStyle = BorderStyle.None;
            UNBiller.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UNBiller.Location = new Point(157, 49);
            UNBiller.Margin = new Padding(2, 3, 2, 3);
            UNBiller.Name = "UNBiller";
            UNBiller.ReadOnly = true;
            UNBiller.Size = new Size(214, 32);
            UNBiller.TabIndex = 80;
            UNBiller.Text = "__________________________________________";
            // 
            // BillerNameLabel
            // 
            BillerNameLabel.AutoSize = true;
            BillerNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BillerNameLabel.Location = new Point(6, 48);
            BillerNameLabel.Margin = new Padding(4, 0, 4, 0);
            BillerNameLabel.Name = "BillerNameLabel";
            BillerNameLabel.Size = new Size(154, 32);
            BillerNameLabel.TabIndex = 79;
            BillerNameLabel.Text = "Biller Name:";
            // 
            // BillTypeLabel
            // 
            BillTypeLabel.AutoSize = true;
            BillTypeLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BillTypeLabel.Location = new Point(8, 95);
            BillTypeLabel.Margin = new Padding(4, 0, 4, 0);
            BillTypeLabel.Name = "BillTypeLabel";
            BillTypeLabel.Size = new Size(111, 32);
            BillTypeLabel.TabIndex = 70;
            BillTypeLabel.Text = "Bill Type:";
            // 
            // BillID_Label
            // 
            BillID_Label.AutoSize = true;
            BillID_Label.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BillID_Label.Location = new Point(6, 7);
            BillID_Label.Margin = new Padding(4, 0, 4, 0);
            BillID_Label.Name = "BillID_Label";
            BillID_Label.Size = new Size(47, 32);
            BillID_Label.TabIndex = 69;
            BillID_Label.Text = "ID:";
            // 
            // BillIDTB
            // 
            BillIDTB.BackColor = Color.FromArgb(223, 232, 215);
            BillIDTB.BorderStyle = BorderStyle.None;
            BillIDTB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BillIDTB.Location = new Point(57, 3);
            BillIDTB.Margin = new Padding(2, 3, 2, 3);
            BillIDTB.MaxLength = 6;
            BillIDTB.Name = "BillIDTB";
            BillIDTB.PlaceholderText = "XXXXXX";
            BillIDTB.ReadOnly = true;
            BillIDTB.Size = new Size(94, 32);
            BillIDTB.TabIndex = 68;
            // 
            // DeleteBTN
            // 
            DeleteBTN.BackColor = Color.Firebrick;
            DeleteBTN.BackgroundColor = Color.Firebrick;
            DeleteBTN.BorderColor = Color.PaleVioletRed;
            DeleteBTN.BorderRadius = 8;
            DeleteBTN.BorderSize = 0;
            DeleteBTN.FlatAppearance.BorderSize = 0;
            DeleteBTN.FlatStyle = FlatStyle.Flat;
            DeleteBTN.ForeColor = Color.White;
            DeleteBTN.Location = new Point(246, 179);
            DeleteBTN.Margin = new Padding(2, 3, 2, 3);
            DeleteBTN.Name = "DeleteBTN";
            DeleteBTN.Size = new Size(239, 39);
            DeleteBTN.TabIndex = 58;
            DeleteBTN.Text = "Delete";
            DeleteBTN.TextColor = Color.White;
            DeleteBTN.UseVisualStyleBackColor = false;
            DeleteBTN.Click += DeleteBTN_Click;
            // 
            // SaveBTN
            // 
            SaveBTN.BackColor = Color.FromArgb(46, 60, 24);
            SaveBTN.BackgroundColor = Color.FromArgb(46, 60, 24);
            SaveBTN.BorderColor = Color.PaleVioletRed;
            SaveBTN.BorderRadius = 8;
            SaveBTN.BorderSize = 0;
            SaveBTN.FlatAppearance.BorderSize = 0;
            SaveBTN.FlatStyle = FlatStyle.Flat;
            SaveBTN.ForeColor = Color.White;
            SaveBTN.Location = new Point(2, 179);
            SaveBTN.Margin = new Padding(2, 3, 2, 3);
            SaveBTN.Name = "SaveBTN";
            SaveBTN.Size = new Size(243, 39);
            SaveBTN.TabIndex = 57;
            SaveBTN.Text = "Save";
            SaveBTN.TextColor = Color.White;
            SaveBTN.UseVisualStyleBackColor = false;
            SaveBTN.Click += SaveBTN_Click;
            // 
            // UNID
            // 
            UNID.BackColor = Color.FromArgb(223, 232, 215);
            UNID.BorderStyle = BorderStyle.None;
            UNID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UNID.Location = new Point(55, 7);
            UNID.Margin = new Padding(2, 3, 2, 3);
            UNID.Name = "UNID";
            UNID.ReadOnly = true;
            UNID.Size = new Size(96, 32);
            UNID.TabIndex = 67;
            UNID.Text = "__________________________________________";
            // 
            // DDateLabel
            // 
            DDateLabel.AutoSize = true;
            DDateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            DDateLabel.Location = new Point(193, 7);
            DDateLabel.Margin = new Padding(4, 0, 4, 0);
            DDateLabel.Name = "DDateLabel";
            DDateLabel.Size = new Size(127, 32);
            DDateLabel.TabIndex = 86;
            DDateLabel.Text = "Due Date:";
            // 
            // EquipmentDetail
            // 
            EquipmentDetail.AutoSize = true;
            EquipmentDetail.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            EquipmentDetail.Location = new Point(-1, 0);
            EquipmentDetail.Margin = new Padding(4, 0, 4, 0);
            EquipmentDetail.Name = "EquipmentDetail";
            EquipmentDetail.Size = new Size(257, 45);
            EquipmentDetail.TabIndex = 63;
            EquipmentDetail.Text = "Bill Information";
            // 
            // Bill_Info
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 232, 215);
            ClientSize = new Size(512, 319);
            Controls.Add(ExitButton);
            Controls.Add(EquipmentPanel);
            Controls.Add(EquipmentDetail);
            Name = "Bill_Info";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bill Information";
            EquipmentPanel.ResumeLayout(false);
            EquipmentPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ADETADET_sample.RBButton ExitButton;
        private Panel EquipmentPanel;
        private TextBox BillerNameTB;
        private TextBox UNBiller;
        private Label BillerNameLabel;
        private Label BillTypeLabel;
        private Label BillID_Label;
        private TextBox BillIDTB;
        private ADETADET_sample.RBButton DeleteBTN;
        private ADETADET_sample.RBButton SaveBTN;
        private TextBox UNID;
        private Label EquipmentDetail;
        private TextBox BillDueDateTB;
        private TextBox UNdDate;
        private Label DDateLabel;
        private TextBox BillTypeTB;
        private TextBox UNBillType;
        private TextBox BillBudgetTB;
        private TextBox UNBudget;
        private Label BudgetLabel;
        private Label PesoSign;
    }
}