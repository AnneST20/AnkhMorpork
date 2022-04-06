using System.Data.Entity;

namespace AnkhMorpork.Models
{
    public class GuildsContext : DbContext 
    {
        public GuildsContext() : base(@"AnkhMorpork.Properties.Settings.GuildsDBConnectionString") { }
        public DbSet<Assassin> Assassins { get; set; }
        public DbSet<Beggar> Beggars { get; set; }
        public DbSet<Fool> Fools { get; set; }
        public DbSet<Thief> Thieves { get; set; }
    }
}
