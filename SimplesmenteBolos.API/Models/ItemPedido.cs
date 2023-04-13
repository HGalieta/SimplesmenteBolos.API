namespace SimplesmenteBolos.API.Models
{
    public class ItemPedido
    {
        public int Id { get; set; }
        public string Tipo { get; set; } = string.Empty;
        public string Sabor { get; set; } = string.Empty;
        public string Tamanho { get; set; } = string.Empty;
    }
}
