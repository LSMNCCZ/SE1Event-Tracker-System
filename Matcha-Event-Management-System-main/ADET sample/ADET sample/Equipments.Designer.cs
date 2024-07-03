namespace ADET_sample
{
    partial class Equipments_tab
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
            //DataGridView EquipmentDataGrid;
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            EquipmentHeader = new Label();
            NewEquipmentBTN = new ADETADET_sample.RBButton();
            EquipmentDataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)EquipmentDataGrid).BeginInit();
            SuspendLayout();
            // 
            // EquipmentDataGrid
            // 
            EquipmentDataGrid.AllowUserToAddRows = false;
            EquipmentDataGrid.AllowUserToDeleteRows = false;
            EquipmentDataGrid.AllowUserToResizeColumns = false;
            EquipmentDataGrid.AllowUserToResizeRows = false;
            EquipmentDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            EquipmentDataGrid.BackgroundColor = Color.FromArgb(76, 88, 57);
            EquipmentDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            EquipmentDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(46, 60, 24);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 13F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(46, 60, 24);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            EquipmentDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            EquipmentDataGrid.ColumnHeadersHeight = 60;
            EquipmentDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(76, 88, 57);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(95, 122, 86);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            EquipmentDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            EquipmentDataGrid.EnableHeadersVisualStyles = false;
            EquipmentDataGrid.GridColor = SystemColors.InactiveBorder;
            EquipmentDataGrid.Location = new Point(4, 61);
            EquipmentDataGrid.MultiSelect = false;
            EquipmentDataGrid.Name = "EquipmentDataGrid";
            EquipmentDataGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            EquipmentDataGrid.RowHeadersVisible = false;
            EquipmentDataGrid.RowHeadersWidth = 62;
            EquipmentDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            EquipmentDataGrid.RowTemplate.Height = 50;
            EquipmentDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            EquipmentDataGrid.ShowEditingIcon = false;
            EquipmentDataGrid.Size = new Size(1210, 696);
            EquipmentDataGrid.TabIndex = 11;
            EquipmentDataGrid.CellContentClick += EquipmentDataGrid_CellContentClick;
            // 
            // EquipmentHeader
            // 
            EquipmentHeader.AutoSize = true;
            EquipmentHeader.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EquipmentHeader.Location = new Point(-1, 9);
            EquipmentHeader.Margin = new Padding(4, 0, 4, 0);
            EquipmentHeader.Name = "EquipmentHeader";
            EquipmentHeader.Size = new Size(233, 43);
            EquipmentHeader.TabIndex = 3;
            EquipmentHeader.Text = "Equipments";
            // 
            // NewEquipmentBTN
            // 
            NewEquipmentBTN.BackColor = Color.FromArgb(46, 60, 24);
            NewEquipmentBTN.BackgroundColor = Color.FromArgb(46, 60, 24);
            NewEquipmentBTN.BorderColor = Color.PaleVioletRed;
            NewEquipmentBTN.BorderRadius = 8;
            NewEquipmentBTN.BorderSize = 0;
            NewEquipmentBTN.FlatAppearance.BorderSize = 0;
            NewEquipmentBTN.FlatStyle = FlatStyle.Flat;
            NewEquipmentBTN.ForeColor = Color.White;
            NewEquipmentBTN.ImageAlign = ContentAlignment.BottomCenter;
            NewEquipmentBTN.Location = new Point(4, 763);
            NewEquipmentBTN.Margin = new Padding(2, 3, 2, 3);
            NewEquipmentBTN.Name = "NewEquipmentBTN";
            NewEquipmentBTN.Size = new Size(1210, 39);
            NewEquipmentBTN.TabIndex = 12;
            NewEquipmentBTN.Text = "New Equipment";
            NewEquipmentBTN.TextColor = Color.White;
            NewEquipmentBTN.UseVisualStyleBackColor = false;
            NewEquipmentBTN.Click += NewEquipmentBTN_Click;
            // 
            // Equipments_tab
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.FromArgb(223, 232, 215);
            ClientSize = new Size(1226, 808);
            Controls.Add(NewEquipmentBTN);
            Controls.Add(EquipmentDataGrid);
            Controls.Add(EquipmentHeader);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Equipments_tab";
            Text = "Equipments_tab";
            ((System.ComponentModel.ISupportInitialize)EquipmentDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EquipmentHeader;
        private ADETADET_sample.RBButton NewEquipmentBTN;
        private DataGridView EquipmentDataGrid;
    }
}