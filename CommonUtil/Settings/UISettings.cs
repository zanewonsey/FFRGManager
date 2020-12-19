using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CommonUtil.Settings
{
    public class UISettings : ISettings<UISettings>
    {
        // Singleton
        private static UISettings settings;

        // The actual configuration resides in here
        private JObject JSONSettings;

        // User Interface Settings - URL/URI
        public string port
        {
            get { return JSONSettings.Value<string>(nameof(port)); }
            set
            {
                JSONSettings[nameof(port)] = value;
                WriteJSONFile();
            }
        }

        public string serviceURL
        {
            get { return JSONSettings.Value<string>(nameof(serviceURL)); }
            set
            {
                JSONSettings[nameof(serviceURL)] = value;
                WriteJSONFile();
            }
        }

        public string addOrderURI
        {
            get { return JSONSettings.Value<string>(nameof(addOrderURI)); }
            set
            {
                JSONSettings[nameof(addOrderURI)] = value;
                WriteJSONFile();
            }
        }

        // User Interface Settings - Form refresh rates
        public int orderListRefreshRate
        {
            get { return JSONSettings.Value<int>(nameof(orderListRefreshRate)); }
            set
            {
                JSONSettings[nameof(orderListRefreshRate)] = value;
                WriteJSONFile();
            }
        }

        // User Interface Settings - Settings File Location
        private string settingsFileLocation = ".\\UISettings.json";

        public string GetAddOrderURL
        {
            get { return "http://" + serviceURL + ":"+port+"/api/" + addOrderURI; }
        }

        public string GetOrderListURL
        {
            get { return "http://" + serviceURL + ":" + port + "/api/Orders/List"; }
        }

        public string GetDeleteOrderUrl
        {
            get { return "http://" + serviceURL + ":" + port + "/api/Orders/Delete"; }
        }

        public string GetUpdateOrderUrl
        {
            get { return "http://" + serviceURL + ":" + port + "/api/Orders/Update"; }
        }

        private UISettings()
        {
            if (!File.Exists(settingsFileLocation))
            {
                JSONSettings = new JObject();

                JSONSettings.Add(nameof(serviceURL), "localhost");
                JSONSettings.Add(nameof(port), "4555");
                JSONSettings.Add(nameof(addOrderURI), "Orders/Create/");
                JSONSettings.Add(nameof(orderListRefreshRate), 5000);

                WriteJSONFile();
            }
            else
            {
                JSONSettings = JObject.Parse(File.ReadAllText(settingsFileLocation));
            }
        }

        public static UISettings CreateSettings()
        {
            if (settings == null)
            {
                settings = new UISettings();
            }
            return settings;
        }

        private bool WriteJSONFile()
        {
            bool bResult = false;
            try
            {
                using (StreamWriter file = File.CreateText(settingsFileLocation))
                using (JsonTextWriter writer = new JsonTextWriter(file))
                {
                    writer.WriteRaw(JSONSettings.ToString());
                    writer.Flush();
                    writer.Close();
                }

                bResult = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return bResult;
        }

    }
}
