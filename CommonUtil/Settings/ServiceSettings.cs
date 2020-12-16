using System;
using System.Collections.Generic;
using System.Text;

namespace CommonUtil.Settings
{
    class ServiceSettings : ISettings<ServiceSettings>
    {
        private static ServiceSettings settings;

        public ServiceSettings CreateSettings()
        {
            throw new NotImplementedException();
        }

        public void Load()
        {
            throw new NotImplementedException();
        }
    }
}
