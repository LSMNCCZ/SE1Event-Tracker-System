﻿
namespace ADET_sample
{
    partial class Main_Page
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Page));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1 = new Panel();
            button2 = new Button();
            EquipmentTab = new Button();
            Services_Button = new Button();
            Employee_Button = new Button();
            panel2 = new Panel();
            DatePicker = new MonthCalendar();
            Event_Button = new Button();
            imageList1 = new ImageList(components);
            mainpanel = new Panel();
            LogOutBTN = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 60, 24);
            panel1.Controls.Add(LogOutBTN);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(EquipmentTab);
            panel1.Controls.Add(Services_Button);
            panel1.Controls.Add(Employee_Button);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(Event_Button);
            panel1.Location = new Point(-6, -3);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(318, 814);
            panel1.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(4, 614);
            button2.Margin = new Padding(2, 3, 2, 3);
            button2.Name = "button2";
            button2.Padding = new Padding(20, 0, 0, 0);
            button2.Size = new Size(315, 84);
            button2.TabIndex = 6;
            button2.Text = "  Finance";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // EquipmentTab
            // 
            EquipmentTab.BackgroundImageLayout = ImageLayout.Zoom;
            EquipmentTab.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            EquipmentTab.FlatAppearance.BorderSize = 0;
            EquipmentTab.FlatStyle = FlatStyle.Flat;
            EquipmentTab.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EquipmentTab.ForeColor = Color.White;
            EquipmentTab.Image = (Image)resources.GetObject("EquipmentTab.Image");
            EquipmentTab.ImageAlign = ContentAlignment.MiddleLeft;
            EquipmentTab.Location = new Point(6, 524);
            EquipmentTab.Margin = new Padding(2, 3, 2, 3);
            EquipmentTab.Name = "EquipmentTab";
            EquipmentTab.Padding = new Padding(20, 0, 0, 0);
            EquipmentTab.Size = new Size(312, 84);
            EquipmentTab.TabIndex = 5;
            EquipmentTab.Text = "         Equipments";
            EquipmentTab.UseVisualStyleBackColor = true;
            EquipmentTab.Click += button1_Click;
            // 
            // Services_Button
            // 
            Services_Button.BackgroundImageLayout = ImageLayout.Zoom;
            Services_Button.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            Services_Button.FlatAppearance.BorderSize = 0;
            Services_Button.FlatStyle = FlatStyle.Flat;
            Services_Button.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Services_Button.ForeColor = Color.White;
            Services_Button.Image = (Image)resources.GetObject("Services_Button.Image");
            Services_Button.ImageAlign = ContentAlignment.MiddleLeft;
            Services_Button.Location = new Point(6, 434);
            Services_Button.Margin = new Padding(2, 3, 2, 3);
            Services_Button.Name = "Services_Button";
            Services_Button.Padding = new Padding(20, 0, 0, 0);
            Services_Button.Size = new Size(312, 84);
            Services_Button.TabIndex = 4;
            Services_Button.Text = "    Services";
            Services_Button.UseVisualStyleBackColor = true;
            Services_Button.Click += Services_Button_Click;
            // 
            // Employee_Button
            // 
            Employee_Button.BackgroundImageLayout = ImageLayout.Zoom;
            Employee_Button.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            Employee_Button.FlatAppearance.BorderSize = 0;
            Employee_Button.FlatStyle = FlatStyle.Flat;
            Employee_Button.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Employee_Button.ForeColor = Color.White;
            Employee_Button.Image = (Image)resources.GetObject("Employee_Button.Image");
            Employee_Button.ImageAlign = ContentAlignment.MiddleLeft;
            Employee_Button.Location = new Point(6, 343);
            Employee_Button.Margin = new Padding(2, 3, 2, 3);
            Employee_Button.Name = "Employee_Button";
            Employee_Button.Padding = new Padding(20, 0, 0, 0);
            Employee_Button.Size = new Size(314, 84);
            Employee_Button.TabIndex = 3;
            Employee_Button.Text = "       Employees";
            Employee_Button.UseVisualStyleBackColor = true;
            Employee_Button.Click += Employee_Button_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 40, 16);
            panel2.Controls.Add(DatePicker);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2, 3, 2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(320, 253);
            panel2.TabIndex = 2;
            // 
            // DatePicker
            // 
            DatePicker.BackColor = Color.FromArgb(30, 40, 16);
            DatePicker.ForeColor = SystemColors.InactiveCaption;
            DatePicker.Location = new Point(6, 0);
            DatePicker.Name = "DatePicker";
            DatePicker.TabIndex = 9;
            DatePicker.TitleBackColor = SystemColors.ActiveBorder;
            DatePicker.TitleForeColor = SystemColors.AppWorkspace;
            DatePicker.TrailingForeColor = SystemColors.ControlText;
            DatePicker.DateChanged += monthCalendar1_DateChanged;
            // 
            // Event_Button
            // 
            Event_Button.BackgroundImageLayout = ImageLayout.Zoom;
            Event_Button.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            Event_Button.FlatAppearance.BorderSize = 0;
            Event_Button.FlatStyle = FlatStyle.Flat;
            Event_Button.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Event_Button.ForeColor = Color.White;
            Event_Button.Image = (Image)resources.GetObject("Event_Button.Image");
            Event_Button.ImageAlign = ContentAlignment.MiddleLeft;
            Event_Button.Location = new Point(8, 254);
            Event_Button.Margin = new Padding(2, 3, 2, 3);
            Event_Button.Name = "Event_Button";
            Event_Button.Padding = new Padding(20, 0, 0, 0);
            Event_Button.Size = new Size(310, 84);
            Event_Button.TabIndex = 2;
            Event_Button.Text = "Events";
            Event_Button.UseVisualStyleBackColor = true;
            Event_Button.Click += Event_Button_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // mainpanel
            // 
            mainpanel.Location = new Point(318, 1);
            mainpanel.Margin = new Padding(4);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(1226, 808);
            mainpanel.TabIndex = 10;
            mainpanel.Paint += mainpanel_Paint;
            // 
            // LogOutBTN
            // 
            LogOutBTN.BackColor = Color.Black;
            LogOutBTN.BackgroundImageLayout = ImageLayout.Zoom;
            LogOutBTN.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            LogOutBTN.FlatAppearance.BorderSize = 0;
            LogOutBTN.FlatStyle = FlatStyle.Flat;
            LogOutBTN.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogOutBTN.ForeColor = Color.White;
            LogOutBTN.Location = new Point(6, 770);
            LogOutBTN.Margin = new Padding(2, 3, 2, 3);
            LogOutBTN.Name = "LogOutBTN";
            LogOutBTN.Padding = new Padding(20, 0, 0, 0);
            LogOutBTN.Size = new Size(310, 42);
            LogOutBTN.TabIndex = 7;
            LogOutBTN.Text = "Log Out";
            LogOutBTN.UseVisualStyleBackColor = false;
            LogOutBTN.UseWaitCursor = true;
            LogOutBTN.Click += LogOutBTN_Click;
            // 
            // Main_Page
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 232, 215);
            ClientSize = new Size(1541, 809);
            Controls.Add(panel1);
            Controls.Add(mainpanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            Name = "Main_Page";
            Text = "Matcha Event System";
            Load += Main_Page_Load_1;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private Panel panel1;
        private Button Services_Button;
        private Button Event_Button;
        private Panel panel2;
        private ImageList imageList1;
        private Button Employee_Button;
        private MonthCalendar monthCalendar1;
        public MonthCalendar DatePicker;
        private Panel mainpanel;
        private Button EquipmentTab;
        private Button button2;
        private Button LogOutBTN;
    }
}
