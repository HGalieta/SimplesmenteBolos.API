using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimplesmenteBolos.API.Models
{
    public class Pedido
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public Cliente Cliente { get; set; } = new Cliente();
        [Required]
        public List<ItemPedido> ItensPedido { get; set; } = new List<ItemPedido> { };

        public string ToMail(Pedido pedido)
        {
            return $"Olá, {pedido.Cliente.Nome}. Seu pedido está confirmado!\n\n" +
                $"{ListaItensPedido(pedido)}" +
                $"Agradeçemos por comprar conosco!";
        }

        public string ListaItensPedido(Pedido pedido)
        {
            string lista = "";
            foreach (ItemPedido item in pedido.ItensPedido)
            {
                lista += $"Bolo {item.Tipo} de {item.Sabor}, tamanho: {item.Tamanho} fatias.\n";
            }
            return lista;
        }
    }
}
