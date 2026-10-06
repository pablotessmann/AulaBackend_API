namespace AulaBackend_API.Models
{
    public class Fruta
    {
        public int id { get; set; }
        public string nome { get; set; }
        public decimal? preco { get; set; }
        public int? quantidade { get; set; }
        public int id_categoria { get; set; }
        public DateTime? data_validade { get; set; }
        public string? hash_img { get; set; }

    }
}
