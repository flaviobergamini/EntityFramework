using FMInvestigacao.Data.Mappings;
using FMInvestigacao.Model;
using Microsoft.EntityFrameworkCore;

namespace FMInvestigacao.Data{

    class DataContext:DbContext{
        public DbSet<Vilao>? Viloes {get; set;}
        public DbSet<Crime>? Crimes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=localhost,1433;Database=Crimes;User ID=sa;Password=/MS-DOSV.6.22b");
            //options.LogTo(Console.WriteLine);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.ApplyConfiguration(new VilaoMap());
            modelBuilder.ApplyConfiguration(new CrimeMap());
        }
        
    }
}