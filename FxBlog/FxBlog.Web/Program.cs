namespace FxBlog.Web
{
    using Autofac.Extensions.DependencyInjection;
    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;
    using System.IO;
    using System.Net.Http;

    public class Program
    {
        //private static readonly HttpClient client = new HttpClient();

        public static void Main(string[] args)
        {
            //ProcessRepositories().Wait();
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseKestrel()
                .ConfigureServices(services => services.AddAutofac())
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
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
