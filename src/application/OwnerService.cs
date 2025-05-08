using application.Interfaces;
using domain.Entities;
using domain.Interfaces;

namespace application.Services
{
    public class OwnerService : IOwnerService
    {
        private readonly IOwnerRepository _repository;

        public OwnerService(IOwnerRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Owner> GetAll() => 
        _repository.GetAll();

        public Owner GetById(int id) => 
        
        _repository.GetById(id);

        public void Add(Owner owner) => 
        
        _repository.Add(owner);

        public void Update(Owner owner) => 
        
        _repository.Update(owner);

        public void Delete(int id) => 
        
        _repository.Delete(id);
    }
}
