using DAInvestigacao.Data;
using DAInvestigacao.Model;

namespace DAInvestigacao{
    class Program{
        public static void Main(string [] args){

            using var context = new DataContext();

            var vilao = new Vilao{
                nome = "Thanos",
                numCrime = 23
            };

            context.Viloes?.Add(vilao);
            context.SaveChanges();

            var crime = new Crime{
                nome = "Extinção em Massa",
                duracao = 1,
                data = System.DateTime.Now,
                local = "Terra",
                Vilao = vilao
            };
            context.Crimes?.Add(crime);
            context.SaveChanges();
        }
    }
}