using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Shertech001.EntityFrameworkCore
{
    public static class Shertech001DbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<Shertech001DbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<Shertech001DbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
