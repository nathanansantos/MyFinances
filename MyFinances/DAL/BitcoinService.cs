using MyFinances.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace MyFinances.DAL
{

    public class BitcoinService
    {
        public async Task<decimal> GetBitcoinPriceAsync()
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync("https://api.coingecko.com/api/v3/simple/price?ids=bitcoin&vs_currencies=usd");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<BitcoinPriceResponse>(json);
                    return result.Bitcoin.Usd;
                }
                return 0;
            }
        }
    }
}
