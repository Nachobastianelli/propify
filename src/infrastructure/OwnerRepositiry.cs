using domain.Entities;
using domain.Interfaces;

namespace infrastructure.Repositories
{
    public class OwnerRepository : IOwnerRepository
    {
        private static List<Owner> _owners = new List<Owner>();
        private static int _nextId = 1;

        public IEnumerable<Owner> GetAll() => _owners;

        public Owner GetById(int id) => _owners.FirstOrDefault(o => o.Id == id);

        public void Add(Owner owner)
        {
            owner.Id = _nextId++;
            _owners.Add(owner);
        }

        public void Update(Owner owner)
        {
            var existing = GetById(owner.Id);
            if (existing != null)
            {
                existing.Name = owner.Name;
                existing.Surname = owner.Surname;
                existing.Email = owner.Email;
                existing.Password = owner.Password;
                existing.NumberPhone = owner.NumberPhone;
                existing.DocumentType = owner.DocumentType;
                existing.Dni = owner.Dni;
                existing.PropertyId = owner.PropertyId;
                existing.Cvu = owner.Cvu;
            }
        }

        public void Delete(int id)
        {
            var owner = GetById(id);
            if (owner != null)
                _owners.Remove(owner);
        }
    }
}
