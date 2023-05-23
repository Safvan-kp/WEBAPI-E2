
using Microsoft.EntityFrameworkCore;
using WEBAPI_E2.Models;

namespace WEBAPI_E2.Data
{
    public class WEBAPI_E2DbContext : DbContext
    {
        public WEBAPI_E2DbContext(DbContextOptions options) : base(options)
        {


        }
        public DbSet<StockModel> Stocks { get; set; }
    }
}
