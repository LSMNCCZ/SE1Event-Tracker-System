namespace ADET_sample
{
    partial class Events_tab
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            UpcomingEventsLabel = new Label();
            AddEventButton = new ADETADET_sample.RBButton();
            UpcomingEventsData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)UpcomingEventsData).BeginInit();
            SuspendLayout();
            // 
            // UpcomingEventsData
            // 
            UpcomingEventsData.AllowUserToAddRows = false;
            UpcomingEventsData.AllowUserToDeleteRows = false;
            UpcomingEventsData.AllowUserToResizeColumns = false;
            UpcomingEventsData.AllowUserToResizeRows = false;
            UpcomingEventsData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UpcomingEventsData.BackgroundColor = Color.FromArgb(76, 88, 57);
            UpcomingEventsData.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            UpcomingEventsData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(46, 60, 24);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 13F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(46, 60, 24);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            UpcomingEventsData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            UpcomingEventsData.ColumnHeadersHeight = 60;
            UpcomingEventsData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(76, 88, 57);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(95, 122, 86);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            UpcomingEventsData.DefaultCellStyle = dataGridViewCellStyle2;
            UpcomingEventsData.EnableHeadersVisualStyles = false;
            UpcomingEventsData.GridColor = SystemColors.InactiveBorder;
            UpcomingEventsData.Location = new Point(4, 61);
            UpcomingEventsData.MultiSelect = false;
            UpcomingEventsData.Name = "UpcomingEventsData";
            UpcomingEventsData.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            UpcomingEventsData.RowHeadersVisible = false;
            UpcomingEventsData.RowHeadersWidth = 62;
            UpcomingEventsData.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            UpcomingEventsData.RowTemplate.Height = 50;
            UpcomingEventsData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UpcomingEventsData.ShowEditingIcon = false;
            UpcomingEventsData.Size = new Size(1210, 696);
            UpcomingEventsData.TabIndex = 10;
            UpcomingEventsData.CellContentClick += UpcomingEventsData_CellContentClick;
            // 
            // UpcomingEventsLabel
            // 
            UpcomingEventsLabel.AutoSize = true;
            UpcomingEventsLabel.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpcomingEventsLabel.Location = new Point(-1, 9);
            UpcomingEventsLabel.Margin = new Padding(4, 0, 4, 0);
            UpcomingEventsLabel.Name = "UpcomingEventsLabel";
            UpcomingEventsLabel.Size = new Size(333, 43);
            UpcomingEventsLabel.TabIndex = 1;
            UpcomingEventsLabel.Text = "Upcoming Events";
            UpcomingEventsLabel.Click += label1_Click;
            // 
            // AddEventButton
            // 
            AddEventButton.BackColor = Color.FromArgb(46, 60, 24);
            AddEventButton.BackgroundColor = Color.FromArgb(46, 60, 24);
            AddEventButton.BorderColor = Color.PaleVioletRed;
            AddEventButton.BorderRadius = 8;
            AddEventButton.BorderSize = 0;
            AddEventButton.FlatAppearance.BorderSize = 0;
            AddEventButton.FlatStyle = FlatStyle.Flat;
            AddEventButton.ForeColor = Color.White;
            AddEventButton.ImageAlign = ContentAlignment.BottomCenter;
            AddEventButton.Location = new Point(4, 763);
            AddEventButton.Margin = new Padding(2, 3, 2, 3);
            AddEventButton.Name = "AddEventButton";
            AddEventButton.Size = new Size(1211, 39);
            AddEventButton.TabIndex = 9;
            AddEventButton.Text = "New Event";
            AddEventButton.TextColor = Color.White;
            AddEventButton.UseVisualStyleBackColor = false;
            AddEventButton.Click += AddEventButton_Click;
            // 
            // Events_tab
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 232, 215);
            ClientSize = new Size(1226, 808);
            Controls.Add(UpcomingEventsData);
            Controls.Add(AddEventButton);
            Controls.Add(UpcomingEventsLabel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Events_tab";
            Text = "Events_tab";
            ((System.ComponentModel.ISupportInitialize)UpcomingEventsData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UpcomingEventsLabel;
        private ADETADET_sample.RBButton AddEventButton;
        private DataGridView UpcomingEventsData = new DataGridView();
    }
}