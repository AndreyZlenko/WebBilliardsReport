using BilliardsReport.Domain.Models;
using System.Data.Entity;

namespace BilliardsReport.Domain.Context
{
    public class HallContextEntity : DbContext
    {
        public DbSet<GameHall> GameHalls { get; set; }
        public DbSet<HallOwner> HallOwners { get; set; }
        public DbSet<HallStatistics> HallStatistics { get; set; }
        public DbSet<DiscountCard> DiscountCards { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<TableStatistics> TableStatistics { get; set; }
        public DbSet<TableCategory> TableCategories { get; set; }
        public DbSet<GameTariff> GameTariffs { get; set; }

        public HallContextEntity(string connectionString):base(connectionString)
        { }
    }
}
