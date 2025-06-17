using Microsoft.EntityFrameworkCore;

namespace CinemaCenter.Data
{
    public class CinemaCenterDbContext : DbContext
    {
        public CinemaCenterDbContext() : base()
        {
        }

        public CinemaCenterDbContext(DbContextOptions<CinemaCenterDbContext>options) : base(options)
        {
        }

        public DbSet<Actors> Actors { get; set; }
        public DbSet<ActorsFilms> ActorsFilms { get; set; }
        public DbSet<ProducersFilms> ProducersFilms { get; set; }
        public DbSet<Directors> Directors { get; set; }
        public DbSet<Films> Films { get; set; }
        public DbSet<Producers> Producers { get; set; }
        public DbSet<Studios> Studios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = STUDENT7; Integrated Security = " +
                "True; Initial Catalog=CinemaCenter2; Connect Timeout = 30; Encrypt = True; " +
                "Trust Server Certificate = True; Application Intent = ReadWrite; " +
                "Multi Subnet Failover = False");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
