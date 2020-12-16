using CommonUtil;
using CommonUtil.Settings;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace FFRGManager
{
    class OrderManager
    {
        // Singleton
        private OrderManager Order_Manager;
        private List<Order> OrderList;
        private static readonly HttpClient client = new HttpClient();
        private UISettings settings;

        public OrderManager()
        {
            if (Order_Manager == null)
            {
                OrderList = new List<Order>();
                settings = UISettings.CreateSettings();
            }
        }

        public void Add(Order Ord)
        {
            OrderList.Add(Ord);
        }

        public void Add(string StreetAddress, string City, string State, string Zipcode)
        {
            Add(new Order(StreetAddress, City, State, Zipcode,0));
        }

        public List<Order> GetOrderList()
        {
            // Force an update and return updated list
            Poll();
            return this.OrderList;
        }

        public void Poll()
        {
            try
            {
                OrderList.Clear();
                var des = HttpMgr.GetObject<List<Order>>(settings.GetOrderListURL);
                foreach (Order order in des)
                {
                    Add(order);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
