using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SimplesmenteBolos.API.Data;
using SimplesmenteBolos.API.Models;

namespace SimplesmenteBolos.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BoloController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public BoloController(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult GetBolos()
        {
            List<Bolo> bolos = _context.Bolos.ToList();

            if (bolos != null)
            {
                return Ok(bolos);
            }

            return NoContent();
        }
        [HttpGet("{id}")]
        public IActionResult GetBoloById(int id)
        {
            Bolo bolo = _context.Bolos.FirstOrDefault(v => v.Id == id);

            if (bolo != null)
            {
                return Ok(bolo);
            }

            return NotFound();

        }

        [HttpPost]
        public IActionResult PostBolo(Bolo bolo)
        {
            _context.Bolos.Add(bolo);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetBoloById), new { Id = bolo.Id }, bolo);
        }

        [HttpPut("{id}")]
        public IActionResult PutBolo(int id, [FromBody] BoloUpdate novoBolo)
        {
            Bolo bolo = _context.Bolos.FirstOrDefault(v => v.Id == id);

            if (GetBolos != null)
            {
                _mapper.Map(novoBolo, bolo);
                _context.SaveChanges();
                return NoContent();
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBolo(int id)
        {
            Bolo bolo = _context.Bolos.FirstOrDefault(v => v.Id == id);

            if (bolo != null)
            {
                _context.Bolos.Remove(bolo);
                _context.SaveChanges();
                return Ok(bolo);
            }

            return NotFound();
        }
    }
}
