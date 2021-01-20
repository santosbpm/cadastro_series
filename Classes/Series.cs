namespace cadastro_series
{
    public class Series : EntidadeBase 
    {
        // Atributos
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }

        // Métodos
        public Series(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.ID = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
        }
    }
}