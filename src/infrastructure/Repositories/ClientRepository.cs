using domain.Entities;
using domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.Repositories
{
    public class ClientRepository : IClientRepository //esto es un mockup de lo que mas adelante será la implementación a la base de datos, en proceso
    {
        public async Task<List<Client>> GetAllClients()
        {
            return null;
        }
        public Task<Client> GetClientById(int id)
        {
            return null;
        }
        public async Task<Client> AddClient(Client client)
        {
            return null;
        }
        public Task UpdateClient(Client client)
        {
            return null;
        }
        public Task DeleteClient(Client client)
        {
            return null;
        }
    }
}
