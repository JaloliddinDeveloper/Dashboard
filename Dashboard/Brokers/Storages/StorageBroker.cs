using Dashboard.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Dashboard.Brokers.Storages
{
    public class StorageBroker:DbContext
    {
        private readonly IConfiguration configuration;

        public StorageBroker(IConfiguration configuration)
        {
            this.configuration = configuration;
            this.Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connection = this.configuration
                .GetConnectionString("DefaultConnection");

            optionsBuilder.UseSqlServer(connection);
        }

        public DbSet<BudgetData> BudgetDatas { get; set;}
        public DbSet<CurrencyRateData> CurrencyRateDatas { get; set;}
        public DbSet<DemographyData> DemographyDatas { get; set;}
        public DbSet<GdpData> GdpDatas { get; set;}
        public DbSet<InflationData> InflationDatas { get; set;}
        public DbSet<SectorData> SectorDatas { get; set;}
        public DbSet<TradeData> TradeDatas { get; set;}
        public DbSet<UnemploymentData> UnemploymentDatas { get; set;}
        public DbSet<DemographyGenderData> DemographyGenderDatas { get; set;}
    }
}
