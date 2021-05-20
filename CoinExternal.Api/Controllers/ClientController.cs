using System.Threading.Tasks;
using CoinExternal.App.AppServices.IServices;
using Microsoft.AspNetCore.Mvc;
using Hangfire;

namespace CoinExternal.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }
        [Route("CoinExternal/{coin}")]
        [HttpGet]
        public async Task<IActionResult> GetCoinByName(string coin)
        {
            return Ok(await _clientService.GetCoinByName(coin));
        }
        
        [Route("CoinExternal/First100")]
        [HttpGet]
        public async Task<IActionResult> GetAllCoinsInfo()
        {
            RecurringJob.AddOrUpdate(() => GetAllCoinsInfo(),Cron.Hourly);
            return Ok(await _clientService.GetAllCoins());
        }
        
        
    }
}