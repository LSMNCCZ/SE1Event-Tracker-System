using System.Drawing.Drawing2D;

namespace ADET_sample
{
    partial class Services_tab
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
            label_Packages = new Label();
            label_Addons = new Label();
            Packages_List_DataGrid = new DataGridView();
            Addons_List_DataGrid = new DataGridView();
            AddPackageBTN = new ADETADET_sample.RBButton();
            AddOnsBTN = new ADETADET_sample.RBButton();
            ((System.ComponentModel.ISupportInitialize)Packages_List_DataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Addons_List_DataGrid).BeginInit();
            SuspendLayout();
            // 
            // label_Packages
            // 
            label_Packages.AutoSize = true;
            label_Packages.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Packages.Location = new Point(-1, 9);
            label_Packages.Margin = new Padding(4, 0, 4, 0);
            label_Packages.Name = "label_Packages";
            label_Packages.Size = new Size(191, 43);
            label_Packages.TabIndex = 2;
            label_Packages.Text = "Packages";
            // 
            // label_Addons
            // 
            label_Addons.AutoSize = true;
            label_Addons.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Addons.Location = new Point(2, 475);
            label_Addons.Margin = new Padding(4, 0, 4, 0);
            label_Addons.Name = "label_Addons";
            label_Addons.Size = new Size(154, 43);
            label_Addons.TabIndex = 4;
            label_Addons.Text = "Addons";
            label_Addons.Click += label_Addons_Click;
            // 
            // Packages_List_DataGrid
            // 
            Packages_List_DataGrid.AllowUserToAddRows = false;
            Packages_List_DataGrid.AllowUserToDeleteRows = false;
            Packages_List_DataGrid.AllowUserToResizeColumns = false;
            Packages_List_DataGrid.AllowUserToResizeRows = false;
            Packages_List_DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Packages_List_DataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            Packages_List_DataGrid.BackgroundColor = Color.FromArgb(76, 88, 57);
            Packages_List_DataGrid.BorderStyle = BorderStyle.None;
            Packages_List_DataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(46, 60, 24);
            dataGridViewCellStyle1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(46, 60, 24);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            Packages_List_DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            Packages_List_DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(223, 232, 215);
            dataGridViewCellStyle2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(46, 60, 24);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            Packages_List_DataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            Packages_List_DataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            Packages_List_DataGrid.EnableHeadersVisualStyles = false;
            Packages_List_DataGrid.GridColor = SystemColors.InactiveBorder;
            Packages_List_DataGrid.Location = new Point(4, 59);
            Packages_List_DataGrid.Margin = new Padding(4);
            Packages_List_DataGrid.Name = "Packages_List_DataGrid";
            Packages_List_DataGrid.ReadOnly = true;
            Packages_List_DataGrid.RowHeadersVisible = false;
            Packages_List_DataGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(223, 232, 215);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(46, 60, 24);
            Packages_List_DataGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            Packages_List_DataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Packages_List_DataGrid.Size = new Size(1210, 363);
            Packages_List_DataGrid.TabIndex = 5;
            // 
            // Addons_List_DataGrid
            // 
            Addons_List_DataGrid.AllowUserToAddRows = false;
            Addons_List_DataGrid.AllowUserToDeleteRows = false;
            Addons_List_DataGrid.AllowUserToResizeColumns = false;
            Addons_List_DataGrid.AllowUserToResizeRows = false;
            Addons_List_DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Addons_List_DataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            Addons_List_DataGrid.BackgroundColor = Color.FromArgb(76, 88, 57);
            Addons_List_DataGrid.BorderStyle = BorderStyle.None;
            Addons_List_DataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(46, 60, 24);
            dataGridViewCellStyle4.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(46, 60, 24);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            Addons_List_DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            Addons_List_DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(223, 232, 215);
            dataGridViewCellStyle5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(46, 60, 24);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            Addons_List_DataGrid.DefaultCellStyle = dataGridViewCellStyle5;
            Addons_List_DataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            Addons_List_DataGrid.EnableHeadersVisualStyles = false;
            Addons_List_DataGrid.GridColor = SystemColors.InactiveBorder;
            Addons_List_DataGrid.Location = new Point(4, 522);
            Addons_List_DataGrid.Margin = new Padding(4);
            Addons_List_DataGrid.Name = "Addons_List_DataGrid";
            Addons_List_DataGrid.ReadOnly = true;
            Addons_List_DataGrid.RowHeadersVisible = false;
            Addons_List_DataGrid.RowHeadersWidth = 51;
            Addons_List_DataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Addons_List_DataGrid.Size = new Size(1210, 234);
            Addons_List_DataGrid.TabIndex = 6;
            // 
            // AddPackageBTN
            // 
            AddPackageBTN.BackColor = Color.FromArgb(46, 60, 24);
            AddPackageBTN.BackgroundColor = Color.FromArgb(46, 60, 24);
            AddPackageBTN.BorderColor = Color.PaleVioletRed;
            AddPackageBTN.BorderRadius = 8;
            AddPackageBTN.BorderSize = 0;
            AddPackageBTN.FlatAppearance.BorderSize = 0;
            AddPackageBTN.FlatStyle = FlatStyle.Flat;
            AddPackageBTN.ForeColor = Color.White;
            AddPackageBTN.ImageAlign = ContentAlignment.BottomCenter;
            AddPackageBTN.Location = new Point(4, 428);
            AddPackageBTN.Margin = new Padding(2, 3, 2, 3);
            AddPackageBTN.Name = "AddPackageBTN";
            AddPackageBTN.Size = new Size(1210, 39);
            AddPackageBTN.TabIndex = 10;
            AddPackageBTN.Text = "New Package";
            AddPackageBTN.TextColor = Color.White;
            AddPackageBTN.UseVisualStyleBackColor = false;
            // 
            // AddOnsBTN
            // 
            AddOnsBTN.BackColor = Color.FromArgb(46, 60, 24);
            AddOnsBTN.BackgroundColor = Color.FromArgb(46, 60, 24);
            AddOnsBTN.BorderColor = Color.PaleVioletRed;
            AddOnsBTN.BorderRadius = 8;
            AddOnsBTN.BorderSize = 0;
            AddOnsBTN.FlatAppearance.BorderSize = 0;
            AddOnsBTN.FlatStyle = FlatStyle.Flat;
            AddOnsBTN.ForeColor = Color.White;
            AddOnsBTN.ImageAlign = ContentAlignment.BottomCenter;
            AddOnsBTN.Location = new Point(4, 763);
            AddOnsBTN.Margin = new Padding(2, 3, 2, 3);
            AddOnsBTN.Name = "AddOnsBTN";
            AddOnsBTN.Size = new Size(1210, 39);
            AddOnsBTN.TabIndex = 11;
            AddOnsBTN.Text = "New Add-On";
            AddOnsBTN.TextColor = Color.White;
            AddOnsBTN.UseVisualStyleBackColor = false;
            // 
            // Services_tab
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 232, 215);
            ClientSize = new Size(1226, 808);
            Controls.Add(AddOnsBTN);
            Controls.Add(AddPackageBTN);
            Controls.Add(Addons_List_DataGrid);
            Controls.Add(Packages_List_DataGrid);
            Controls.Add(label_Addons);
            Controls.Add(label_Packages);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Services_tab";
            Text = "Services_tab";
            Load += Services_tab_Load;
            ((System.ComponentModel.ISupportInitialize)Packages_List_DataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)Addons_List_DataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Label label_Packages;
        private Label label_Addons;
        private DataGridView Packages_List_DataGrid;
        private DataGridView Addons_List_DataGrid;
        private ADETADET_sample.RBButton AddPackageBTN;
        private ADETADET_sample.RBButton AddOnsBTN;
    }
}