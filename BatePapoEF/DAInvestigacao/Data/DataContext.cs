using DAInvestigacao.Model;
using Microsoft.EntityFrameworkCore;

namespace DAInvestigacao.Data{
    public class DataContext:DbContext{
        public DbSet<Vilao>? Viloes { get; set; }
        public DbSet<Crime>? Crimes {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=localhost,1433;Database=Crimes;User ID=sa;Password=/MS-DOSV.6.22b");
            options.LogTo(Console.WriteLine); //Traz um log com as informações de operação no banco
        }
    }
}