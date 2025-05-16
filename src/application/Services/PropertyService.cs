using domain.Entities;

public class PropertyService : IPropertyService
{
    private readonly IPropertyRepository _repository;

    public PropertyService(IPropertyRepository repository)
    {
        _repository = repository;
    }

    public List<PropertyDto> GetAll()
    {
        var list = _repository.GetAll();
        return PropertyDto.CreateList(list);
    }

    public PropertyDto GetById(int id)
    {
        var list = _repository.GetById(id);

        if (list == null)
        {
            throw new Exception("Propiedad no encontrada");

        }
        return PropertyDto.Create(list);

    }

    public void Create(PropertyCreateRequest request)
    {
        var newProperty = new Property(request.Type, request.SquareMeters, request.PricePerNight, request.OwnerId, /*request.Owner*/ request.MaxTenants, request.Description, request.StateProperty, request.Bathroom, request.Room, request.StreammingPlatform, request.Pool);
        _repository.Create(newProperty);
    }

    public void Update(int id, PropertyUpdateRequest request)
    {
        var property = _repository.GetById(id);
        if (property == null)
        {
            throw new Exception("Propiedad no encontrada");
        }

        property.Type = request.Type;
        property.SquareMeters = request.SquareMeters;
        property.PricePerNight = request.PricePerNight;
        property.OwnerId = request.OwnerId;
        property.Owner = request.Owner;
        property.MaxTenants = request.MaxTenants;
        property.Description = request.Description;
        property.StateProperty = request.StateProperty;
        property.Bathroom = request.Bathroom;
        property.Room = request.Room;
        property.StreammingPlatform = request.StreammingPlatform;
        property.Pool = request.Pool;

        _repository.Update(property);
    }

    public void Delete(int id)
    {
        var property = _repository.GetById(id);
        if (property == null)
        {
            throw new Exception("Propiedad no encontrada");
        }
        _repository.Delete(property);
    }
}