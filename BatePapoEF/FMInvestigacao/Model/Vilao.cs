namespace FMInvestigacao.Model{
    class Vilao{
        public int idVilao { get; set; }
        public string? nome { get; set; }
        public int numCrime { get; set; }

        public IList<Crime>? Crimes {get; set;}

    }
}