namespace ADET_sample
{
    partial class Employees_tab
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
            //start
            //DataGridView EmployeeListDataGrid;
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            Add_New_Emp_Btn = new ADETADET_sample.RBButton();
            label1 = new Label();
            EmployeeListDataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)EmployeeListDataGrid).BeginInit();
            SuspendLayout();
            // 
            // Add_New_Emp_Btn
            // 
            Add_New_Emp_Btn.BackColor = Color.FromArgb(46, 60, 24);
            Add_New_Emp_Btn.BackgroundColor = Color.FromArgb(46, 60, 24);
            Add_New_Emp_Btn.BorderColor = Color.PaleVioletRed;
            Add_New_Emp_Btn.BorderRadius = 8;
            Add_New_Emp_Btn.BorderSize = 0;
            Add_New_Emp_Btn.FlatAppearance.BorderSize = 0;
            Add_New_Emp_Btn.FlatStyle = FlatStyle.Flat;
            Add_New_Emp_Btn.ForeColor = Color.White;
            Add_New_Emp_Btn.ImageAlign = ContentAlignment.BottomCenter;
            Add_New_Emp_Btn.Location = new Point(4, 763);
            Add_New_Emp_Btn.Margin = new Padding(2, 3, 2, 3);
            Add_New_Emp_Btn.Name = "Add_New_Emp_Btn";
            Add_New_Emp_Btn.Size = new Size(1210, 39);
            Add_New_Emp_Btn.TabIndex = 10;
            Add_New_Emp_Btn.Text = "New Employee";
            Add_New_Emp_Btn.TextColor = Color.White;
            Add_New_Emp_Btn.UseVisualStyleBackColor = false;
            Add_New_Emp_Btn.Click += Add_New_Emp_Btn_Click;
            // 
            // EmployeeListDataGrid
            // 
            EmployeeListDataGrid.AllowUserToAddRows = false;
            EmployeeListDataGrid.AllowUserToDeleteRows = false;
            EmployeeListDataGrid.AllowUserToResizeColumns = false;
            EmployeeListDataGrid.AllowUserToResizeRows = false;
            EmployeeListDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            EmployeeListDataGrid.BackgroundColor = Color.FromArgb(76, 88, 57);
            EmployeeListDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            EmployeeListDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(46, 60, 24);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 13F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(46, 60, 24);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            EmployeeListDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            EmployeeListDataGrid.ColumnHeadersHeight = 60;
            EmployeeListDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(76, 88, 57);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(95, 122, 86);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            EmployeeListDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            EmployeeListDataGrid.EnableHeadersVisualStyles = false;
            EmployeeListDataGrid.GridColor = SystemColors.InactiveBorder;
            EmployeeListDataGrid.Location = new Point(4, 61);
            EmployeeListDataGrid.MultiSelect = false;
            EmployeeListDataGrid.Name = "EmployeeListDataGrid";
            EmployeeListDataGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            EmployeeListDataGrid.RowHeadersVisible = false;
            EmployeeListDataGrid.RowHeadersWidth = 62;
            EmployeeListDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            EmployeeListDataGrid.RowTemplate.Height = 50;
            EmployeeListDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            EmployeeListDataGrid.ShowEditingIcon = false;
            EmployeeListDataGrid.Size = new Size(1210, 696);
            EmployeeListDataGrid.TabIndex = 10;
            EmployeeListDataGrid.CellContentClick += EmployeeListDataGrid_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-1, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(271, 43);
            label1.TabIndex = 0;
            label1.Text = "Employee List";
            // 
            // Employees_tab
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 232, 215);
            ClientSize = new Size(1226, 808);
            Controls.Add(EmployeeListDataGrid);
            Controls.Add(Add_New_Emp_Btn);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Employees_tab";
            Text = "Employees_tab";
            Load += Employees_tab_Load;
            ((System.ComponentModel.ISupportInitialize)EmployeeListDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ADETADET_sample.RBButton Add_New_Emp_Btn;
        private DataGridView EmployeeListDataGrid;
        private Label label1;
    }
}