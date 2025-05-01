using application.DTOs;
using application.Interfaces;
using domain.Entities;
using domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;
        
        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        public async Task<List<Client>> GetAllClients()
        {
            return await _clientRepository.GetAllClients();
        }
        public async Task<Client?> GetClientById(int id)
        {
            return await _clientRepository.GetClientById(id);
        }
        public async Task<Client?> AddClient(AddClientRequest dto)
        {
            var existingClient = await _clientRepository.GetAllClients();
            if (existingClient.Any(c => c.Email == dto.Email))
            {
                return null;
            }

            var client = new Client
            {
                Name = dto.Name,
                Surname = dto.Surname,
                Email = dto.Email,
                Password = dto.Password, //hashear
                NumberPhone = dto.NumberPhone,
                DocumentType = dto.DocumentType,
                Dni = dto.Dni
            };

            return await _clientRepository.AddClient(client);
        }
        public async Task UpdateClient(int id, AddClientRequest request)
        {

        }
        public async Task DeleteClient(Client client)
        {

        }
    }
}
