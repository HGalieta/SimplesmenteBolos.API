using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SimplesmenteBolos.API.Data;
using SimplesmenteBolos.API.Models;

namespace SimplesmenteBolos.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemPedidoController : ControllerBase
    {
        private readonly DataContext _context;

        public ItemPedidoController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetItens()
        {
            List<ItemPedido> itens = _context.Itens.ToList();

            if (itens != null)
            {
                return Ok(itens);
            }

            return NoContent();
        }

        [HttpGet("{id}")]
        public IActionResult GetItemById(int id)
        {
            ItemPedido item = _context.Itens.FirstOrDefault(v => v.Id == id);

            if (item != null)
            {
                return Ok(item);
            }

            return NotFound();

        }

        [HttpPost]
        public IActionResult PostItemPedido(ItemPedido item)
        {
            _context.Itens.Add(item);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetItemById), new { Id = item.Id }, item);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteItem(int id)
        {
            ItemPedido item = _context.Itens.FirstOrDefault(v => v.Id == id);

            if (item != null)
            {
                _context.Itens.Remove(item);
                _context.SaveChanges();
                return Ok(item);
            }

            return NotFound();
        }
    }
}
