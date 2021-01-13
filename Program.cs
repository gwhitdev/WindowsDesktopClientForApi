using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Http;

using WindowsDesktopClientForApi.Services;
using WindowsDesktopClientForApi.Interfaces;

namespace WindowsDesktopClientForApi
{
    static class Program
    {
        public static IServiceProvider ServiceProvider { get; set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        private static void ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddHttpClient<IIngredientsService, IngredientsHttpService>(
                client =>
                {
                    client.BaseAddress = new Uri("https://familymealsapi.azurewebsites.net/api/");
                    client.DefaultRequestHeaders.Add("User-Agent", "WinFormTestApp");
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                });

            ServiceProvider = services.BuildServiceProvider();
        }
        
        [STAThread]
        static void Main()
        {
            
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigureServices();
            Application.Run(new Form1());
            
            
        }
    }
}
