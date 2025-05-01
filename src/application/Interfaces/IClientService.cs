using application.DTOs;
using domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.Interfaces
{
    public interface IClientService
    {
        Task<List<Client>> GetAllClients();
        Task<Client?> GetClientById(int id);
        Task<Client?> AddClient(AddClientRequest dto);
        Task UpdateClient(int id, AddClientRequest request);
        Task DeleteClient(Client client);
    }
}
