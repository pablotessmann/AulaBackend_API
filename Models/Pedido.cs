namespace AulaBackend_API.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public object Cliente { get; internal set; }
        public object Produto { get; internal set; }
    }
}
