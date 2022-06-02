using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog{
    class Program{
        public static void Main(string [] args){
            
            using var context = new BlogDataContext();

            /*
            var user = new User{
                Name = "Flávio H. M. Bergamini",
                Slug = "flaviohmbergamini",
                Email = "flavio@hotmail.com",
                Bio = "Estudande de Engenharia",
                Image = "https://flavio.com",
                PasswordHash = "1234567890" 
            };

            var category = new Category{
                Name = "Backend",
                Slug = "backend"
            };

            var post = new Post{
                Author = user,
                Category = category,
                Body = "<p>Hello world</p>",
                Slug = "começando com ef-core",
                Summary = "Nesse artigo vsmos aprender EF Core",
                Title = "Começando com EF Core",
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now
            };

            context.Add(post);
            context.SaveChanges();

            */

            var posts = context.Posts?.AsNoTracking().OrderByDescending(x => x.LastUpdateDate).ToList();

            foreach(Post post in posts){
                Console.WriteLine(post.Title);
            }

            Console.WriteLine("----------------");
            var posts1 = context.Posts?.AsNoTracking().Include(x=>x.Author).Where(x=>x.AuthorId == 3).OrderByDescending(x => x.LastUpdateDate).ToList();

            foreach(Post post in posts1){
                Console.WriteLine($"{post.Title}, escrito por {post.Author?.Name}");
            }

            //Select com JOIN

            Console.WriteLine("----------------");
            var posts2 = context.Posts?
            .AsNoTracking()
            .Include(x=>x.Author)
            .Include(x=>x.Category)
            .Where(x=>x.AuthorId == 3)
            .OrderByDescending(x => x.LastUpdateDate)
            .ToList();

            foreach(Post post in posts2){
                Console.WriteLine($"{post.Title}, escrito por {post.Author?.Name} para {post.Category?.Name}");
            }

            // update
            var post3 = context.Posts?
            .Include(x=>x.Author)
            .Include(x=>x.Category)
            .OrderByDescending(x=>x.LastUpdateDate)
            .FirstOrDefault();

            post3.Author.Name = "Teste";

            context.Update(post3);
            context.SaveChanges();

            var post4 = context.Posts?
            .Include(x=>x.Author)
            .Include(x=>x.Category)
            .OrderByDescending(x=>x.LastUpdateDate)
            .FirstOrDefault();

            post3.Author.Name = "Flávio Henrique Madureira Bergamini";

            context.Update(post4);
            context.SaveChanges();

        }
    }
}