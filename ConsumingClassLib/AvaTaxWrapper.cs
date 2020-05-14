using System;
using Avalara.AvaTax.RestClient;

namespace ConsumingClassLib
{
    public class AvaTaxWrapper
    {
        private AvaTaxClient _client;
        public AvaTaxWrapper()
        {
            _client = new AvaTaxClient("AppName", "AppVersion", "MachineName", new AvaTaxEnvironment());
        }
    }
}
