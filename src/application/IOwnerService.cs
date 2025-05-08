using domain.Entities;

namespace application.Interfaces
{
    public interface IOwnerService
    {
        IEnumerable<Owner> GetAll();
        Owner GetById(int id);
        void Add(Owner owner);
        void Update(Owner owner);
        void Delete(int id);
    }
}
