// Default URL for triggering event grid function in the local environment.
// http://localhost:7071/runtime/webhooks/EventGrid?functionName={functionname}
using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
//using Microsoft.Azure.EventGrid.Models;
using Microsoft.Azure.WebJobs.Extensions.EventGrid;
using Microsoft.Extensions.Logging;
using Azure.Messaging.EventGrid;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Demo.AzureFunction.EventGrid
{
    public class DemoAzureFunctionEventGrid
    {
        [FunctionName("DemoAzureFunctionEventGrid")]
        // public async Task Run([EventGridTrigger]EventGridEvent eventGridEvent,  ILogger log)
        //public async Task Run([EventGridTrigger] EventGridEvent eventGridEvent, [Blob("{data.url}", FileAccess.Read)] Stream inputBlob, ILogger log)
        public async Task EventGridTest([EventGridTrigger] JObject eventGridEvent, ILogger log)
        {
            log.LogInformation(eventGridEvent.ToString());
            await Task.Delay(500);
        }
    }
}
