namespace ADET_sample
{
    partial class Packages
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
            PackageLabel = new Label();
            EmployeePanel = new Panel();
            ServPriceTB = new TextBox();
            InclusionLabel = new Label();
            ServEmPayTB = new TextBox();
            label1 = new Label();
            EmPayLabel = new Label();
            PesoSign = new Label();
            PriceLabel = new Label();
            EmpFBName = new Label();
            ServIDTB = new TextBox();
            InclusionTB = new TextBox();
            ServiceNameTB = new TextBox();
            EditPackageBTN = new ADETADET_sample.RBButton();
            RemovePackageBTN = new ADETADET_sample.RBButton();
            UNServName = new TextBox();
            UNServID = new TextBox();
            UNPrice = new TextBox();
            UNEmPay = new TextBox();
            ExitButton = new ADETADET_sample.RBButton();
            EmployeePanel.SuspendLayout();
            SuspendLayout();
            // 
            // PackageLabel
            // 
            PackageLabel.AutoSize = true;
            PackageLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            PackageLabel.Location = new Point(1, 5);
            PackageLabel.Margin = new Padding(4, 0, 4, 0);
            PackageLabel.Name = "PackageLabel";
            PackageLabel.Size = new Size(238, 45);
            PackageLabel.TabIndex = 27;
            PackageLabel.Text = "Service Details";
            // 
            // EmployeePanel
            // 
            EmployeePanel.BorderStyle = BorderStyle.FixedSingle;
            EmployeePanel.Controls.Add(ServPriceTB);
            EmployeePanel.Controls.Add(InclusionLabel);
            EmployeePanel.Controls.Add(ServEmPayTB);
            EmployeePanel.Controls.Add(label1);
            EmployeePanel.Controls.Add(EmPayLabel);
            EmployeePanel.Controls.Add(PesoSign);
            EmployeePanel.Controls.Add(PriceLabel);
            EmployeePanel.Controls.Add(EmpFBName);
            EmployeePanel.Controls.Add(ServIDTB);
            EmployeePanel.Controls.Add(InclusionTB);
            EmployeePanel.Controls.Add(ServiceNameTB);
            EmployeePanel.Controls.Add(EditPackageBTN);
            EmployeePanel.Controls.Add(RemovePackageBTN);
            EmployeePanel.Controls.Add(UNServName);
            EmployeePanel.Controls.Add(UNServID);
            EmployeePanel.Controls.Add(UNPrice);
            EmployeePanel.Controls.Add(UNEmPay);
            EmployeePanel.Location = new Point(7, 53);
            EmployeePanel.Name = "EmployeePanel";
            EmployeePanel.Size = new Size(484, 355);
            EmployeePanel.TabIndex = 46;
            // 
            // ServPriceTB
            // 
            ServPriceTB.BackColor = Color.FromArgb(223, 232, 215);
            ServPriceTB.BorderStyle = BorderStyle.None;
            ServPriceTB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            ServPriceTB.Location = new Point(390, 70);
            ServPriceTB.Margin = new Padding(2, 3, 2, 3);
            ServPriceTB.Name = "ServPriceTB";
            ServPriceTB.ReadOnly = true;
            ServPriceTB.Size = new Size(69, 32);
            ServPriceTB.TabIndex = 73;
            ServPriceTB.Text = "00";
            // 
            // InclusionLabel
            // 
            InclusionLabel.AutoSize = true;
            InclusionLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            InclusionLabel.Location = new Point(14, 177);
            InclusionLabel.Margin = new Padding(4, 0, 4, 0);
            InclusionLabel.Name = "InclusionLabel";
            InclusionLabel.Size = new Size(116, 32);
            InclusionLabel.TabIndex = 79;
            InclusionLabel.Text = "Inclusion:";
            // 
            // ServEmPayTB
            // 
            ServEmPayTB.BackColor = Color.FromArgb(223, 232, 215);
            ServEmPayTB.BorderStyle = BorderStyle.None;
            ServEmPayTB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            ServEmPayTB.Location = new Point(212, 123);
            ServEmPayTB.Margin = new Padding(2, 3, 2, 3);
            ServEmPayTB.Name = "ServEmPayTB";
            ServEmPayTB.ReadOnly = true;
            ServEmPayTB.Size = new Size(90, 32);
            ServEmPayTB.TabIndex = 77;
            ServEmPayTB.Text = "00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(185, 123);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(29, 32);
            label1.TabIndex = 78;
            label1.Text = "₱";
            // 
            // EmPayLabel
            // 
            EmPayLabel.AutoSize = true;
            EmPayLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            EmPayLabel.Location = new Point(14, 123);
            EmPayLabel.Margin = new Padding(4, 0, 4, 0);
            EmPayLabel.Name = "EmPayLabel";
            EmPayLabel.Size = new Size(170, 32);
            EmPayLabel.TabIndex = 75;
            EmPayLabel.Text = "Employee Pay:";
            // 
            // PesoSign
            // 
            PesoSign.AutoSize = true;
            PesoSign.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            PesoSign.Location = new Point(363, 70);
            PesoSign.Margin = new Padding(4, 0, 4, 0);
            PesoSign.Name = "PesoSign";
            PesoSign.Size = new Size(29, 32);
            PesoSign.TabIndex = 74;
            PesoSign.Text = "₱";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            PriceLabel.Location = new Point(295, 70);
            PriceLabel.Margin = new Padding(4, 0, 4, 0);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(73, 32);
            PriceLabel.TabIndex = 72;
            PriceLabel.Text = "Price:";
            // 
            // EmpFBName
            // 
            EmpFBName.AutoSize = true;
            EmpFBName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            EmpFBName.Location = new Point(14, 70);
            EmpFBName.Margin = new Padding(4, 0, 4, 0);
            EmpFBName.Name = "EmpFBName";
            EmpFBName.Size = new Size(129, 32);
            EmpFBName.TabIndex = 71;
            EmpFBName.Text = "Service ID:";
            // 
            // ServIDTB
            // 
            ServIDTB.BackColor = Color.FromArgb(223, 232, 215);
            ServIDTB.BorderStyle = BorderStyle.None;
            ServIDTB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            ServIDTB.Location = new Point(144, 70);
            ServIDTB.Margin = new Padding(2, 3, 2, 3);
            ServIDTB.Name = "ServIDTB";
            ServIDTB.ReadOnly = true;
            ServIDTB.Size = new Size(102, 32);
            ServIDTB.TabIndex = 70;
            ServIDTB.Text = "XXXXX";
            // 
            // InclusionTB
            // 
            InclusionTB.BackColor = Color.FromArgb(223, 232, 215);
            InclusionTB.BorderStyle = BorderStyle.None;
            InclusionTB.Location = new Point(21, 212);
            InclusionTB.Margin = new Padding(2, 3, 2, 3);
            InclusionTB.Multiline = true;
            InclusionTB.Name = "InclusionTB";
            InclusionTB.Size = new Size(443, 90);
            InclusionTB.TabIndex = 69;
            // 
            // ServiceNameTB
            // 
            ServiceNameTB.BackColor = Color.FromArgb(223, 232, 215);
            ServiceNameTB.BorderStyle = BorderStyle.None;
            ServiceNameTB.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ServiceNameTB.Location = new Point(21, 13);
            ServiceNameTB.Margin = new Padding(2, 3, 2, 3);
            ServiceNameTB.Name = "ServiceNameTB";
            ServiceNameTB.ReadOnly = true;
            ServiceNameTB.Size = new Size(443, 32);
            ServiceNameTB.TabIndex = 68;
            ServiceNameTB.Text = "Package Name -";
            // 
            // EditPackageBTN
            // 
            EditPackageBTN.BackColor = Color.FromArgb(46, 60, 24);
            EditPackageBTN.BackgroundColor = Color.FromArgb(46, 60, 24);
            EditPackageBTN.BorderColor = Color.PaleVioletRed;
            EditPackageBTN.BorderRadius = 8;
            EditPackageBTN.BorderSize = 0;
            EditPackageBTN.FlatAppearance.BorderSize = 0;
            EditPackageBTN.FlatStyle = FlatStyle.Flat;
            EditPackageBTN.ForeColor = Color.White;
            EditPackageBTN.Location = new Point(5, 308);
            EditPackageBTN.Margin = new Padding(2, 3, 2, 3);
            EditPackageBTN.Name = "EditPackageBTN";
            EditPackageBTN.Size = new Size(234, 39);
            EditPackageBTN.TabIndex = 58;
            EditPackageBTN.Text = "Edit";
            EditPackageBTN.TextColor = Color.White;
            EditPackageBTN.UseVisualStyleBackColor = false;
            EditPackageBTN.Click += EditPackageBTN_Click;
            // 
            // RemovePackageBTN
            // 
            RemovePackageBTN.BackColor = Color.Firebrick;
            RemovePackageBTN.BackgroundColor = Color.Firebrick;
            RemovePackageBTN.BorderColor = Color.PaleVioletRed;
            RemovePackageBTN.BorderRadius = 8;
            RemovePackageBTN.BorderSize = 0;
            RemovePackageBTN.FlatAppearance.BorderSize = 0;
            RemovePackageBTN.FlatStyle = FlatStyle.Flat;
            RemovePackageBTN.ForeColor = Color.White;
            RemovePackageBTN.Location = new Point(242, 308);
            RemovePackageBTN.Margin = new Padding(2, 3, 2, 3);
            RemovePackageBTN.Name = "RemovePackageBTN";
            RemovePackageBTN.Size = new Size(234, 39);
            RemovePackageBTN.TabIndex = 59;
            RemovePackageBTN.Text = "Remove";
            RemovePackageBTN.TextColor = Color.White;
            RemovePackageBTN.UseVisualStyleBackColor = false;
            RemovePackageBTN.Click += RemovePackageBTN_Click;
            // 
            // UNServName
            // 
            UNServName.BackColor = Color.FromArgb(223, 232, 215);
            UNServName.BorderStyle = BorderStyle.None;
            UNServName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UNServName.Location = new Point(21, 18);
            UNServName.Margin = new Padding(2, 3, 2, 3);
            UNServName.Name = "UNServName";
            UNServName.ReadOnly = true;
            UNServName.Size = new Size(443, 32);
            UNServName.TabIndex = 62;
            UNServName.Text = "_____________________________________________________";
            // 
            // UNServID
            // 
            UNServID.BackColor = Color.FromArgb(223, 232, 215);
            UNServID.BorderStyle = BorderStyle.None;
            UNServID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UNServID.Location = new Point(144, 75);
            UNServID.Margin = new Padding(2, 3, 2, 3);
            UNServID.Name = "UNServID";
            UNServID.ReadOnly = true;
            UNServID.Size = new Size(82, 32);
            UNServID.TabIndex = 64;
            UNServID.Text = "__________________________________________";
            // 
            // UNPrice
            // 
            UNPrice.BackColor = Color.FromArgb(223, 232, 215);
            UNPrice.BorderStyle = BorderStyle.None;
            UNPrice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UNPrice.Location = new Point(369, 75);
            UNPrice.Margin = new Padding(2, 3, 2, 3);
            UNPrice.Name = "UNPrice";
            UNPrice.ReadOnly = true;
            UNPrice.Size = new Size(95, 32);
            UNPrice.TabIndex = 66;
            UNPrice.Text = "__________________________________________";
            // 
            // UNEmPay
            // 
            UNEmPay.BackColor = Color.FromArgb(223, 232, 215);
            UNEmPay.BorderStyle = BorderStyle.None;
            UNEmPay.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UNEmPay.Location = new Point(185, 128);
            UNEmPay.Margin = new Padding(2, 3, 2, 3);
            UNEmPay.Name = "UNEmPay";
            UNEmPay.ReadOnly = true;
            UNEmPay.Size = new Size(100, 32);
            UNEmPay.TabIndex = 76;
            UNEmPay.Text = "__________________________________________";
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
            ExitButton.Location = new Point(7, 413);
            ExitButton.Margin = new Padding(2, 3, 2, 3);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(484, 39);
            ExitButton.TabIndex = 60;
            ExitButton.Text = "Done";
            ExitButton.TextColor = Color.White;
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // Packages
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 232, 215);
            ClientSize = new Size(499, 457);
            Controls.Add(ExitButton);
            Controls.Add(EmployeePanel);
            Controls.Add(PackageLabel);
            Name = "Packages";
            Text = "Packages";
            EmployeePanel.ResumeLayout(false);
            EmployeePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PackageLabel;
        private Panel EmployeePanel;
        private ADETADET_sample.RBButton EditPackageBTN;
        private ADETADET_sample.RBButton RemovePackageBTN;
        private ADETADET_sample.RBButton ExitButton;
        private TextBox UNServName;
        private TextBox UNServID;
        private TextBox UNPrice;
        private TextBox ServiceNameTB;
        private TextBox InclusionTB;
        private TextBox ServIDTB;
        private Label EmpFBName;
        private Label PriceLabel;
        private Label PesoSign;
        private TextBox ServPriceTB;
        private Label EmPayLabel;
        private TextBox ServEmPayTB;
        private TextBox UNEmPay;
        private Label InclusionLabel;
        private Label label1;
    }
}