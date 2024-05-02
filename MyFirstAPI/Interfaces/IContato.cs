using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyFirstAPI.DTOs;
using MyFirstAPI.models;

namespace MyFirstAPI.Interfaces
{
    public interface IContato
    {
        Task<ContatoModel> CreateContact(ContatoDto dto, CancellationToken token);
        Task<List<ContatoModel>> GetAllContacts(CancellationToken token);
        Task<ContatoModel> GetOneContact(int Id, CancellationToken token);
        Task<ContatoModel> UpdateContact(int Id, ContatoDto dto, CancellationToken token);
        Task<bool> DeleteContact(int Id, CancellationToken token);
    }
}