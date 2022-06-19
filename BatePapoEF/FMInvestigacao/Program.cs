using FMInvestigacao.Data;
using FMInvestigacao.Model;

namespace FMInvestigacao{
    class Program{
        public static void Main(string [] args){
            
            var context = new DataContext();

            var vilao = new Vilao{
                nome = "Thanos",
                numCrime = 23
            };
            context.Viloes?.Add(vilao);
            context.SaveChanges();

            var viloes = context.Viloes?.FirstOrDefault();

            var crime = new Crime{
                nome = "Equilíbrio",
                duracao = 3,
                data = System.DateTime.Now,
                local = "Universo",
                Vilao = vilao
            };
            context.Crimes?.Add(crime);
            context.SaveChanges();
        }
    }
}