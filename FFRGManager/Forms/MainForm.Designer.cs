namespace FFRGManager
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.GeneralAddOrder_Button = new System.Windows.Forms.Button();
            this.OrderDetails_GroupBox = new System.Windows.Forms.GroupBox();
            this.OrderDetailsDelete_Button = new System.Windows.Forms.Button();
            this.OrderDetails_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PictureStatus_ComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OD_Zipcode_Label = new System.Windows.Forms.Label();
            this.OD_State_Label = new System.Windows.Forms.Label();
            this.OD_City_Label = new System.Windows.Forms.Label();
            this.OD_Street_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OrderDetailsSave_Button = new System.Windows.Forms.Button();
            this.SearchCriteria_GroupBox = new System.Windows.Forms.GroupBox();
            this.GeneralSearch_TextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SearchEnd_Time = new System.Windows.Forms.DateTimePicker();
            this.SearchStart_Time = new System.Windows.Forms.DateTimePicker();
            this.SearchPicturesRecieved_CheckBox = new System.Windows.Forms.CheckBox();
            this.SearchEnd_Date = new System.Windows.Forms.DateTimePicker();
            this.SearchStart_Date = new System.Windows.Forms.DateTimePicker();
            this.Orders_ListBox = new System.Windows.Forms.ListBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.GB_Sorting = new System.Windows.Forms.GroupBox();
            this.RB_Sort_None = new System.Windows.Forms.RadioButton();
            this.RB_Sort_City = new System.Windows.Forms.RadioButton();
            this.RB_Sort_DueDate = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.OD_DueDate_Label = new System.Windows.Forms.Label();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.SearchUseDateTime_CheckBox = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.OrderDetails_GroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SearchCriteria_GroupBox.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.GB_Sorting.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 52);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1106, 616);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.GeneralAddOrder_Button);
            this.tabPage1.Controls.Add(this.OrderDetails_GroupBox);
            this.tabPage1.Controls.Add(this.SearchCriteria_GroupBox);
            this.tabPage1.Controls.Add(this.Orders_ListBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1098, 590);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // GeneralAddOrder_Button
            // 
            this.GeneralAddOrder_Button.Location = new System.Drawing.Point(7, 538);
            this.GeneralAddOrder_Button.Name = "GeneralAddOrder_Button";
            this.GeneralAddOrder_Button.Size = new System.Drawing.Size(365, 40);
            this.GeneralAddOrder_Button.TabIndex = 3;
            this.GeneralAddOrder_Button.Text = "Add Order";
            this.GeneralAddOrder_Button.UseVisualStyleBackColor = true;
            this.GeneralAddOrder_Button.Click += new System.EventHandler(this.GeneralAddOrder_Button_Click);
            // 
            // OrderDetails_GroupBox
            // 
            this.OrderDetails_GroupBox.Controls.Add(this.OrderDetailsDelete_Button);
            this.OrderDetails_GroupBox.Controls.Add(this.OrderDetails_RichTextBox);
            this.OrderDetails_GroupBox.Controls.Add(this.groupBox2);
            this.OrderDetails_GroupBox.Controls.Add(this.groupBox1);
            this.OrderDetails_GroupBox.Controls.Add(this.OrderDetailsSave_Button);
            this.OrderDetails_GroupBox.Location = new System.Drawing.Point(378, 8);
            this.OrderDetails_GroupBox.Name = "OrderDetails_GroupBox";
            this.OrderDetails_GroupBox.Size = new System.Drawing.Size(714, 576);
            this.OrderDetails_GroupBox.TabIndex = 2;
            this.OrderDetails_GroupBox.TabStop = false;
            this.OrderDetails_GroupBox.Text = "Order Details";
            this.OrderDetails_GroupBox.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // OrderDetailsDelete_Button
            // 
            this.OrderDetailsDelete_Button.Location = new System.Drawing.Point(360, 522);
            this.OrderDetailsDelete_Button.Name = "OrderDetailsDelete_Button";
            this.OrderDetailsDelete_Button.Size = new System.Drawing.Size(348, 48);
            this.OrderDetailsDelete_Button.TabIndex = 9;
            this.OrderDetailsDelete_Button.Text = "Delete Order";
            this.OrderDetailsDelete_Button.UseVisualStyleBackColor = true;
            this.OrderDetailsDelete_Button.Click += new System.EventHandler(this.OrderDetailsDelete_Button_Click);
            // 
            // OrderDetails_RichTextBox
            // 
            this.OrderDetails_RichTextBox.Location = new System.Drawing.Point(274, 20);
            this.OrderDetails_RichTextBox.Name = "OrderDetails_RichTextBox";
            this.OrderDetails_RichTextBox.Size = new System.Drawing.Size(434, 496);
            this.OrderDetails_RichTextBox.TabIndex = 8;
            this.OrderDetails_RichTextBox.Text = "";
            this.OrderDetails_RichTextBox.TextChanged += new System.EventHandler(this.OrderDetails_RichTextBox_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PictureStatus_ComboBox);
            this.groupBox2.Location = new System.Drawing.Point(7, 326);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 190);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status";
            // 
            // PictureStatus_ComboBox
            // 
            this.PictureStatus_ComboBox.FormattingEnabled = true;
            this.PictureStatus_ComboBox.Location = new System.Drawing.Point(6, 20);
            this.PictureStatus_ComboBox.Name = "PictureStatus_ComboBox";
            this.PictureStatus_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.PictureStatus_ComboBox.TabIndex = 7;
            this.PictureStatus_ComboBox.SelectedIndexChanged += new System.EventHandler(this.PictureStatus_ComboBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OD_DueDate_Label);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.OD_Zipcode_Label);
            this.groupBox1.Controls.Add(this.OD_State_Label);
            this.groupBox1.Controls.Add(this.OD_City_Label);
            this.groupBox1.Controls.Add(this.OD_Street_Label);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(7, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 301);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Address";
            // 
            // OD_Zipcode_Label
            // 
            this.OD_Zipcode_Label.AutoSize = true;
            this.OD_Zipcode_Label.Location = new System.Drawing.Point(51, 60);
            this.OD_Zipcode_Label.Name = "OD_Zipcode_Label";
            this.OD_Zipcode_Label.Size = new System.Drawing.Size(97, 13);
            this.OD_Zipcode_Label.TabIndex = 8;
            this.OD_Zipcode_Label.Text = "_______________";
            // 
            // OD_State_Label
            // 
            this.OD_State_Label.AutoSize = true;
            this.OD_State_Label.Location = new System.Drawing.Point(51, 47);
            this.OD_State_Label.Name = "OD_State_Label";
            this.OD_State_Label.Size = new System.Drawing.Size(97, 13);
            this.OD_State_Label.TabIndex = 7;
            this.OD_State_Label.Text = "_______________";
            // 
            // OD_City_Label
            // 
            this.OD_City_Label.AutoSize = true;
            this.OD_City_Label.Location = new System.Drawing.Point(51, 31);
            this.OD_City_Label.Name = "OD_City_Label";
            this.OD_City_Label.Size = new System.Drawing.Size(97, 13);
            this.OD_City_Label.TabIndex = 6;
            this.OD_City_Label.Text = "_______________";
            // 
            // OD_Street_Label
            // 
            this.OD_Street_Label.AutoSize = true;
            this.OD_Street_Label.Location = new System.Drawing.Point(51, 15);
            this.OD_Street_Label.Name = "OD_Street_Label";
            this.OD_Street_Label.Size = new System.Drawing.Size(97, 13);
            this.OD_Street_Label.TabIndex = 5;
            this.OD_Street_Label.Text = "_______________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Street:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Zip:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "City:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "State:";
            // 
            // OrderDetailsSave_Button
            // 
            this.OrderDetailsSave_Button.Location = new System.Drawing.Point(7, 522);
            this.OrderDetailsSave_Button.Name = "OrderDetailsSave_Button";
            this.OrderDetailsSave_Button.Size = new System.Drawing.Size(330, 48);
            this.OrderDetailsSave_Button.TabIndex = 1;
            this.OrderDetailsSave_Button.Text = "Save Updates!";
            this.OrderDetailsSave_Button.UseVisualStyleBackColor = true;
            this.OrderDetailsSave_Button.Click += new System.EventHandler(this.OrderDetailsSave_Button_Click);
            // 
            // SearchCriteria_GroupBox
            // 
            this.SearchCriteria_GroupBox.Controls.Add(this.SearchUseDateTime_CheckBox);
            this.SearchCriteria_GroupBox.Controls.Add(this.SearchPicturesRecieved_CheckBox);
            this.SearchCriteria_GroupBox.Controls.Add(this.GB_Sorting);
            this.SearchCriteria_GroupBox.Controls.Add(this.GeneralSearch_TextBox);
            this.SearchCriteria_GroupBox.Controls.Add(this.label6);
            this.SearchCriteria_GroupBox.Controls.Add(this.label5);
            this.SearchCriteria_GroupBox.Controls.Add(this.SearchEnd_Time);
            this.SearchCriteria_GroupBox.Controls.Add(this.SearchStart_Time);
            this.SearchCriteria_GroupBox.Controls.Add(this.SearchEnd_Date);
            this.SearchCriteria_GroupBox.Controls.Add(this.SearchStart_Date);
            this.SearchCriteria_GroupBox.Location = new System.Drawing.Point(6, 6);
            this.SearchCriteria_GroupBox.Name = "SearchCriteria_GroupBox";
            this.SearchCriteria_GroupBox.Size = new System.Drawing.Size(366, 152);
            this.SearchCriteria_GroupBox.TabIndex = 1;
            this.SearchCriteria_GroupBox.TabStop = false;
            this.SearchCriteria_GroupBox.Text = "Search Criteria";
            this.SearchCriteria_GroupBox.Enter += new System.EventHandler(this.SearchCriteria_GroupBox_Enter);
            // 
            // GeneralSearch_TextBox
            // 
            this.GeneralSearch_TextBox.Location = new System.Drawing.Point(10, 115);
            this.GeneralSearch_TextBox.Name = "GeneralSearch_TextBox";
            this.GeneralSearch_TextBox.Size = new System.Drawing.Size(219, 20);
            this.GeneralSearch_TextBox.TabIndex = 7;
            this.GeneralSearch_TextBox.TextChanged += new System.EventHandler(this.GeneralSearch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "End";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Start";
            // 
            // SearchEnd_Time
            // 
            this.SearchEnd_Time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.SearchEnd_Time.Location = new System.Drawing.Point(144, 43);
            this.SearchEnd_Time.Name = "SearchEnd_Time";
            this.SearchEnd_Time.ShowUpDown = true;
            this.SearchEnd_Time.Size = new System.Drawing.Size(85, 20);
            this.SearchEnd_Time.TabIndex = 4;
            this.SearchEnd_Time.ValueChanged += new System.EventHandler(this.SearchEnd_Time_ValueChanged);
            // 
            // SearchStart_Time
            // 
            this.SearchStart_Time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.SearchStart_Time.Location = new System.Drawing.Point(144, 17);
            this.SearchStart_Time.Name = "SearchStart_Time";
            this.SearchStart_Time.ShowUpDown = true;
            this.SearchStart_Time.Size = new System.Drawing.Size(85, 20);
            this.SearchStart_Time.TabIndex = 3;
            this.SearchStart_Time.ValueChanged += new System.EventHandler(this.SearchStart_Time_ValueChanged);
            // 
            // SearchPicturesRecieved_CheckBox
            // 
            this.SearchPicturesRecieved_CheckBox.AutoSize = true;
            this.SearchPicturesRecieved_CheckBox.Location = new System.Drawing.Point(10, 92);
            this.SearchPicturesRecieved_CheckBox.Name = "SearchPicturesRecieved_CheckBox";
            this.SearchPicturesRecieved_CheckBox.Size = new System.Drawing.Size(113, 17);
            this.SearchPicturesRecieved_CheckBox.TabIndex = 2;
            this.SearchPicturesRecieved_CheckBox.Text = "Pictures Recieved";
            this.SearchPicturesRecieved_CheckBox.UseVisualStyleBackColor = true;
            this.SearchPicturesRecieved_CheckBox.CheckedChanged += new System.EventHandler(this.SearchPicturesRecieved_CheckBox_CheckedChanged);
            // 
            // SearchEnd_Date
            // 
            this.SearchEnd_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.SearchEnd_Date.Location = new System.Drawing.Point(42, 43);
            this.SearchEnd_Date.Name = "SearchEnd_Date";
            this.SearchEnd_Date.Size = new System.Drawing.Size(96, 20);
            this.SearchEnd_Date.TabIndex = 1;
            this.SearchEnd_Date.ValueChanged += new System.EventHandler(this.SearchEnd_Date_ValueChanged);
            // 
            // SearchStart_Date
            // 
            this.SearchStart_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.SearchStart_Date.Location = new System.Drawing.Point(42, 17);
            this.SearchStart_Date.Name = "SearchStart_Date";
            this.SearchStart_Date.Size = new System.Drawing.Size(96, 20);
            this.SearchStart_Date.TabIndex = 0;
            this.SearchStart_Date.ValueChanged += new System.EventHandler(this.SearchStart_Date_ValueChanged);
            // 
            // Orders_ListBox
            // 
            this.Orders_ListBox.FormattingEnabled = true;
            this.Orders_ListBox.Location = new System.Drawing.Point(7, 164);
            this.Orders_ListBox.Name = "Orders_ListBox";
            this.Orders_ListBox.ScrollAlwaysVisible = true;
            this.Orders_ListBox.Size = new System.Drawing.Size(365, 368);
            this.Orders_ListBox.TabIndex = 0;
            this.Orders_ListBox.SelectedIndexChanged += new System.EventHandler(this.Orders_ListBox_SelectedIndexChanged);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1130, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.FileToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 671);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1130, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1130, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(99, 22);
            this.toolStripLabel1.Text = "<-- Force Refresh";
            this.toolStripLabel1.Click += new System.EventHandler(this.ToolStripLabel1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "FFRG Manager";
            this.notifyIcon1.Visible = true;
            // 
            // GB_Sorting
            // 
            this.GB_Sorting.Controls.Add(this.RB_Sort_DueDate);
            this.GB_Sorting.Controls.Add(this.RB_Sort_City);
            this.GB_Sorting.Controls.Add(this.RB_Sort_None);
            this.GB_Sorting.Location = new System.Drawing.Point(235, 17);
            this.GB_Sorting.Name = "GB_Sorting";
            this.GB_Sorting.Size = new System.Drawing.Size(125, 129);
            this.GB_Sorting.TabIndex = 8;
            this.GB_Sorting.TabStop = false;
            this.GB_Sorting.Text = "Sorting";
            // 
            // RB_Sort_None
            // 
            this.RB_Sort_None.AutoSize = true;
            this.RB_Sort_None.Checked = true;
            this.RB_Sort_None.Location = new System.Drawing.Point(6, 18);
            this.RB_Sort_None.Name = "RB_Sort_None";
            this.RB_Sort_None.Size = new System.Drawing.Size(51, 17);
            this.RB_Sort_None.TabIndex = 0;
            this.RB_Sort_None.TabStop = true;
            this.RB_Sort_None.Text = "None";
            this.RB_Sort_None.UseVisualStyleBackColor = true;
            this.RB_Sort_None.CheckedChanged += new System.EventHandler(this.RB_Sort_None_CheckedChanged);
            // 
            // RB_Sort_City
            // 
            this.RB_Sort_City.AutoSize = true;
            this.RB_Sort_City.Location = new System.Drawing.Point(6, 41);
            this.RB_Sort_City.Name = "RB_Sort_City";
            this.RB_Sort_City.Size = new System.Drawing.Size(42, 17);
            this.RB_Sort_City.TabIndex = 1;
            this.RB_Sort_City.Text = "City";
            this.RB_Sort_City.UseVisualStyleBackColor = true;
            this.RB_Sort_City.CheckedChanged += new System.EventHandler(this.RB_Sort_City_CheckedChanged);
            // 
            // RB_Sort_DueDate
            // 
            this.RB_Sort_DueDate.AutoSize = true;
            this.RB_Sort_DueDate.Location = new System.Drawing.Point(6, 64);
            this.RB_Sort_DueDate.Name = "RB_Sort_DueDate";
            this.RB_Sort_DueDate.Size = new System.Drawing.Size(71, 17);
            this.RB_Sort_DueDate.TabIndex = 2;
            this.RB_Sort_DueDate.Text = "Due Date";
            this.RB_Sort_DueDate.UseVisualStyleBackColor = true;
            this.RB_Sort_DueDate.CheckedChanged += new System.EventHandler(this.RB_Sort_DueDate_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Due:";
            // 
            // OD_DueDate_Label
            // 
            this.OD_DueDate_Label.AutoSize = true;
            this.OD_DueDate_Label.Location = new System.Drawing.Point(51, 77);
            this.OD_DueDate_Label.Name = "OD_DueDate_Label";
            this.OD_DueDate_Label.Size = new System.Drawing.Size(97, 13);
            this.OD_DueDate_Label.TabIndex = 10;
            this.OD_DueDate_Label.Text = "_______________";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // SearchUseDateTime_CheckBox
            // 
            this.SearchUseDateTime_CheckBox.AutoSize = true;
            this.SearchUseDateTime_CheckBox.Location = new System.Drawing.Point(10, 69);
            this.SearchUseDateTime_CheckBox.Name = "SearchUseDateTime_CheckBox";
            this.SearchUseDateTime_CheckBox.Size = new System.Drawing.Size(132, 17);
            this.SearchUseDateTime_CheckBox.TabIndex = 9;
            this.SearchUseDateTime_CheckBox.Text = "Use Date/Time in filter";
            this.SearchUseDateTime_CheckBox.UseVisualStyleBackColor = true;
            this.SearchUseDateTime_CheckBox.CheckedChanged += new System.EventHandler(this.SearchUseDateTime_CheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 693);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.Text = "FFRGBPOManager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.OrderDetails_GroupBox.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.SearchCriteria_GroupBox.ResumeLayout(false);
            this.SearchCriteria_GroupBox.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.GB_Sorting.ResumeLayout(false);
            this.GB_Sorting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox OrderDetails_GroupBox;
        private System.Windows.Forms.GroupBox SearchCriteria_GroupBox;
        private System.Windows.Forms.ListBox Orders_ListBox;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button OrderDetailsSave_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GeneralAddOrder_Button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker SearchEnd_Date;
        private System.Windows.Forms.DateTimePicker SearchStart_Date;
        private System.Windows.Forms.CheckBox SearchPicturesRecieved_CheckBox;
        private System.Windows.Forms.DateTimePicker SearchEnd_Time;
        private System.Windows.Forms.DateTimePicker SearchStart_Time;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label OD_Zipcode_Label;
        private System.Windows.Forms.Label OD_State_Label;
        private System.Windows.Forms.Label OD_City_Label;
        private System.Windows.Forms.Label OD_Street_Label;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.TextBox GeneralSearch_TextBox;
        private System.Windows.Forms.ComboBox PictureStatus_ComboBox;
        private System.Windows.Forms.RichTextBox OrderDetails_RichTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Button OrderDetailsDelete_Button;
        private System.Windows.Forms.GroupBox GB_Sorting;
        private System.Windows.Forms.RadioButton RB_Sort_DueDate;
        private System.Windows.Forms.RadioButton RB_Sort_City;
        private System.Windows.Forms.RadioButton RB_Sort_None;
        private System.Windows.Forms.Label OD_DueDate_Label;
        private System.Windows.Forms.Label label7;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.CheckBox SearchUseDateTime_CheckBox;
    }
}

