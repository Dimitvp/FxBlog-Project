using FxBlog.Services.Models;

namespace FxBlog.Web
{
    using System;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;
    using System.Collections.Generic;
    using System.Runtime.Serialization.Json;
    using Models;

    public class Program
    {
        private static readonly HttpClient client = new HttpClient();

        public static void Main(string[] args)
        {
            //ProcessRepositories().Wait();
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();

        //private static async Task ProcessRepositories()
        //{
        //    client.DefaultRequestHeaders.Accept.Clear();
        //    client.DefaultRequestHeaders.Accept.Add(
        //        new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
        //    client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

        //    var serializer = new DataContractJsonSerializer(typeof(List<ForexCurrencyServiceModel>));

        //    var streamTask = client.GetStreamAsync(WebConstants.ForexUrl);
        //    var repositories = serializer.ReadObject(await streamTask) as List<ForexCurrencyServiceModel>;

        //    foreach (var repo in repositories)
        //        Console.WriteLine(repo.Currency);
        //}
    }
}
