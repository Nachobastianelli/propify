using domain.Entities;

namespace application.Models
{
    public class PropertyDto
    {
        public int Id {get;set;}
        public string Type { get; set; }

        public float SquareMeters { get; set; }

        public int PricePerNight { get; set; }

        public int OwnerId { get; set; }
        
        public Owner Owner { get; set; }
        
        public int MaxTenants { get; set; } //maximo inquilinos
        //[Required]
        // Falta el uuid

        public string Description { get; set; }

        public Enum StateProperty { get; set; }

        public string Bathroom { get; set; }
        public string Room { get; set; }
        public string StreammingPlatform { get; set; }
        public string Pool {  get; set; }


        public static PropertyDto Create(Property property)
        {
            return new PropertyDto
            {
                Id = property.Id,
                Type = property.Type,
                SquareMeters = property.SquareMeters,
                PricePerNight = property.PricePerNight,
                OwnerId = property.OwnerId,
                MaxTenants = property.MaxTenants,
                Description = property.Description,
                StateProperty = property.StateProperty,
                Bathroom = property.Bathroom,
                Room = property.Room,
                StreammingPlatform = property.StreammingPlatform,
                Pool = property.Pool,
            };
        }

        public static List<PropertyDto> CreateList(IEnumerable<Property> properties)
        {
            if (properties == null || !properties.Any())
            {
                return null;
            }

            return properties.Select(p => new PropertyDto
            {
                Id = p.Id,
                Type = p.Type,
                SquareMeters = p.SquareMeters,
                PricePerNight = p.PricePerNight,
                OwnerId = p.OwnerId,
                MaxTenants = p.MaxTenants,
                Description = p.Description,
                StateProperty = p.StateProperty,
                Bathroom = p.Bathroom,
                Room = p.Room,
                StreammingPlatform = p.StreammingPlatform,
                Pool = p.Pool,
            }).ToList();
        }

    }
}