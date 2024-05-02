using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyFirstAPI.Context;
using MyFirstAPI.DTOs;
using MyFirstAPI.models;
using MyFirstAPI.Repository;

namespace MyFirstAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController(ContatoRepository repository) : ControllerBase
    {
        private readonly ContatoRepository _repository = repository;


        [HttpGet]
        async public Task<ActionResult<List<ContatoModel>>> GetAllContacts(CancellationToken token){

            List<ContatoModel> contatos = await _repository.GetAllContacts(token);

            return Ok(contatos);
        }

        [HttpGet("{id:int}")]
        async public Task<ActionResult<ContatoModel>> GetOneContact(int id, CancellationToken token){

            ContatoModel contato = await _repository.GetOneContact(id, token);

            return Ok(contato);
        }

        [HttpPost]
        async public Task<ActionResult<ContatoModel>> CreateContact([FromBody] ContatoDto dto, CancellationToken token){

            ContatoModel contato = await _repository.CreateContact(dto, token);

            return Ok(contato);
        }

        [HttpPut("{id:int}")]
        async public Task<ActionResult<ContatoModel>> UpdateContact(int id, [FromBody] ContatoDto dto, CancellationToken token){
            ContatoModel contato = await _repository.UpdateContact(id, dto, token);

            return Ok(contato);
        }

        [HttpDelete("{id:int]}")]
        async public Task<ActionResult<bool>> DeleteContact(int id, CancellationToken token)
        {
            var deleted = await _repository.DeleteContact(id, token);

            return Ok(deleted);
        }

    }
}

// PUT => Informações completas
// PATCH => Informações imcompletas