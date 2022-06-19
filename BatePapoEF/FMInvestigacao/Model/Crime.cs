namespace FMInvestigacao.Model{
    class Crime{
        public int idCrime { get; set; }
        public DateTime? data { get; set; }
        public string? nome { get; set; }
        public string? local { get; set; }
        public int duracao { get; set; }
        public Vilao? Vilao { get; set; }
    }
}