using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog{
    class Program{
        public static void Main(string [] args){
            
           
            var context = new BlogDataContext();

           
            context.Users?.Add(new User{
                Bio = "Eng de Computação",
                Email = "flavio@hotmail.com",
                Image = "http://flavio.com",
                Name = "Flávio Henrique Madureira Bergamini",
                PasswordHash = "12345678",
                Slug = "flavio-bergamini"
            });
            context.SaveChanges(); 
            
            
            var user = context.Users?.FirstOrDefault();

            var post = new Post{
                Author = user,
                Body = "Meu projeto",
                Category = new Category{
                    Name = "Backend EF",
                    Slug = "backend-ef"
                },
                CreateDate = System.DateTime.Now,
                Slug="meu-projeto",
                Summary = "Meu projeto de Entity Framework",
                Title = "Projetinho"
            };

            context.Posts?.Add(post);
            context.SaveChanges();
            
            /*
            Faça a instalação do seguinte pacote: 
            > dotnet add package Microsoft.EntityFrameworkCore.Design

            Para fazer a migração do banco, é preciso instalar o dotnet-ef pelo comando:
            > dotnet tool install --global dotnet-ef

            Após a instalação, e build do projeto, escreva no terminal:
            > dotnet ef migrations add nome_da_migracao

            Após fazer a migração no comando anterior, vamos agora aplicar essas migrações no banco
            > dotnet ef database update

            -Para remover uma migração e que inclusive já foi enviada para o banco, use:
            > dotnet ef migrations remove
            > dotnet ef database update

            -Para gerar o script SQL do banco, use o comando:
            > dotnet ef migrations script -o ./script.sql

            */
        }
    }
}