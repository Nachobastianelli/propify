using domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Interfaces
{
    public interface IClientRepository
    {
        Task<List<Client>> GetAllClients();
        Task<Client> GetClientById(int id);
        Task<Client> AddClient(Client client);
        Task UpdateClient(Client client);
        Task DeleteClient(Client client);

    }
}
