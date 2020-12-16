using CommonUtil.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFRGManager.Forms
{
    public partial class SettingsForm : Form
    {

        private  UISettings settings;

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void UpdateSettings()
        {
            settings.serviceURL = TB_serviceURL.Text;
            settings.addOrderURI = TB_addOrderURI.Text;
            settings.orderListRefreshRate = Int32.Parse(TB_orderListRefreshRate.Text);
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            UpdateSettings();
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            UpdateSettings();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            settings = UISettings.CreateSettings();
            TB_serviceURL.Text = settings.serviceURL;
            TB_addOrderURI.Text = settings.addOrderURI;
            TB_orderListRefreshRate.Text = settings.orderListRefreshRate.ToString();
        }
    }
}
