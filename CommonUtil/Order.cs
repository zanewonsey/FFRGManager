using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonUtil
{
    public class Order
    {
        [JsonProperty("Order_ID", NullValueHandling = NullValueHandling.Ignore)]
        private int Order_ID;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        private string StreetAddress;

        [JsonProperty("City", NullValueHandling = NullValueHandling.Ignore)]
        private string City;

        [JsonProperty("State", NullValueHandling = NullValueHandling.Ignore)]
        private string State;

        [JsonProperty("Zipcode", NullValueHandling = NullValueHandling.Ignore)]
        private string Zipcode;

        [JsonProperty("details", NullValueHandling = NullValueHandling.Ignore)]
        private string details;

        [JsonProperty("DueDate", NullValueHandling = NullValueHandling.Ignore)]
        private DateTime DueDate;

        [JsonProperty("PicStatus", NullValueHandling = NullValueHandling.Ignore)]
        private PictureStatus PicStatus;

        public Order()
        {
            PicStatus = new PictureStatus();
        }

        public Order(string StreetAddress, string City, string State, string Zipcode, int Order_ID)
        {
            this.StreetAddress = StreetAddress;
            this.City = City;
            this.State = State;
            this.Zipcode = Zipcode;
            this.Order_ID = Order_ID;

            PicStatus = new PictureStatus();
        }

        public override string ToString()
        {
            return StreetAddress + ", " + City + ", " + State + " " + Zipcode;
        }

        public int GetOrderID()
        {
            return this.Order_ID;
        }

        public string GetStreet()
        {
            return this.StreetAddress;
        }

        public string GetCity()
        {
            return this.City;
        }

        public string GetState()
        {
            return this.State;
        }

        public string GetZipcode()
        {
            return this.Zipcode;
        }

        public string GetOrderDetails()
        {
            return this.details;
        }

        public void UpdateOrderDetails(string updatedDetails)
        {
            this.details = updatedDetails;
        }

        public DateTime GetDueDate()
        {
            return this.DueDate;
        }

        public string GetDueDateStr()
        {
            return this.DueDate.ToString();
        }

        public void SetDueDate(DateTime DueDate)
        {
            this.DueDate = DueDate;
        }

        public string GetPictureStatus()
        {
            return PicStatus.GetPictureStatusString();
        }

        public int GetPictureStatusInt()
        {
            return (int) PicStatus.GetPictureStatusEnum();
        }

        public bool PicturesRecieved()
        {
            return PicStatus.GetPictureStatusEnum() == ePictureStatus.ePS_Recieved;
        }

        public void UpdatePictureStatus(ePictureStatus ePS)
        {
            PicStatus.SetPictureStatus(ePS);
        }
    }
}
