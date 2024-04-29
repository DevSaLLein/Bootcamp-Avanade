using Microsoft.AspNetCore.Mvc;
using MyFirstAPI.Context;
using MyFirstAPI.models;

namespace MyFirstAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController(AgendaContext context) : ControllerBase
    {
        private readonly AgendaContext _context = context;

        [HttpPost]
        public IActionResult CreateContato(ContatoModel contato)
        {
            ContatoModel contatoToCreate = _context.Contatos.Find(contato);

            if(contatoToCreate != null) return Conflict("Contato already exists");

            _context.Add(contatoToCreate);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetContatoById), new {id = contato.Id});
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

        [HttpGet("ObterPorNome/{nomeContato}")]
        public IActionResult GetContatoByNome(string nomeContato)
        {
            ContatoModel contatos = (ContatoModel) 
                _context.Contatos.Where(contato => contato.Nome.Contains(nomeContato))
            ;

            return Ok(contatos);
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

// PUT => Informações completas
// PATCH => Informações imcompletas