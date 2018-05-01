namespace FxBlog.Services
{
    using Models;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class ForexServices : IForexServices
    {
        static HttpClient client = new HttpClient();

        public async Task<IEnumerable<ForexCurrencyServiceModel>> GetAsync()
        {
            //ForexCurrencyServiceModel forex = null;
            //var serializer = new DataContractJsonSerializer(typeof(List<ForexCurrencyServiceModel>));
            //var currences = new List<ForexCurrencyServiceModel>();
            HttpResponseMessage response = await client.GetAsync(ServiceConstants.ForexUrl);

            //if (response.IsSuccessStatusCode)
            //{                             
            //    forex = await response.Content.ReadAsAsync<ForexCurrencyServiceModel>();
            //    currences.Add(forex);
            //}

            var jsonString = await response.Content.ReadAsStringAsync();
            var objData = JsonConvert.DeserializeObject<List<ForexCurrencyServiceModel>>(jsonString);
            return objData;
        }
    }
}
