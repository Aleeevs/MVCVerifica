using Microsoft.EntityFrameworkCore;
using MVCVerifica.Models;

namespace MVCVerifica.Data {
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options) {

        public DbSet<Spettacolo> Spettacoli { get; set; }

    }
}
