using kirkas.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace kirkas.Infrastructure.Data
{
    public class KirkasContext : DbContext
    {
        public DbSet<DataType> DataTypes { get; set; }
        public DbSet<DataSeries> DataSeries { get; set; }
    }
}
