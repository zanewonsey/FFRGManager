using CommonUtil;
using CommonUtil.Settings;
using FFRGManager.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFRGManager
{
    public partial class Form1 : Form
    {
        private OrderManager Order_Manager;
        private UISettings settings;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.settings = UISettings.CreateSettings();

            Order_Manager = new OrderManager();
            Order_Manager.Poll();

            foreach (Order O in Order_Manager.GetOrderList())
            {
                Orders_ListBox.Items.Add(O);
            }

            DateTime now = DateTime.Now;

            SearchStart_Date.Value = new DateTime(now.Year, now.Month, now.Day,  0,  0,  0);
            SearchStart_Time.Value = new DateTime(now.Year, now.Month, now.Day,  0,  0,  0);
            SearchEnd_Date.Value   = new DateTime(now.Year, now.Month, now.Day,  0,  0,  0);
            SearchEnd_Time.Value   = new DateTime(now.Year, now.Month, now.Day, 23, 59, 59);

            
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void PictureStatus_ComboBox_Populate(Order Ord)
        {
            PictureStatus_ComboBox.Items.Clear();
            for (ePictureStatus T = ePictureStatus.ePS_MIN+1; T < ePictureStatus.ePS_MAX; T++)
            {
                PictureStatus_ComboBox.Items.Add(PictureStatus.ePS_ToString(T));
                if (PictureStatus.ePS_ToString(T) == Ord.GetPictureStatus())
                {
                    PictureStatus_ComboBox.SelectedIndex = (int) T - 1;
                }
            }
        }

        private void Orders_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Order selectedOrder = (Order) Orders_ListBox.SelectedItem;
            if (selectedOrder == null) selectedOrder = new Order("", "", "", "", -1);

            OD_Street_Label.Text = selectedOrder.GetStreet();
            OD_City_Label.Text = selectedOrder.GetCity();
            OD_State_Label.Text = selectedOrder.GetState();
            OD_Zipcode_Label.Text = selectedOrder.GetZipcode();
            OD_DueDate_Label.Text = selectedOrder.GetDueDateStr();

            OrderDetails_RichTextBox.Text = selectedOrder.GetOrderDetails();

            PictureStatus_ComboBox_Populate(selectedOrder);
        }

        private void PictureStatus_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Order selectedOrder = (Order)Orders_ListBox.SelectedItem;
            
            if (selectedOrder != null)
            {
                selectedOrder.UpdatePictureStatus((ePictureStatus)PictureStatus_ComboBox.SelectedIndex + 1);
                //HttpMgr.PostObject(selectedOrder, settings.GetDeleteOrderUrl);
            }
        }

        private void UpdateSearch()
        {
            // Clear out the list so that we don't duplicate items
            Orders_ListBox.Items.Clear();

            DateTime DTsearchStart = SearchStart_Date.Value.Date + SearchStart_Time.Value.TimeOfDay;
            DateTime DTsearchEnd   = SearchEnd_Date.Value.Date + SearchEnd_Time.Value.TimeOfDay;

            // Build a sorted list
            List<Order> Ord = Order_Manager.GetOrderList().FindAll
                (
                    P => P.ToString().ToLower().Contains(GeneralSearch_TextBox.Text.ToLower())
                         && ((SearchPicturesRecieved_CheckBox.Checked) ? P.PicturesRecieved() : true)
                         && ((SearchUseDateTime_CheckBox.Checked) ? ( (DTsearchStart < P.GetDueDate()) && (P.GetDueDate() < DTsearchEnd) ) : true)
                );

            if (RB_Sort_City.Checked)
            {
                Ord = Ord.OrderBy(o => o.GetCity()).ToList();
            }
            else if (RB_Sort_DueDate.Checked)
            {
                Ord = Ord.OrderBy(o => o.GetDueDate()).ToList();
            }

            // Add the items from the built list to the list box for display
            foreach (Order O in Ord)
            {
                Orders_ListBox.Items.Add(O);
            }
        }

        private void GeneralSearch_TextChanged(object sender, EventArgs e)
        {
            UpdateSearch();
        }

        private void SearchPicturesRecieved_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSearch();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            UpdateSearch();
        }

        private void SearchUseDateTime_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSearch();
        }

        private void RB_Sort_None_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSearch();
        }

        private void RB_Sort_City_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSearch();
        }

        private void RB_Sort_DueDate_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSearch();
        }

        private void SearchStart_Date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SearchStart_Time_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SearchEnd_Date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SearchEnd_Time_ValueChanged(object sender, EventArgs e)
        {

        }

        private void GeneralAddOrder_Button_Click(object sender, EventArgs e)
        {
            var formPopup = new AddOrderForm();
            formPopup.Show(this); // if you need non-modal window
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void OrderDetails_RichTextBox_TextChanged(object sender, EventArgs e)
        {
            Order selectedOrder = (Order)Orders_ListBox.SelectedItem;
            if (selectedOrder != null) selectedOrder.UpdateOrderDetails(OrderDetails_RichTextBox.Text);
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formPopup = new SettingsForm();
            formPopup.Show(this); // if you need non-modal window
        }

        private void SearchCriteria_GroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void ToolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void OrderDetailsDelete_Button_Click(object sender, EventArgs e)
        {
            Order selectedOrder = (Order)Orders_ListBox.SelectedItem;
            if (selectedOrder != null) HttpMgr.DeleteObject(selectedOrder, settings.GetDeleteOrderUrl);
        }

        private void OrderDetailsSave_Button_Click(object sender, EventArgs e)
        {
            Order selectedOrder = (Order)Orders_ListBox.SelectedItem;
            if (selectedOrder != null) HttpMgr.PostObject(selectedOrder, settings.GetUpdateOrderUrl);
        }

    }
}
