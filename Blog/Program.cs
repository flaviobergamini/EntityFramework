using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog{
    public class Program{
        public static void Main(string[] args){

            // Realizando Crud no SQL Server com Ententi Framework.
            
            //DataContext é a representação do banco na memória
            using(var context = new BlogDataContext()){

                // Escrevendo novo registro no banco de dados, na tabela Tag
                /*
                var tag = new Tag {Name = "ASP.NET", Slug = "aspnet"};
                context.Tags.Add(tag);
                context.SaveChanges(); 
                
                var tag1 = new Tag {Name = ".NET", Slug = "dotnet"};
                context.Tags.Add(tag1);
                context.SaveChanges(); 
                */

                // Atualizando registo no banco de dados
                /*
                var tag = context.Tags.FirstOrDefault(x => x.id == 1);
                tag.Name = ".NET";
                tag.Slug = "dotnet";
                context.Tags.Update(tag);
                context.SaveChanges();
                */

                //Removendo registro no banco de dados
                /*
                var tag = context.Tags.FirstOrDefault(x => x.id == 1);
                context.Tags.Remove(tag);
                context.SaveChanges();
                */

                var tags = context.Tags?.AsNoTracking().ToList();  //Pega do banco em memória

                foreach (Tag tag in tags){   //percorre de fato no SQL Server
                    Console.WriteLine(tag.Name);
                }

                // Atualizando registo no banco de dados
                try{
                    var tagupdate = context.Tags?.FirstOrDefault(x => x.id == 2);
                    tagupdate.Name = "Ponto NET";
                    tagupdate.Slug = "aspnet";
                    context.Tags?.Update(tagupdate);
                    context.SaveChanges();
                }catch(Exception e){
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine("----------------");
                //Consultando no banco com condições
                var tags1 = context.Tags?.AsNoTracking().Where(x => x.Name.Contains("NET")).ToList();  //percorre no SQL Server somente com a condição
                
                foreach (Tag tag in tags1){
                    Console.WriteLine(tag.Name);
                }

                Console.WriteLine("----------------");
                var teagUnica = context.Tags?.AsNoTracking().Single(x => x.id == 4);
                Console.WriteLine(teagUnica?.Name);

                Console.WriteLine("----------------");
                var teagUnica1 = context.Tags?.AsNoTracking().First(x => x.id == 4);
                Console.WriteLine(teagUnica1?.Name);
            }
        }
    }
}