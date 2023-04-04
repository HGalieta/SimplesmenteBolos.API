using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SimplesmenteBolos.API.Models
{
    public class Pedido
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public List<ItemPedido> ItensPedido { get; set; } = new List<ItemPedido>();
    }
}
