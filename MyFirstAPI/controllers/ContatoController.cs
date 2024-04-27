using Microsoft.AspNetCore.Mvc;
using MyFirstAPI.Context;
using MyFirstAPI.models;

namespace MyFirstAPI.controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController(AgendaContext context) : ControllerBase
    {
        private readonly AgendaContext _context = context;

        [HttpPost]
        public IActionResult CreateContato(ContatoModel contato)
        {
            _context.Add(contato);
            _context.SaveChanges();

            return Ok(contato);
        }

        [HttpGet]
        public IActionResult GetAllContatos()
        {
            return Ok(_context.Contatos.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetContatoById(int id)
        {
            ContatoModel contatoById = _context.Contatos.Find(id);

            if(contatoById == null) return NotFound("Contato not found");

            return Ok(contatoById);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateContato(int id, ContatoModel contato)
        {
            ContatoModel contatoById = _context.Contatos.Find(id);

            if(contatoById == null) return NotFound("Contato not found");

            contatoById.Nome = contato.Nome;
            contatoById.Telefone = contato.Telefone;
            contatoById.Ativo = contato.Ativo;

            _context.Contatos.Update(contatoById);
            _context.SaveChanges();
            
            return Ok(contatoById);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteContato(int id)
        {
            ContatoModel contatoById = _context.Contatos.Find(id);
            
            if(contatoById == null) return NotFound("Contato not found");

            _context.Contatos.Remove(contatoById);
            _context.SaveChanges();

            return NoContent();
        }
    }
}