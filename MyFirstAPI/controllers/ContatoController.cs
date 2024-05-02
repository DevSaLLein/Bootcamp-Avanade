using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyFirstAPI.Context;
using MyFirstAPI.DTOs;
using MyFirstAPI.models;

namespace MyFirstAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController(AgendaContext context) : ControllerBase
    {
        private readonly AgendaContext _context = context;

        [HttpPost]
        public IActionResult CreateContato(ContatoModel contato, CancellationToken token)
        {
            bool contatoToCreate = _context.Contatos.Any(contatoDB => contatoDB.Nome == contato.Nome);

            if(contatoToCreate == true) return Conflict("Contato already exists");

            _context.Add(contatoToCreate);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetContatoById), new {id = contato.Id});
        }

        [HttpGet]
        public IActionResult GetAllContatos(CancellationToken token)
        {
            var contatos = 
                _context.Contatos
                    .Select(contatoDB => new ContatoDto(contatoDB.Id, contatoDB.Nome, contatoDB.Telefone))
                    .AsNoTracking()
                    .ToList()
                ;
            ;

            return Ok(contatos);
        }

        [HttpGet("{id}")]
        public IActionResult GetContatoById(int id)
        {
            ContatoModel contatoById = _context.Contatos.Find(id);

            if(contatoById == null) return NotFound("Contato not found");

            ContatoDto contatoDto = new ContatoDto(contatoById.Id, contatoById.Nome, contatoById.Telefone);

            return Ok(contatoDto);
        }

        [HttpGet("ObterPorNome/{nomeContato}")]
        public IActionResult GetContatoByNome(string nomeContato, CancellationToken token)
        {
            ContatoModel contatos = (ContatoModel) 
                _context.Contatos
                    .Where(contatoDB => contatoDB.Nome.Contains(nomeContato))
                    .Select(contato => new ContatoDto(contato.Id, contato.Nome, contato.Telefone))
                    .AsNoTracking()
                ;
            ;

            return Ok(contatos);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateContato(int id, ContatoModel contato, CancellationToken token)
        {
            ContatoModel contatoById = _context.Contatos.Find(id);

            if(contatoById == null) return NotFound("Contato not found");

            contatoById.UpdateContact(contato.Nome, contato.Telefone, contato.Ativo);

            _context.Contatos.Update(contatoById);
            _context.SaveChanges();

            ContatoDto contatoDto = new ContatoDto(contatoById.Id, contatoById.Nome, contatoById.Telefone);
            
            return Ok(contatoDto);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteContato(int id, CancellationToken token)
        {
            ContatoModel contatoById = _context.Contatos.Find(id);
            
            if(contatoById == null) return NotFound("Contato not found");

            contatoById.DesativarContact();
            _context.SaveChanges();

            return NoContent();
        }
    }
}

// PUT => Informações completas
// PATCH => Informações imcompletas