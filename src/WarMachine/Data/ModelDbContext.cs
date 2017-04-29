using WarMachine.Models;
using Microsoft.EntityFrameworkCore;
using WarMachine.Models.ManageViewModels;

namespace WarMachine.Data
{
    public class ModelDbContext : DbContext
    {
        public DbSet<UnitModel> Units { get; set; }
        public DbSet<Spell> Spells { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<Ability> Abilities { get; set; }
        public DbSet<SoloModel> Solos { get; set; }

        public ModelDbContext(DbContextOptions<ModelDbContext> options)
                : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ability>().HasKey(c => c.ID);
            modelBuilder.Entity<Spell>().HasKey(c => c.ID);
            modelBuilder.Entity<Weapon>().HasKey(c => c.ID);
            modelBuilder.Entity<UnitModel>().HasKey(c => c.ID);


            modelBuilder.Entity<UnitModel>().HasMany(s => s.Weapons);

           modelBuilder.Entity<UnitModel>().HasMany(s => s.Spells);
        
           modelBuilder.Entity<UnitModel>().HasMany(s => s.Abilities);



        }
    }
}
