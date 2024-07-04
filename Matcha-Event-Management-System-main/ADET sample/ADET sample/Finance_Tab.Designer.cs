namespace ADET_sample
{
    partial class Finance_tab
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
            
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
           
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            FinanceRepLabel = new Label();
            PayoutLabel = new Label();
            Bills = new Label();
            AddBillerBTN = new ADETADET_sample.RBButton();
            FinanceRepDataGrid = new DataGridView();
            PayOutDataGrid = new DataGridView();
            BillsDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)FinanceRepDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PayOutDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BillsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // FinanceRepLabel
            // 
            FinanceRepLabel.AutoSize = true;
            FinanceRepLabel.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FinanceRepLabel.Location = new Point(-1, 9);
            FinanceRepLabel.Margin = new Padding(4, 0, 4, 0);
            FinanceRepLabel.Name = "FinanceRepLabel";
            FinanceRepLabel.Size = new Size(470, 43);
            FinanceRepLabel.TabIndex = 11;
            FinanceRepLabel.Text = "Monthly Finance Reports";
            // 
            // PayoutLabel
            // 
            PayoutLabel.AutoSize = true;
            PayoutLabel.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PayoutLabel.Location = new Point(-1, 433);
            PayoutLabel.Margin = new Padding(4, 0, 4, 0);
            PayoutLabel.Name = "PayoutLabel";
            PayoutLabel.Size = new Size(301, 43);
            PayoutLabel.TabIndex = 13;
            PayoutLabel.Text = "Month's Payout";
            // 
            // Bills
            // 
            Bills.AutoSize = true;
            Bills.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Bills.Location = new Point(609, 433);
            Bills.Margin = new Padding(4, 0, 4, 0);
            Bills.Name = "Bills";
            Bills.Size = new Size(231, 43);
            Bills.TabIndex = 15;
            Bills.Text = "Montly Bills";
            // 
            // AddBillerBTN
            // 
            AddBillerBTN.BackColor = Color.FromArgb(46, 60, 24);
            AddBillerBTN.BackgroundColor = Color.FromArgb(46, 60, 24);
            AddBillerBTN.BorderColor = Color.PaleVioletRed;
            AddBillerBTN.BorderRadius = 8;
            AddBillerBTN.BorderSize = 0;
            AddBillerBTN.FlatAppearance.BorderSize = 0;
            AddBillerBTN.FlatStyle = FlatStyle.Flat;
            AddBillerBTN.ForeColor = Color.White;
            AddBillerBTN.ImageAlign = ContentAlignment.BottomCenter;
            AddBillerBTN.Location = new Point(609, 757);
            AddBillerBTN.Margin = new Padding(2, 3, 2, 3);
            AddBillerBTN.Name = "AddBillerBTN";
            AddBillerBTN.Size = new Size(605, 39);
            AddBillerBTN.TabIndex = 17;
            AddBillerBTN.Text = "New Biller";
            AddBillerBTN.TextColor = Color.White;
            AddBillerBTN.UseVisualStyleBackColor = false;
            AddBillerBTN.Click += AddBillerBTN_Click;
            // 
            // FinanceRepDataGrid
            // 
            FinanceRepDataGrid.AllowUserToAddRows = false;
            FinanceRepDataGrid.AllowUserToDeleteRows = false;
            FinanceRepDataGrid.AllowUserToResizeColumns = false;
            FinanceRepDataGrid.AllowUserToResizeRows = false;
            FinanceRepDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            FinanceRepDataGrid.BackgroundColor = Color.FromArgb(76, 88, 57);
            FinanceRepDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            FinanceRepDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(46, 60, 24);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 13F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(46, 60, 24);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            FinanceRepDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            FinanceRepDataGrid.ColumnHeadersHeight = 60;
            FinanceRepDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(76, 88, 57);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(95, 122, 86);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            FinanceRepDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            FinanceRepDataGrid.EnableHeadersVisualStyles = false;
            FinanceRepDataGrid.GridColor = SystemColors.InactiveBorder;
            FinanceRepDataGrid.Location = new Point(4, 61);
            FinanceRepDataGrid.MultiSelect = false;
            FinanceRepDataGrid.Name = "FinanceRepDataGrid";
            FinanceRepDataGrid.ReadOnly = true;
            FinanceRepDataGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            FinanceRepDataGrid.RowHeadersVisible = false;
            FinanceRepDataGrid.RowHeadersWidth = 62;
            FinanceRepDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            FinanceRepDataGrid.RowTemplate.Height = 50;
            FinanceRepDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            FinanceRepDataGrid.ShowEditingIcon = false;
            FinanceRepDataGrid.Size = new Size(1210, 355);
            FinanceRepDataGrid.TabIndex = 12;
            // 
            // PayOutDataGrid
            // 
            PayOutDataGrid.AllowUserToAddRows = false;
            PayOutDataGrid.AllowUserToDeleteRows = false;
            PayOutDataGrid.AllowUserToResizeColumns = false;
            PayOutDataGrid.AllowUserToResizeRows = false;
            PayOutDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PayOutDataGrid.BackgroundColor = Color.FromArgb(76, 88, 57);
            PayOutDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            PayOutDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(46, 60, 24);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 13F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(46, 60, 24);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            PayOutDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            PayOutDataGrid.ColumnHeadersHeight = 60;
            PayOutDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(76, 88, 57);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(95, 122, 86);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            PayOutDataGrid.DefaultCellStyle = dataGridViewCellStyle4;
            PayOutDataGrid.EnableHeadersVisualStyles = false;
            PayOutDataGrid.GridColor = SystemColors.InactiveBorder;
            PayOutDataGrid.Location = new Point(4, 484);
            PayOutDataGrid.MultiSelect = false;
            PayOutDataGrid.Name = "PayOutDataGrid";
            PayOutDataGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            PayOutDataGrid.RowHeadersVisible = false;
            PayOutDataGrid.RowHeadersWidth = 62;
            PayOutDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            PayOutDataGrid.RowTemplate.Height = 50;
            PayOutDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PayOutDataGrid.ShowEditingIcon = false;
            PayOutDataGrid.Size = new Size(600, 312);
            PayOutDataGrid.TabIndex = 14;
            // 
            // BillsDataGridView
            // 
            BillsDataGridView.AllowUserToAddRows = false;
            BillsDataGridView.AllowUserToDeleteRows = false;
            BillsDataGridView.AllowUserToResizeColumns = false;
            BillsDataGridView.AllowUserToResizeRows = false;
            BillsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BillsDataGridView.BackgroundColor = Color.FromArgb(76, 88, 57);
            BillsDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            BillsDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(46, 60, 24);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 13F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(46, 60, 24);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            BillsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            BillsDataGridView.ColumnHeadersHeight = 60;
            BillsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(76, 88, 57);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(95, 122, 86);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            BillsDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            BillsDataGridView.EnableHeadersVisualStyles = false;
            BillsDataGridView.GridColor = SystemColors.InactiveBorder;
            BillsDataGridView.Location = new Point(614, 484);
            BillsDataGridView.MultiSelect = false;
            BillsDataGridView.Name = "BillsDataGridView";
            BillsDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            BillsDataGridView.RowHeadersVisible = false;
            BillsDataGridView.RowHeadersWidth = 62;
            BillsDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            BillsDataGridView.RowTemplate.Height = 50;
            BillsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BillsDataGridView.ShowEditingIcon = false;
            BillsDataGridView.Size = new Size(600, 267);
            BillsDataGridView.TabIndex = 16;
            BillsDataGridView.CellContentClick += BillsDataGridView_CellContentClick;
            // 
            // Finance_tab
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 232, 215);
            ClientSize = new Size(1226, 808);
            Controls.Add(AddBillerBTN);
            Controls.Add(BillsDataGridView);
            Controls.Add(Bills);
            Controls.Add(PayOutDataGrid);
            Controls.Add(PayoutLabel);
            Controls.Add(FinanceRepDataGrid);
            Controls.Add(FinanceRepLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Finance_tab";
            Text = "Finance";
            ((System.ComponentModel.ISupportInitialize)FinanceRepDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)PayOutDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)BillsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FinanceRepLabel;
        private Label PayoutLabel;
        private Label Bills;
        private ADETADET_sample.RBButton AddBillerBTN;
        private DataGridView PayOutDataGrid;
        private DataGridView FinanceRepDataGrid;
        private DataGridView BillsDataGridView;

    }
}