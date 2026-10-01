namespace AulaBackend_API.Models
{
    public class Fruta
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal? Preco { get; set; }
        public int? Quantidade { get; set; }
        public string Categoria { get; set; }
        public DateTime? DataValidade { get; set; }
        public string? HashImg { get; set; }

    }
}
