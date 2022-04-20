using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Net.Http;

namespace Demo.AzureFunction.SPWebhook
{
    public static class DocumentsWebHook
    {
        [FunctionName("SPDocumentsWebHook")]
        public static async Task<IActionResult> Run(HttpRequestMessage req, ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            

            return new OkObjectResult("");
        }
    }
}
