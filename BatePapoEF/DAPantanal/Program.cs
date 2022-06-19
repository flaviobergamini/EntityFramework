using DAPantanal.Data;
using DAPantanal.Model;
using Microsoft.EntityFrameworkCore;

namespace DAPantanal{
    class Program{
        public static void Main(string [] args){
            using(var context = new DataContext()){

                var animalCreate = new Animal {especie="Onça", alimentacao="carne", sexo='F'};
                context.Animais?.Add(animalCreate);
                context.SaveChanges(); 

                var animais = context.Animais?.AsNoTracking().ToList();

                foreach (Animal animal in animais){   //percorre de fato no SQL Server
                    Console.WriteLine(animal.especie);
                }
            }
        }
    }
}

// Instalando os pacotes
// dotnet add package Microsoft.EntityFrameworkCore
// dotnet add package Microsoft.EntityFrameworkCore.SqlServer