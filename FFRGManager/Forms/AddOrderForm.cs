using CommonUtil;
using CommonUtil.Settings;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFRGManager
{
    public partial class AddOrderForm : Form
    {
        private UISettings settings;

        public AddOrderForm()
        {
            InitializeComponent();
        }

        private void AddOrderForm_Load(object sender, EventArgs e)
        {
            settings = UISettings.CreateSettings();
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            HttpMgr.PutObject<Order>(new Order(TB_Address.Text, TB_City.Text, TB_State.Text, TB_Zip.Text, 0), settings.GetAddOrderURL);
            this.Close();
        }
    }
}
