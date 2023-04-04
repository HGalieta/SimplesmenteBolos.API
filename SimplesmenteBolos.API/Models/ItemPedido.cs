using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SimplesmenteBolos.API.Models
{
    public class ItemPedido
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Tipo { get; set; } = string.Empty;
        [Required]
        public string Sabor { get; set; } = string.Empty;
        [Required]
        public int Tamanho { get; set; }
        [JsonIgnore]
        public virtual Pedido Pedido { get; set; } = new Pedido();
    }
}
