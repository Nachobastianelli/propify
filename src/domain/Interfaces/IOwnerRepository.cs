using domain.Entities;

namespace domain.Interfaces
{
    public interface IOwnerRepository
    {
        IEnumerable<Owner> GetAll();
        Owner GetById(int id);
        void Add(Owner owner);
        void Update(Owner owner);
        void Delete(int id);
    }
}
