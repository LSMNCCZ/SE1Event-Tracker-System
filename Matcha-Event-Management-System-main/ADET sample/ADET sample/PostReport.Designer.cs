namespace ADET_sample
{
    partial class PostReport
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
            PostReportLabel = new Label();
            PostEReportPanel = new Panel();
            CommentsTB = new TextBox();
            EquipTB = new TextBox();
            CommentsLabel = new Label();
            PaperCountTB = new TextBox();
            textBox3 = new TextBox();
            equipConCB = new ComboBox();
            outputQualityLabel = new Label();
            PaperCount = new Label();
            EquipCon = new Label();
            EventID = new TextBox();
            eventIDLabel = new Label();
            ReportID = new TextBox();
            ReportIDLabel = new Label();
            SumbitBTN = new ADETADET_sample.RBButton();
            PostEReportPanel.SuspendLayout();
            SuspendLayout();
            // 
            // PostReportLabel
            // 
            PostReportLabel.AutoSize = true;
            PostReportLabel.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PostReportLabel.Location = new Point(-1, 6);
            PostReportLabel.Margin = new Padding(4, 0, 4, 0);
            PostReportLabel.Name = "PostReportLabel";
            PostReportLabel.Size = new Size(351, 43);
            PostReportLabel.TabIndex = 2;
            PostReportLabel.Text = "Post-Event Report";
            // 
            // PostEReportPanel
            // 
            PostEReportPanel.BorderStyle = BorderStyle.FixedSingle;
            PostEReportPanel.Controls.Add(CommentsTB);
            PostEReportPanel.Controls.Add(EquipTB);
            PostEReportPanel.Controls.Add(CommentsLabel);
            PostEReportPanel.Controls.Add(PaperCountTB);
            PostEReportPanel.Controls.Add(textBox3);
            PostEReportPanel.Controls.Add(equipConCB);
            PostEReportPanel.Controls.Add(outputQualityLabel);
            PostEReportPanel.Controls.Add(PaperCount);
            PostEReportPanel.Controls.Add(EquipCon);
            PostEReportPanel.Controls.Add(EventID);
            PostEReportPanel.Controls.Add(eventIDLabel);
            PostEReportPanel.Controls.Add(ReportID);
            PostEReportPanel.Controls.Add(ReportIDLabel);
            PostEReportPanel.Location = new Point(11, 52);
            PostEReportPanel.Margin = new Padding(2, 3, 2, 3);
            PostEReportPanel.Name = "PostEReportPanel";
            PostEReportPanel.Size = new Size(750, 340);
            PostEReportPanel.TabIndex = 6;
            // 
            // CommentsTB
            // 
            CommentsTB.BackColor = Color.FromArgb(223, 232, 215);
            CommentsTB.BorderStyle = BorderStyle.FixedSingle;
            CommentsTB.Location = new Point(390, 184);
            CommentsTB.Margin = new Padding(2, 3, 2, 3);
            CommentsTB.Multiline = true;
            CommentsTB.Name = "CommentsTB";
            CommentsTB.PlaceholderText = "Comments...";
            CommentsTB.Size = new Size(343, 146);
            CommentsTB.TabIndex = 89;
            // 
            // EquipTB
            // 
            EquipTB.BackColor = Color.FromArgb(223, 232, 215);
            EquipTB.BorderStyle = BorderStyle.FixedSingle;
            EquipTB.Location = new Point(15, 184);
            EquipTB.Margin = new Padding(2, 3, 2, 3);
            EquipTB.Multiline = true;
            EquipTB.Name = "EquipTB";
            EquipTB.PlaceholderText = "How are the equipments before, during and after the event?";
            EquipTB.Size = new Size(343, 146);
            EquipTB.TabIndex = 88;
            // 
            // CommentsLabel
            // 
            CommentsLabel.AutoSize = true;
            CommentsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            CommentsLabel.Location = new Point(390, 148);
            CommentsLabel.Margin = new Padding(4, 0, 4, 0);
            CommentsLabel.Name = "CommentsLabel";
            CommentsLabel.Size = new Size(143, 32);
            CommentsLabel.TabIndex = 87;
            CommentsLabel.Text = "Comments:";
            CommentsLabel.Click += label1_Click;
            // 
            // PaperCountTB
            // 
            PaperCountTB.BackColor = Color.FromArgb(223, 232, 215);
            PaperCountTB.BorderStyle = BorderStyle.None;
            PaperCountTB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PaperCountTB.Location = new Point(549, 81);
            PaperCountTB.Margin = new Padding(2, 3, 2, 3);
            PaperCountTB.MaxLength = 8;
            PaperCountTB.Name = "PaperCountTB";
            PaperCountTB.PlaceholderText = "00";
            PaperCountTB.Size = new Size(114, 32);
            PaperCountTB.TabIndex = 86;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(223, 232, 215);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(548, 85);
            textBox3.Margin = new Padding(2, 3, 2, 3);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(86, 32);
            textBox3.TabIndex = 85;
            textBox3.Text = "__________________________________________";
            // 
            // equipConCB
            // 
            equipConCB.BackColor = Color.FromArgb(223, 232, 215);
            equipConCB.DropDownStyle = ComboBoxStyle.DropDownList;
            equipConCB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            equipConCB.FormattingEnabled = true;
            equipConCB.Items.AddRange(new object[] { "Average", "Good", "High Quality", "Poor", "Very Poor" });
            equipConCB.Location = new Point(204, 78);
            equipConCB.Margin = new Padding(2, 3, 2, 3);
            equipConCB.Name = "equipConCB";
            equipConCB.Size = new Size(154, 40);
            equipConCB.Sorted = true;
            equipConCB.TabIndex = 84;
            // 
            // outputQualityLabel
            // 
            outputQualityLabel.AutoSize = true;
            outputQualityLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            outputQualityLabel.Location = new Point(15, 81);
            outputQualityLabel.Margin = new Padding(4, 0, 4, 0);
            outputQualityLabel.Name = "outputQualityLabel";
            outputQualityLabel.Size = new Size(198, 32);
            outputQualityLabel.TabIndex = 77;
            outputQualityLabel.Text = "Output Quality: ";
            // 
            // PaperCount
            // 
            PaperCount.AutoSize = true;
            PaperCount.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            PaperCount.Location = new Point(390, 81);
            PaperCount.Margin = new Padding(4, 0, 4, 0);
            PaperCount.Name = "PaperCount";
            PaperCount.Size = new Size(162, 32);
            PaperCount.TabIndex = 76;
            PaperCount.Text = "Paper Count:";
            // 
            // EquipCon
            // 
            EquipCon.AutoSize = true;
            EquipCon.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            EquipCon.Location = new Point(15, 148);
            EquipCon.Margin = new Padding(4, 0, 4, 0);
            EquipCon.Name = "EquipCon";
            EquipCon.Size = new Size(265, 32);
            EquipCon.TabIndex = 75;
            EquipCon.Text = "Equipment Condition:";
            // 
            // EventID
            // 
            EventID.BackColor = Color.FromArgb(223, 232, 215);
            EventID.BorderStyle = BorderStyle.None;
            EventID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EventID.Location = new Point(507, 12);
            EventID.Margin = new Padding(2, 3, 2, 3);
            EventID.MaxLength = 8;
            EventID.Name = "EventID";
            EventID.PlaceholderText = "XXXXXXXX";
            EventID.ReadOnly = true;
            EventID.Size = new Size(127, 32);
            EventID.TabIndex = 74;
            // 
            // eventIDLabel
            // 
            eventIDLabel.AutoSize = true;
            eventIDLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            eventIDLabel.Location = new Point(390, 13);
            eventIDLabel.Margin = new Padding(4, 0, 4, 0);
            eventIDLabel.Name = "eventIDLabel";
            eventIDLabel.Size = new Size(117, 32);
            eventIDLabel.TabIndex = 73;
            eventIDLabel.Text = "Event ID:";
            // 
            // ReportID
            // 
            ReportID.BackColor = Color.FromArgb(223, 232, 215);
            ReportID.BorderStyle = BorderStyle.None;
            ReportID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReportID.Location = new Point(143, 11);
            ReportID.Margin = new Padding(2, 3, 2, 3);
            ReportID.MaxLength = 8;
            ReportID.Name = "ReportID";
            ReportID.PlaceholderText = "XXXXXXXX";
            ReportID.ReadOnly = true;
            ReportID.Size = new Size(127, 32);
            ReportID.TabIndex = 72;
            // 
            // ReportIDLabel
            // 
            ReportIDLabel.AutoSize = true;
            ReportIDLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ReportIDLabel.Location = new Point(15, 11);
            ReportIDLabel.Margin = new Padding(4, 0, 4, 0);
            ReportIDLabel.Name = "ReportIDLabel";
            ReportIDLabel.Size = new Size(132, 32);
            ReportIDLabel.TabIndex = 70;
            ReportIDLabel.Text = "Report ID:";
            // 
            // SumbitBTN
            // 
            SumbitBTN.BackColor = Color.FromArgb(46, 60, 24);
            SumbitBTN.BackgroundColor = Color.FromArgb(46, 60, 24);
            SumbitBTN.BorderColor = Color.PaleVioletRed;
            SumbitBTN.BorderRadius = 8;
            SumbitBTN.BorderSize = 0;
            SumbitBTN.FlatAppearance.BorderSize = 0;
            SumbitBTN.FlatStyle = FlatStyle.Flat;
            SumbitBTN.ForeColor = Color.White;
            SumbitBTN.Location = new Point(11, 397);
            SumbitBTN.Margin = new Padding(2, 3, 2, 3);
            SumbitBTN.Name = "SumbitBTN";
            SumbitBTN.Size = new Size(750, 39);
            SumbitBTN.TabIndex = 90;
            SumbitBTN.Text = "Submit Report";
            SumbitBTN.TextColor = Color.White;
            SumbitBTN.UseVisualStyleBackColor = false;
            SumbitBTN.Click += SumbitBTN_Click_1;
            // 
            // PostReport
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 232, 215);
            ClientSize = new Size(770, 441);
            Controls.Add(SumbitBTN);
            Controls.Add(PostEReportPanel);
            Controls.Add(PostReportLabel);
            Name = "PostReport";
            Text = "Post Event Report";
            PostEReportPanel.ResumeLayout(false);
            PostEReportPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PostReportLabel;
        private Panel PostEReportPanel;
        private Label ReportIDLabel;
        private TextBox ReportID;
        private Label PaperCount;
        private Label EquipCon;
        private TextBox EventID;
        private Label eventIDLabel;
        private Label outputQualityLabel;
        private Label CommentsLabel;
        private TextBox PaperCountTB;
        private TextBox textBox3;
        private ComboBox equipConCB;
        private TextBox CommentsTB;
        private TextBox EquipTB;
        public ADETADET_sample.RBButton SumbitBTN;
    }
}