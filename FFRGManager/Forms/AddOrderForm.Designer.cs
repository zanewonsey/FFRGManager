namespace FFRGManager
{
    partial class AddOrderForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TB_Zip = new System.Windows.Forms.TextBox();
            this.TB_State = new System.Windows.Forms.TextBox();
            this.TB_City = new System.Windows.Forms.TextBox();
            this.TB_Address = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SubmitOrderButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TB_Zip);
            this.groupBox1.Controls.Add(this.TB_State);
            this.groupBox1.Controls.Add(this.TB_City);
            this.groupBox1.Controls.Add(this.TB_Address);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 121);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Address";
            // 
            // TB_Zip
            // 
            this.TB_Zip.Location = new System.Drawing.Point(51, 94);
            this.TB_Zip.Name = "TB_Zip";
            this.TB_Zip.Size = new System.Drawing.Size(100, 20);
            this.TB_Zip.TabIndex = 8;
            // 
            // TB_State
            // 
            this.TB_State.Location = new System.Drawing.Point(51, 68);
            this.TB_State.Name = "TB_State";
            this.TB_State.Size = new System.Drawing.Size(100, 20);
            this.TB_State.TabIndex = 7;
            // 
            // TB_City
            // 
            this.TB_City.Location = new System.Drawing.Point(51, 42);
            this.TB_City.Name = "TB_City";
            this.TB_City.Size = new System.Drawing.Size(257, 20);
            this.TB_City.TabIndex = 6;
            // 
            // TB_Address
            // 
            this.TB_Address.Location = new System.Drawing.Point(51, 16);
            this.TB_Address.Name = "TB_Address";
            this.TB_Address.Size = new System.Drawing.Size(257, 20);
            this.TB_Address.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Street:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Zip:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "City:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "State:";
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(6, 19);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(200, 20);
            this.DatePicker.TabIndex = 7;
            // 
            // TimePicker
            // 
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePicker.Location = new System.Drawing.Point(6, 45);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.Size = new System.Drawing.Size(95, 20);
            this.TimePicker.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DatePicker);
            this.groupBox2.Controls.Add(this.TimePicker);
            this.groupBox2.Location = new System.Drawing.Point(332, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 121);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Due Date";
            this.groupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // SubmitOrderButton
            // 
            this.SubmitOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitOrderButton.Location = new System.Drawing.Point(12, 139);
            this.SubmitOrderButton.Name = "SubmitOrderButton";
            this.SubmitOrderButton.Size = new System.Drawing.Size(534, 44);
            this.SubmitOrderButton.TabIndex = 10;
            this.SubmitOrderButton.Text = "Submit";
            this.SubmitOrderButton.UseVisualStyleBackColor = true;
            this.SubmitOrderButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // AddOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 195);
            this.Controls.Add(this.SubmitOrderButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddOrderForm";
            this.Text = "Add Order";
            this.Load += new System.EventHandler(this.AddOrderForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Zip;
        private System.Windows.Forms.TextBox TB_State;
        private System.Windows.Forms.TextBox TB_City;
        private System.Windows.Forms.TextBox TB_Address;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.DateTimePicker TimePicker;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SubmitOrderButton;
    }
}