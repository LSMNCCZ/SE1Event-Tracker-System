namespace ADET_sample
{
    partial class NewAddOn
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
            EmployeeDetail = new Label();
            AddonPanel = new Panel();
            AddOnDescTB = new TextBox();
            AddOnDescLabel = new Label();
            AddOnPriceTB = new TextBox();
            label1 = new Label();
            AddOnID_Label = new Label();
            AddOnIDTB = new TextBox();
            ClearBTN = new ADETADET_sample.RBButton();
            SaveAddOnBTN = new ADETADET_sample.RBButton();
            UNID = new TextBox();
            PesoSign = new Label();
            UNPrice = new TextBox();
            ExitButton = new ADETADET_sample.RBButton();
            AddonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // EmployeeDetail
            // 
            EmployeeDetail.AutoSize = true;
            EmployeeDetail.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            EmployeeDetail.Location = new Point(1, 2);
            EmployeeDetail.Margin = new Padding(4, 0, 4, 0);
            EmployeeDetail.Name = "EmployeeDetail";
            EmployeeDetail.Size = new Size(225, 45);
            EmployeeDetail.TabIndex = 27;
            EmployeeDetail.Text = "New Add-On ";
            // 
            // AddonPanel
            // 
            AddonPanel.BorderStyle = BorderStyle.FixedSingle;
            AddonPanel.Controls.Add(AddOnDescTB);
            AddonPanel.Controls.Add(AddOnDescLabel);
            AddonPanel.Controls.Add(AddOnPriceTB);
            AddonPanel.Controls.Add(label1);
            AddonPanel.Controls.Add(AddOnID_Label);
            AddonPanel.Controls.Add(AddOnIDTB);
            AddonPanel.Controls.Add(ClearBTN);
            AddonPanel.Controls.Add(SaveAddOnBTN);
            AddonPanel.Controls.Add(UNID);
            AddonPanel.Controls.Add(PesoSign);
            AddonPanel.Controls.Add(UNPrice);
            AddonPanel.Location = new Point(8, 50);
            AddonPanel.Name = "AddonPanel";
            AddonPanel.Size = new Size(492, 217);
            AddonPanel.TabIndex = 47;
            // 
            // AddOnDescTB
            // 
            AddOnDescTB.BackColor = Color.FromArgb(223, 232, 215);
            AddOnDescTB.BorderStyle = BorderStyle.FixedSingle;
            AddOnDescTB.Location = new Point(14, 88);
            AddOnDescTB.Margin = new Padding(2, 3, 2, 3);
            AddOnDescTB.Multiline = true;
            AddOnDescTB.Name = "AddOnDescTB";
            AddOnDescTB.Size = new Size(457, 79);
            AddOnDescTB.TabIndex = 77;
            // 
            // AddOnDescLabel
            // 
            AddOnDescLabel.AutoSize = true;
            AddOnDescLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddOnDescLabel.Location = new Point(6, 53);
            AddOnDescLabel.Margin = new Padding(4, 0, 4, 0);
            AddOnDescLabel.Name = "AddOnDescLabel";
            AddOnDescLabel.Size = new Size(143, 32);
            AddOnDescLabel.TabIndex = 76;
            AddOnDescLabel.Text = "Description:";
            // 
            // AddOnPriceTB
            // 
            AddOnPriceTB.BackColor = Color.FromArgb(223, 232, 215);
            AddOnPriceTB.BorderStyle = BorderStyle.None;
            AddOnPriceTB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddOnPriceTB.Location = new Point(369, 7);
            AddOnPriceTB.Margin = new Padding(2, 3, 2, 3);
            AddOnPriceTB.Name = "AddOnPriceTB";
            AddOnPriceTB.ReadOnly = true;
            AddOnPriceTB.Size = new Size(96, 32);
            AddOnPriceTB.TabIndex = 71;
            AddOnPriceTB.Text = "00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(270, 7);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(73, 32);
            label1.TabIndex = 70;
            label1.Text = "Price:";
            // 
            // AddOnID_Label
            // 
            AddOnID_Label.AutoSize = true;
            AddOnID_Label.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            AddOnID_Label.Location = new Point(6, 7);
            AddOnID_Label.Margin = new Padding(4, 0, 4, 0);
            AddOnID_Label.Name = "AddOnID_Label";
            AddOnID_Label.Size = new Size(47, 32);
            AddOnID_Label.TabIndex = 69;
            AddOnID_Label.Text = "ID:";
            // 
            // AddOnIDTB
            // 
            AddOnIDTB.BackColor = Color.FromArgb(223, 232, 215);
            AddOnIDTB.BorderStyle = BorderStyle.None;
            AddOnIDTB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddOnIDTB.Location = new Point(57, 7);
            AddOnIDTB.Margin = new Padding(2, 3, 2, 3);
            AddOnIDTB.MaxLength = 5;
            AddOnIDTB.Name = "AddOnIDTB";
            AddOnIDTB.ReadOnly = true;
            AddOnIDTB.Size = new Size(94, 32);
            AddOnIDTB.TabIndex = 68;
            AddOnIDTB.Text = "XXXXX";
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
            // SaveAddOnBTN
            // 
            SaveAddOnBTN.BackColor = Color.FromArgb(46, 60, 24);
            SaveAddOnBTN.BackgroundColor = Color.FromArgb(46, 60, 24);
            SaveAddOnBTN.BorderColor = Color.PaleVioletRed;
            SaveAddOnBTN.BorderRadius = 8;
            SaveAddOnBTN.BorderSize = 0;
            SaveAddOnBTN.FlatAppearance.BorderSize = 0;
            SaveAddOnBTN.FlatStyle = FlatStyle.Flat;
            SaveAddOnBTN.ForeColor = Color.White;
            SaveAddOnBTN.Location = new Point(2, 171);
            SaveAddOnBTN.Margin = new Padding(2, 3, 2, 3);
            SaveAddOnBTN.Name = "SaveAddOnBTN";
            SaveAddOnBTN.Size = new Size(243, 39);
            SaveAddOnBTN.TabIndex = 57;
            SaveAddOnBTN.Text = "Save";
            SaveAddOnBTN.TextColor = Color.White;
            SaveAddOnBTN.UseVisualStyleBackColor = false;
            SaveAddOnBTN.Click += SaveAddOnBTN_Click;
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
            // PesoSign
            // 
            PesoSign.AutoSize = true;
            PesoSign.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            PesoSign.Location = new Point(344, 7);
            PesoSign.Margin = new Padding(4, 0, 4, 0);
            PesoSign.Name = "PesoSign";
            PesoSign.Size = new Size(29, 32);
            PesoSign.TabIndex = 75;
            PesoSign.Text = "₱";
            // 
            // UNPrice
            // 
            UNPrice.BackColor = Color.FromArgb(223, 232, 215);
            UNPrice.BorderStyle = BorderStyle.None;
            UNPrice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UNPrice.Location = new Point(365, 12);
            UNPrice.Margin = new Padding(2, 3, 2, 3);
            UNPrice.Name = "UNPrice";
            UNPrice.ReadOnly = true;
            UNPrice.Size = new Size(96, 32);
            UNPrice.TabIndex = 72;
            UNPrice.Text = "__________________________________________";
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
            ExitButton.Location = new Point(8, 273);
            ExitButton.Margin = new Padding(2, 3, 2, 3);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(492, 39);
            ExitButton.TabIndex = 59;
            ExitButton.Text = "Done";
            ExitButton.TextColor = Color.White;
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // NewAddOn
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 232, 215);
            ClientSize = new Size(512, 319);
            Controls.Add(ExitButton);
            Controls.Add(AddonPanel);
            Controls.Add(EmployeeDetail);
            Name = "NewAddOn";
            Text = "New Add-On";
            AddonPanel.ResumeLayout(false);
            AddonPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EmployeeDetail;
        private Panel AddonPanel;
        private ADETADET_sample.RBButton ClearBTN;
        private ADETADET_sample.RBButton SaveAddOnBTN;
        private ADETADET_sample.RBButton ExitButton;
        private TextBox AddOnIDTB;
        private TextBox UNID;
        private Label label1;
        private Label AddOnID_Label;
        private TextBox UNPrice;
        private TextBox AddOnPriceTB;
        private Label AddOnDescLabel;
        private Label PesoSign;
        private TextBox AddOnDescTB;
    }
}