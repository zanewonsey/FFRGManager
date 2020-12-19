using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonUtil
{
    public enum ePictureStatus
    {
        ePS_MIN,
        ePS_Waiting,
        ePS_Routed,
        ePS_Recieved,
        ePS_SentForReshoot,
        ePS_MAX
    }

    public class PictureStatus
    {
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public ePictureStatus status;

        public PictureStatus()
        {
            status = ePictureStatus.ePS_Waiting;
        }

        public void SetPictureStatus(ePictureStatus ePS)
        {
            this.status = ePS;
        }

        public string GetPictureStatusString()
        {
            return ePS_ToString(this.status);
        }

        public ePictureStatus GetPictureStatusEnum()
        {
            return this.status;
        }

        public static string ePS_ToString(ePictureStatus ePS)
        {
            string retVal = "";
            switch (ePS)
            {
                case ePictureStatus.ePS_Waiting:
                    retVal = "Waiting to be routed";
                    break;
                case ePictureStatus.ePS_Routed:
                    retVal = "Routed to be shot";
                    break;
                case ePictureStatus.ePS_Recieved:
                    retVal = "Recieved";
                    break;
                case ePictureStatus.ePS_SentForReshoot:
                    retVal = "Sent to be shot again";
                    break;
                default:
                    retVal = "well this shouldn't have happened";
                    break;
            }
            return retVal;
        }
    }
}
