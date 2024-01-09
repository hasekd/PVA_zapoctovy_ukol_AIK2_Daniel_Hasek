using Microsoft.EntityFrameworkCore;
using PVA_zapoctovy_ukol_AIK2_Daniel_Hašek.Models;

namespace PVA_zapoctovy_ukol_AIK2_Daniel_Hašek.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Credit> Credits { get; set; }
    }
}
