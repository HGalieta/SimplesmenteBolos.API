using Microsoft.AspNetCore.Mvc;
using SimplesmenteBolos.API.Data;
using SimplesmenteBolos.API.Models;

namespace SimplesmenteBolos.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PedidoController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IEmailService _emailService;

        public PedidoController(DataContext context, IEmailService emailService)
        {
            _context = context;
            _emailService = emailService;
        }
        [HttpGet]
        public IActionResult GetPedidos()
        {
            List<Pedido> pedidos = _context.Pedidos.ToList();

            if (pedidos != null)
            {
                return Ok(pedidos);
            }

            return NoContent();
        }

        [HttpGet("{id}")]
        public IActionResult GetPedidoById(int id)
        {
            Pedido pedido = _context.Pedidos.FirstOrDefault(p => p.Id == id);

            if (pedido != null)
            {
                return Ok(pedido);
            }

            return NotFound();
        }

        [HttpPost]
        public IActionResult PostPedido(Pedido pedido)
        {
            _context.Pedidos.Add(pedido);
            _context.SaveChanges();
            _emailService.SendEmail(pedido);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePedido(int id)
        {
            Pedido pedido = _context.Pedidos.FirstOrDefault(p => p.Id == id);

            if (pedido != null)
            {
                _context.Pedidos.Remove(pedido);
                _context.SaveChanges();
                return Ok(pedido);
            }

            return NotFound();
        }
    }
}
