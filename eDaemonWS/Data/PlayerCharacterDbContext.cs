using eDaemonWS.Data.Map;
using eDaemonWS.Model.Characters;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace eDaemonWS.Data
{
    public class PlayerCharacterDbContext : DbContext
    {
        public PlayerCharacterDbContext(DbContextOptions<PlayerCharacterDbContext> options) : base(options) { }

        public DbSet<PlayerCharacter> PlayerCharacters { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PlayerCharacterMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
