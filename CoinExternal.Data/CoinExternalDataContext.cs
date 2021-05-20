using Microsoft.EntityFrameworkCore;

namespace CoinExternal.Data
{
    public class CoinExternalDataContext : DbContext
    {
        public CoinExternalDataContext(DbContextOptions<CoinExternalDataContext> options) : base(options)
        {
        }
    }
}