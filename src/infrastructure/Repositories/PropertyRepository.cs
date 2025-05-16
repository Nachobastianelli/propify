using domain.Entities;
using infrastructure.Repositories;

namespace Infrastructure.Repositories;

public class PropertyRepository : BaseRepository<Property>, IPropertyRepository
{
    public PropertyRepository(ApplicationContext context) : base(context)
    {
    }
}