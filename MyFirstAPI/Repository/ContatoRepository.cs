using Microsoft.EntityFrameworkCore;
using MyFirstAPI.Context;
using MyFirstAPI.DTOs;
using MyFirstAPI.Interfaces;
using MyFirstAPI.models;

namespace MyFirstAPI.Repository
{
    public class ContatoRepository(AgendaContext context) : IContato 
    {

        private readonly AgendaContext _context = context;

        public async Task<ContatoModel> CreateContact(ContatoDto dto, CancellationToken token)
        {
            var contatoToCreate = (ContatoModel) _context.Contatos.Where(contatoDB => contatoDB.Nome.Contains(dto.Nome));

            if(contatoToCreate == null) throw new Exception("Contato already exists");

            await _context.AddAsync(contatoToCreate, token);
            await _context.SaveChangesAsync(token);

            // return CreatedAtAction(nameof(GetContatoById), new {id = contato.Id});
            return contatoToCreate;
        }

        public async Task<bool> DeleteContact(int id, CancellationToken token)
        {
            ContatoModel contatoById = await GetOneContact(id, token);

            if(contatoById == null) return false;

            contatoById.DesativarContact();
            return true; 
        }

        public async Task<List<ContatoModel>> GetAllContacts(CancellationToken token)
        {
            return await _context.Contatos.ToListAsync(token);
        }

        public async Task<ContatoModel> GetOneContact(int Id, CancellationToken token)
        {
            return await _context.Contatos.FirstOrDefaultAsync(contatoDB => contatoDB.Id == Id);
        }

        public async Task<ContatoModel> UpdateContact(int Id, ContatoDto dto, CancellationToken token)
        {
            ContatoModel contato = await GetOneContact(Id, token) ?? throw new Exception("Contact not found");

            contato.UpdateContact(dto.Nome, dto.Telefone, true); 

            _context.Contatos.Update(contato);

            _context.SaveChanges();           

            return contato;
        }
    }
}