using System.Net.Http;
using System.Threading.Tasks;
using CoinExternal.App.AppServices.IServices;

namespace CoinExternal.App.AppServices.Services
{
    public class ClientService : IClientService
    {
        public async Task<string> GetCoinByName(string coinName)
        {
            var URL = $"https://coinmarketcap.com/currencies/{coinName}";
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(URL);
            return await response.Content.ReadAsStringAsync();

        }

        public async Task<string> GetAllCoins()
        {
            var URL = $"https://coinmarketcap.com/currencies/";
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(URL);
            return await response.Content.ReadAsStringAsync();
        }
    }
}