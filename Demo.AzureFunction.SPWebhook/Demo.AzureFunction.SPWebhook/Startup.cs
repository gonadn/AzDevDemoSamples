using Demo.AzureFunction.API;
using Demo.AzureFunction.SPWebhook;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text;

[assembly: FunctionsStartup(typeof(Startup))]
namespace Demo.AzureFunction.SPWebhook
{
    public class Startup : FunctionsStartup
    {
       // private static PnPCoreService pnpCoreService;
        public override void Configure(IFunctionsHostBuilder builder)
        {
            try 
            {
                IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("local.settings.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables()
                .Build();

                // var config = builder.GetContext().Configuration;

                var azureFunctionSettings = new AzureFunctionSettings();
                config.Bind(azureFunctionSettings);

                builder.Services.AddSingleton<IConfiguration>(config);

                //builder.Services.AddLogging();
                ////builder.Services.AddSingleton<IPnPContextFactory>();
                builder.Services.AddSingleton<IConfiguration>(config);
                //builder.Services.AddSingleton<IPnPCoreService, PnPCoreService>();

                //var test = builder.Services.BuildServiceProvider().GetService<IPnPCoreService>();
                //test.ConfigureWithCert(builder);

                //builder.Services.AddTransient<INewsService, NewsService>();

               // builder.Services.BuildServiceProvider().GetService<IPnPContextFactory>();

            }
            catch(Exception exp) 
            {
                Console.WriteLine(exp.Message);
            }

        }

        
    }
}
