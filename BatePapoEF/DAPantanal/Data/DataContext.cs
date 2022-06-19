using DAPantanal.Model;
using Microsoft.EntityFrameworkCore;

namespace DAPantanal.Data{

    // DataContext vai representar o banco na memória RAM.
    // A herança em DbContext garante as operações no SQL Server
    class DataContext:DbContext {
        public DbSet<Animal>? Animais { get; set;}
        public DbSet<Parque>? Parques { get; set;}
        //public DbSet<Pertence>? Pertencem { get; set;}  // por padrão, o EF não entende pk composta
        public DbSet<Planta>? Plantas { get; set;}
        public DbSet<Responsavel>? Responsaveis { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=Pantanal;User ID=sa;Password=/MS-DOSV.6.22b");
        }
    }
}