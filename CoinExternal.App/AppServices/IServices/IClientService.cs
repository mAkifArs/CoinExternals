using System.Threading.Tasks;

namespace CoinExternal.App.AppServices.IServices
{
    public interface IClientService
    {
        Task<string> GetCoinByName(string coinName);
        Task<string> GetAllCoins();
    }
}