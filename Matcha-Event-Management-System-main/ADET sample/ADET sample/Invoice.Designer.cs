namespace ADET_sample
{
    partial class Invoice
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
            InvoiceLabel = new Label();
            ExitButton = new ADETADET_sample.RBButton();
            InvoicePanel = new Panel();
            pBalance = new Label();
            DP = new Label();
            pTotal = new Label();
            PType = new Label();
            PStatus = new Label();
            PaymentID = new Label();
            EventID = new Label();
            label1 = new Label();
            EI_DP = new Label();
            IETotal = new Label();
            EIPType = new Label();
            IEPStatusLabel = new Label();
            IEEventIDLabel = new Label();
            IEPaymentIDLabel = new Label();
            InvoicePanel.SuspendLayout();
            SuspendLayout();
            // 
            // InvoiceLabel
            // 
            InvoiceLabel.AutoSize = true;
            InvoiceLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            InvoiceLabel.Location = new Point(-1, -1);
            InvoiceLabel.Margin = new Padding(4, 0, 4, 0);
            InvoiceLabel.Name = "InvoiceLabel";
            InvoiceLabel.Size = new Size(218, 45);
            InvoiceLabel.TabIndex = 27;
            InvoiceLabel.Text = "Event Invoice";
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
            ExitButton.Location = new Point(8, 355);
            ExitButton.Margin = new Padding(2, 3, 2, 3);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(569, 39);
            ExitButton.TabIndex = 59;
            ExitButton.Text = "Done";
            ExitButton.TextColor = Color.White;
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // InvoicePanel
            // 
            InvoicePanel.BorderStyle = BorderStyle.FixedSingle;
            InvoicePanel.Controls.Add(pBalance);
            InvoicePanel.Controls.Add(DP);
            InvoicePanel.Controls.Add(pTotal);
            InvoicePanel.Controls.Add(PType);
            InvoicePanel.Controls.Add(PStatus);
            InvoicePanel.Controls.Add(PaymentID);
            InvoicePanel.Controls.Add(EventID);
            InvoicePanel.Controls.Add(label1);
            InvoicePanel.Controls.Add(EI_DP);
            InvoicePanel.Controls.Add(IETotal);
            InvoicePanel.Controls.Add(EIPType);
            InvoicePanel.Controls.Add(IEPStatusLabel);
            InvoicePanel.Controls.Add(IEEventIDLabel);
            InvoicePanel.Controls.Add(IEPaymentIDLabel);
            InvoicePanel.Location = new Point(9, 47);
            InvoicePanel.Name = "InvoicePanel";
            InvoicePanel.Size = new Size(568, 302);
            InvoicePanel.TabIndex = 58;
            // 
            // pBalance
            // 
            pBalance.AutoSize = true;
            pBalance.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pBalance.Location = new Point(7, 258);
            pBalance.Margin = new Padding(4, 0, 4, 0);
            pBalance.Name = "pBalance";
            pBalance.Size = new Size(119, 32);
            pBalance.TabIndex = 46;
            pBalance.Text = "Balance--";
            // 
            // DP
            // 
            DP.AutoSize = true;
            DP.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DP.Location = new Point(282, 182);
            DP.Margin = new Padding(4, 0, 4, 0);
            DP.Name = "DP";
            DP.Size = new Size(65, 32);
            DP.TabIndex = 45;
            DP.Text = "DP--";
            // 
            // pTotal
            // 
            pTotal.AutoSize = true;
            pTotal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pTotal.Location = new Point(7, 182);
            pTotal.Margin = new Padding(4, 0, 4, 0);
            pTotal.Name = "pTotal";
            pTotal.Size = new Size(87, 32);
            pTotal.TabIndex = 44;
            pTotal.Text = "Total--";
            // 
            // PType
            // 
            PType.AutoSize = true;
            PType.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PType.Location = new Point(282, 97);
            PType.Margin = new Padding(4, 0, 4, 0);
            PType.Name = "PType";
            PType.Size = new Size(187, 32);
            PType.TabIndex = 43;
            PType.Text = "Payment Type--";
            // 
            // PStatus
            // 
            PStatus.AutoSize = true;
            PStatus.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PStatus.Location = new Point(7, 97);
            PStatus.Margin = new Padding(4, 0, 4, 0);
            PStatus.Name = "PStatus";
            PStatus.Size = new Size(203, 32);
            PStatus.TabIndex = 42;
            PStatus.Text = "Payment Status--";
            // 
            // PaymentID
            // 
            PaymentID.AutoSize = true;
            PaymentID.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            PaymentID.Location = new Point(427, 11);
            PaymentID.Margin = new Padding(4, 0, 4, 0);
            PaymentID.Name = "PaymentID";
            PaymentID.Size = new Size(110, 32);
            PaymentID.TabIndex = 41;
            PaymentID.Text = "Event ID";
            // 
            // EventID
            // 
            EventID.AutoSize = true;
            EventID.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            EventID.Location = new Point(115, 11);
            EventID.Margin = new Padding(4, 0, 4, 0);
            EventID.Name = "EventID";
            EventID.Size = new Size(110, 32);
            EventID.TabIndex = 40;
            EventID.Text = "Event ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(7, 226);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 32);
            label1.TabIndex = 39;
            label1.Text = "Balance:";
            // 
            // EI_DP
            // 
            EI_DP.AutoSize = true;
            EI_DP.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EI_DP.Location = new Point(282, 150);
            EI_DP.Margin = new Padding(4, 0, 4, 0);
            EI_DP.Name = "EI_DP";
            EI_DP.Size = new Size(185, 32);
            EI_DP.TabIndex = 38;
            EI_DP.Text = "Down Payment:";
            // 
            // IETotal
            // 
            IETotal.AutoSize = true;
            IETotal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IETotal.Location = new Point(7, 150);
            IETotal.Margin = new Padding(4, 0, 4, 0);
            IETotal.Name = "IETotal";
            IETotal.Size = new Size(73, 32);
            IETotal.TabIndex = 37;
            IETotal.Text = "Total:";
            // 
            // EIPType
            // 
            EIPType.AutoSize = true;
            EIPType.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EIPType.Location = new Point(282, 65);
            EIPType.Margin = new Padding(4, 0, 4, 0);
            EIPType.Name = "EIPType";
            EIPType.Size = new Size(173, 32);
            EIPType.TabIndex = 36;
            EIPType.Text = "Payment Type:";
            // 
            // IEPStatusLabel
            // 
            IEPStatusLabel.AutoSize = true;
            IEPStatusLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IEPStatusLabel.Location = new Point(7, 65);
            IEPStatusLabel.Margin = new Padding(4, 0, 4, 0);
            IEPStatusLabel.Name = "IEPStatusLabel";
            IEPStatusLabel.Size = new Size(189, 32);
            IEPStatusLabel.TabIndex = 35;
            IEPStatusLabel.Text = "Payment Status:";
            // 
            // IEEventIDLabel
            // 
            IEEventIDLabel.AutoSize = true;
            IEEventIDLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            IEEventIDLabel.Location = new Point(7, 11);
            IEEventIDLabel.Margin = new Padding(4, 0, 4, 0);
            IEEventIDLabel.Name = "IEEventIDLabel";
            IEEventIDLabel.Size = new Size(117, 32);
            IEEventIDLabel.TabIndex = 34;
            IEEventIDLabel.Text = "Event ID:";
            // 
            // IEPaymentIDLabel
            // 
            IEPaymentIDLabel.AutoSize = true;
            IEPaymentIDLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            IEPaymentIDLabel.Location = new Point(282, 11);
            IEPaymentIDLabel.Margin = new Padding(4, 0, 4, 0);
            IEPaymentIDLabel.Name = "IEPaymentIDLabel";
            IEPaymentIDLabel.Size = new Size(160, 32);
            IEPaymentIDLabel.TabIndex = 33;
            IEPaymentIDLabel.Text = "Payment ID: ";
            // 
            // Invoice
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 232, 215);
            ClientSize = new Size(585, 399);
            Controls.Add(ExitButton);
            Controls.Add(InvoicePanel);
            Controls.Add(InvoiceLabel);
            Name = "Invoice";
            Text = "Invoice";
            InvoicePanel.ResumeLayout(false);
            InvoicePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label InvoiceLabel;
        private ADETADET_sample.RBButton ExitButton;
        private Panel InvoicePanel;
        private TextBox EmpAddTB;
        private TextBox EmpNameTB;
        private TextBox UNEmpAdd;
        private ADETADET_sample.RBButton Remove_EmployeeBTN;
        private ADETADET_sample.RBButton Edit_EmployeeInfo;
        private Label EmpName_Label;
        private Label IEEventIDLabel;
        private Label IEPaymentIDLabel;
        private Label IEPStatusLabel;
        private Label IETotal;
        private Label EIPType;
        private Label PaymentID;
        private Label EventID;
        private Label label1;
        private Label EI_DP;
        private Label pBalance;
        private Label DP;
        private Label pTotal;
        private Label PType;
        private Label PStatus;
    }
}