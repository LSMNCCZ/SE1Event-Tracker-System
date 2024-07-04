namespace ADET_sample
{
    partial class AddEquipment
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
            equipConCB = new ComboBox();
            equipStatusCB = new ComboBox();
            equipNameTB = new TextBox();
            UNName = new TextBox();
            equipNameLabel = new Label();
            EquipStatusLabel = new Label();
            equipTypeCB = new ComboBox();
            EquipConLabel = new Label();
            label1 = new Label();
            EquipID_Label = new Label();
            EquipIDTB = new TextBox();
            ClearBTN = new ADETADET_sample.RBButton();
            SaveEquipBTN = new ADETADET_sample.RBButton();
            UNID = new TextBox();
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
            ExitButton.Location = new Point(10, 275);
            ExitButton.Margin = new Padding(2, 3, 2, 3);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(492, 39);
            ExitButton.TabIndex = 62;
            ExitButton.Text = "Done";
            ExitButton.TextColor = Color.White;
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // EquipmentPanel
            // 
            EquipmentPanel.BorderStyle = BorderStyle.FixedSingle;
            EquipmentPanel.Controls.Add(equipConCB);
            EquipmentPanel.Controls.Add(equipStatusCB);
            EquipmentPanel.Controls.Add(equipNameTB);
            EquipmentPanel.Controls.Add(UNName);
            EquipmentPanel.Controls.Add(equipNameLabel);
            EquipmentPanel.Controls.Add(EquipStatusLabel);
            EquipmentPanel.Controls.Add(equipTypeCB);
            EquipmentPanel.Controls.Add(EquipConLabel);
            EquipmentPanel.Controls.Add(label1);
            EquipmentPanel.Controls.Add(EquipID_Label);
            EquipmentPanel.Controls.Add(EquipIDTB);
            EquipmentPanel.Controls.Add(ClearBTN);
            EquipmentPanel.Controls.Add(SaveEquipBTN);
            EquipmentPanel.Controls.Add(UNID);
            EquipmentPanel.Location = new Point(10, 52);
            EquipmentPanel.Name = "EquipmentPanel";
            EquipmentPanel.Size = new Size(492, 217);
            EquipmentPanel.TabIndex = 61;
            // 
            // equipConCB
            // 
            equipConCB.BackColor = Color.FromArgb(223, 232, 215);
            equipConCB.DropDownStyle = ComboBoxStyle.DropDownList;
            equipConCB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            equipConCB.FormattingEnabled = true;
            equipConCB.Items.AddRange(new object[] { "For Repair", "For Replacement", "For Testing", "Good-to-Go" });
            equipConCB.Location = new Point(210, 112);
            equipConCB.Margin = new Padding(2, 3, 2, 3);
            equipConCB.Name = "equipConCB";
            equipConCB.Size = new Size(209, 40);
            equipConCB.Sorted = true;
            equipConCB.TabIndex = 83;
            // 
            // equipStatusCB
            // 
            equipStatusCB.BackColor = Color.FromArgb(223, 232, 215);
            equipStatusCB.DropDownStyle = ComboBoxStyle.DropDownList;
            equipStatusCB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            equipStatusCB.FormattingEnabled = true;
            equipStatusCB.Items.AddRange(new object[] { "Deployed", "In-Studio" });
            equipStatusCB.Location = new Point(302, 54);
            equipStatusCB.Margin = new Padding(2, 3, 2, 3);
            equipStatusCB.Name = "equipStatusCB";
            equipStatusCB.Size = new Size(176, 40);
            equipStatusCB.Sorted = true;
            equipStatusCB.TabIndex = 82;
            // 
            // equipNameTB
            // 
            equipNameTB.BackColor = Color.FromArgb(223, 232, 215);
            equipNameTB.BorderStyle = BorderStyle.None;
            equipNameTB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            equipNameTB.Location = new Point(266, 7);
            equipNameTB.Margin = new Padding(2, 3, 2, 3);
            equipNameTB.MaxLength = 50;
            equipNameTB.Name = "equipNameTB";
            equipNameTB.PlaceholderText = "--";
            equipNameTB.ReadOnly = true;
            equipNameTB.Size = new Size(212, 32);
            equipNameTB.TabIndex = 81;
            // 
            // UNName
            // 
            UNName.BackColor = Color.FromArgb(223, 232, 215);
            UNName.BorderStyle = BorderStyle.None;
            UNName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UNName.Location = new Point(264, 12);
            UNName.Margin = new Padding(2, 3, 2, 3);
            UNName.Name = "UNName";
            UNName.ReadOnly = true;
            UNName.Size = new Size(214, 32);
            UNName.TabIndex = 80;
            UNName.Text = "__________________________________________";
            // 
            // equipNameLabel
            // 
            equipNameLabel.AutoSize = true;
            equipNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            equipNameLabel.Location = new Point(182, 7);
            equipNameLabel.Margin = new Padding(4, 0, 4, 0);
            equipNameLabel.Name = "equipNameLabel";
            equipNameLabel.Size = new Size(88, 32);
            equipNameLabel.TabIndex = 79;
            equipNameLabel.Text = "Name:";
            // 
            // EquipStatusLabel
            // 
            EquipStatusLabel.AutoSize = true;
            EquipStatusLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EquipStatusLabel.Location = new Point(221, 57);
            EquipStatusLabel.Margin = new Padding(4, 0, 4, 0);
            EquipStatusLabel.Name = "EquipStatusLabel";
            EquipStatusLabel.Size = new Size(87, 32);
            EquipStatusLabel.TabIndex = 78;
            EquipStatusLabel.Text = "Status:";
            // 
            // equipTypeCB
            // 
            equipTypeCB.BackColor = Color.FromArgb(223, 232, 215);
            equipTypeCB.DropDownStyle = ComboBoxStyle.DropDownList;
            equipTypeCB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            equipTypeCB.FormattingEnabled = true;
            equipTypeCB.Items.AddRange(new object[] { "Audio", "BG stand", "Box", "Camera", "Gimbals", "Laptop", "Lighting", "Monitor", "Printer", "Speedlight", "Tripod" });
            equipTypeCB.Location = new Point(72, 54);
            equipTypeCB.Margin = new Padding(2, 3, 2, 3);
            equipTypeCB.Name = "equipTypeCB";
            equipTypeCB.Size = new Size(135, 40);
            equipTypeCB.Sorted = true;
            equipTypeCB.TabIndex = 77;
            // 
            // EquipConLabel
            // 
            EquipConLabel.AutoSize = true;
            EquipConLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EquipConLabel.Location = new Point(87, 115);
            EquipConLabel.Margin = new Padding(4, 0, 4, 0);
            EquipConLabel.Name = "EquipConLabel";
            EquipConLabel.Size = new Size(126, 32);
            EquipConLabel.TabIndex = 76;
            EquipConLabel.Text = "Condition:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 57);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 32);
            label1.TabIndex = 70;
            label1.Text = "Type:";
            // 
            // EquipID_Label
            // 
            EquipID_Label.AutoSize = true;
            EquipID_Label.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            EquipID_Label.Location = new Point(6, 7);
            EquipID_Label.Margin = new Padding(4, 0, 4, 0);
            EquipID_Label.Name = "EquipID_Label";
            EquipID_Label.Size = new Size(47, 32);
            EquipID_Label.TabIndex = 69;
            EquipID_Label.Text = "ID:";
            // 
            // EquipIDTB
            // 
            EquipIDTB.BackColor = Color.FromArgb(223, 232, 215);
            EquipIDTB.BorderStyle = BorderStyle.None;
            EquipIDTB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EquipIDTB.Location = new Point(57, 7);
            EquipIDTB.Margin = new Padding(2, 3, 2, 3);
            EquipIDTB.MaxLength = 5;
            EquipIDTB.Name = "EquipIDTB";
            EquipIDTB.PlaceholderText = "XXXXX";
            EquipIDTB.ReadOnly = true;
            EquipIDTB.Size = new Size(94, 32);
            EquipIDTB.TabIndex = 68;
            // 
            // ClearBTN
            // 
            ClearBTN.BackColor = Color.Firebrick;
            ClearBTN.BackgroundColor = Color.Firebrick;
            ClearBTN.BorderColor = Color.PaleVioletRed;
            ClearBTN.BorderRadius = 8;
            ClearBTN.BorderSize = 0;
            ClearBTN.FlatAppearance.BorderSize = 0;
            ClearBTN.FlatStyle = FlatStyle.Flat;
            ClearBTN.ForeColor = Color.White;
            ClearBTN.Location = new Point(249, 171);
            ClearBTN.Margin = new Padding(2, 3, 2, 3);
            ClearBTN.Name = "ClearBTN";
            ClearBTN.Size = new Size(239, 39);
            ClearBTN.TabIndex = 58;
            ClearBTN.Text = "Clear";
            ClearBTN.TextColor = Color.White;
            ClearBTN.UseVisualStyleBackColor = false;
            ClearBTN.Click += ClearBTN_Click;
            // 
            // SaveEquipBTN
            // 
            SaveEquipBTN.BackColor = Color.FromArgb(46, 60, 24);
            SaveEquipBTN.BackgroundColor = Color.FromArgb(46, 60, 24);
            SaveEquipBTN.BorderColor = Color.PaleVioletRed;
            SaveEquipBTN.BorderRadius = 8;
            SaveEquipBTN.BorderSize = 0;
            SaveEquipBTN.FlatAppearance.BorderSize = 0;
            SaveEquipBTN.FlatStyle = FlatStyle.Flat;
            SaveEquipBTN.ForeColor = Color.White;
            SaveEquipBTN.Location = new Point(2, 171);
            SaveEquipBTN.Margin = new Padding(2, 3, 2, 3);
            SaveEquipBTN.Name = "SaveEquipBTN";
            SaveEquipBTN.Size = new Size(243, 39);
            SaveEquipBTN.TabIndex = 57;
            SaveEquipBTN.Text = "Save";
            SaveEquipBTN.TextColor = Color.White;
            SaveEquipBTN.UseVisualStyleBackColor = false;
            SaveEquipBTN.Click += SaveEquipBTN_Click;
            // 
            // UNID
            // 
            UNID.BackColor = Color.FromArgb(223, 232, 215);
            UNID.BorderStyle = BorderStyle.None;
            UNID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UNID.Location = new Point(55, 12);
            UNID.Margin = new Padding(2, 3, 2, 3);
            UNID.Name = "UNID";
            UNID.ReadOnly = true;
            UNID.Size = new Size(96, 32);
            UNID.TabIndex = 67;
            UNID.Text = "__________________________________________";
            // 
            // EquipmentDetail
            // 
            EquipmentDetail.AutoSize = true;
            EquipmentDetail.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            EquipmentDetail.Location = new Point(7, 4);
            EquipmentDetail.Margin = new Padding(4, 0, 4, 0);
            EquipmentDetail.Name = "EquipmentDetail";
            EquipmentDetail.Size = new Size(182, 45);
            EquipmentDetail.TabIndex = 60;
            EquipmentDetail.Text = "Equipment";
            // 
            // AddEquipment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 232, 215);
            ClientSize = new Size(512, 319);
            Controls.Add(ExitButton);
            Controls.Add(EquipmentPanel);
            Controls.Add(EquipmentDetail);
            Name = "AddEquipment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Studio Equipment";
            EquipmentPanel.ResumeLayout(false);
            EquipmentPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ADETADET_sample.RBButton ExitButton;
        private Panel EquipmentPanel;
        private Label EquipConLabel;
        private Label EquipID_Label;
        private TextBox EquipIDTB;
        private ADETADET_sample.RBButton ClearBTN;
        private ADETADET_sample.RBButton SaveEquipBTN;
        private TextBox UNID;
        private Label EquipmentDetail;
        private Label label1;
        private ComboBox equipTypeCB;
        private Label EquipStatusLabel;
        private TextBox UNName;
        private Label equipNameLabel;
        private ComboBox equipStatusCB;
        private TextBox equipNameTB;
        private ComboBox equipConCB;
    }
}