namespace FFRGManager.Forms
{
    partial class SettingsForm
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
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.serviceURLLabel = new System.Windows.Forms.Label();
            this.addOrderURILabel = new System.Windows.Forms.Label();
            this.orderListRefreshRateLabel = new System.Windows.Forms.Label();
            this.TB_serviceURL = new System.Windows.Forms.TextBox();
            this.TB_addOrderURI = new System.Windows.Forms.TextBox();
            this.TB_orderListRefreshRate = new System.Windows.Forms.TextBox();
            this.TB_Port = new System.Windows.Forms.TextBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(12, 119);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(51, 23);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "Ok";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(90, 119);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(57, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(167, 119);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(57, 23);
            this.ApplyButton.TabIndex = 2;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // serviceURLLabel
            // 
            this.serviceURLLabel.AutoSize = true;
            this.serviceURLLabel.Location = new System.Drawing.Point(13, 13);
            this.serviceURLLabel.Name = "serviceURLLabel";
            this.serviceURLLabel.Size = new System.Drawing.Size(63, 13);
            this.serviceURLLabel.TabIndex = 3;
            this.serviceURLLabel.Text = "serviceURL";
            // 
            // addOrderURILabel
            // 
            this.addOrderURILabel.AutoSize = true;
            this.addOrderURILabel.Location = new System.Drawing.Point(13, 39);
            this.addOrderURILabel.Name = "addOrderURILabel";
            this.addOrderURILabel.Size = new System.Drawing.Size(70, 13);
            this.addOrderURILabel.TabIndex = 4;
            this.addOrderURILabel.Text = "addOrderURI";
            // 
            // orderListRefreshRateLabel
            // 
            this.orderListRefreshRateLabel.AutoSize = true;
            this.orderListRefreshRateLabel.Location = new System.Drawing.Point(13, 70);
            this.orderListRefreshRateLabel.Name = "orderListRefreshRateLabel";
            this.orderListRefreshRateLabel.Size = new System.Drawing.Size(107, 13);
            this.orderListRefreshRateLabel.TabIndex = 5;
            this.orderListRefreshRateLabel.Text = "orderListRefreshRate";
            // 
            // TB_serviceURL
            // 
            this.TB_serviceURL.Location = new System.Drawing.Point(124, 13);
            this.TB_serviceURL.Name = "TB_serviceURL";
            this.TB_serviceURL.Size = new System.Drawing.Size(100, 20);
            this.TB_serviceURL.TabIndex = 6;
            this.TB_serviceURL.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // TB_addOrderURI
            // 
            this.TB_addOrderURI.Location = new System.Drawing.Point(124, 40);
            this.TB_addOrderURI.Name = "TB_addOrderURI";
            this.TB_addOrderURI.Size = new System.Drawing.Size(100, 20);
            this.TB_addOrderURI.TabIndex = 7;
            // 
            // TB_orderListRefreshRate
            // 
            this.TB_orderListRefreshRate.Location = new System.Drawing.Point(124, 67);
            this.TB_orderListRefreshRate.Name = "TB_orderListRefreshRate";
            this.TB_orderListRefreshRate.Size = new System.Drawing.Size(100, 20);
            this.TB_orderListRefreshRate.TabIndex = 8;
            // 
            // TB_Port
            // 
            this.TB_Port.Location = new System.Drawing.Point(124, 93);
            this.TB_Port.Name = "TB_Port";
            this.TB_Port.Size = new System.Drawing.Size(100, 20);
            this.TB_Port.TabIndex = 10;
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(13, 96);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(25, 13);
            this.portLabel.TabIndex = 9;
            this.portLabel.Text = "port";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 151);
            this.Controls.Add(this.TB_Port);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.TB_orderListRefreshRate);
            this.Controls.Add(this.TB_addOrderURI);
            this.Controls.Add(this.TB_serviceURL);
            this.Controls.Add(this.orderListRefreshRateLabel);
            this.Controls.Add(this.addOrderURILabel);
            this.Controls.Add(this.serviceURLLabel);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Label serviceURLLabel;
        private System.Windows.Forms.Label addOrderURILabel;
        private System.Windows.Forms.Label orderListRefreshRateLabel;
        private System.Windows.Forms.TextBox TB_serviceURL;
        private System.Windows.Forms.TextBox TB_addOrderURI;
        private System.Windows.Forms.TextBox TB_orderListRefreshRate;
        private System.Windows.Forms.TextBox TB_Port;
        private System.Windows.Forms.Label portLabel;
    }
}