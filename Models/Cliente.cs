namespace AulaBackend_API.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public int Cpf { get; set; }
        public string Endereco { get; set; }
        public string Cidade  { get; set; }
        public string Estado { get; set; }
    }
}
