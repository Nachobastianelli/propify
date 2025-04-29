using domain.Entities;

namespace application.Models.Request
{
    public class PropertyCreateRequest
    {
        public string Type { get; set; }

        public float SquareMeters { get; set; }
        
        public int PricePerNight { get; set; }
        
        public int OwnerId { get; set; }
        
        public Owner Owner { get; set; }
        
        public int MaxTenants { get; set; } //maximo inquilino

        public string Description { get; set; }

        public Enum StateProperty { get; set; }

        public string Bathroom { get; set; }
        public string Room { get; set; }
        public string StreammingPlatform { get; set; }
        public string Pool {  get; set; }

    }
}