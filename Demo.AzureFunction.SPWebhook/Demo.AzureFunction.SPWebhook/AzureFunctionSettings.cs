using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Demo.AzureFunction.API
{
    class AzureFunctionSettings
    {
        public string DemoSiteUrl { get; set; }
        public string TenantId { get; set; }
        public string ClientId { get; set; }
        public string SecretKey { get; set; }
        // public string ClientSecret { get; set; }
        public string CertificateThumbPrint { get; set; }
    }
}
