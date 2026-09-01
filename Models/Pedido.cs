namespace AulaBackend_API.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public Produto Produto { get; set; }
        public string Quantidade { get; set; }
        public DateTime? DataPedido { get; set; }
        public int ClienteId { get; set; }
    }
}
