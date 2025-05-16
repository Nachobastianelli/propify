using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Entities
{
    public class Property
    {
        public int Id { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]

        public float SquareMeters { get; set; }

        [Required]
        public int PricePerNight { get; set; }

        [Required]
        public int OwnerId { get; set; }
        [Required]
        public Owner Owner { get; set; }
        [Required]
        public int MaxTenants { get; set; } //maximo inquilinos
        //[Required]
        // Falta el uuid

        [Required]
        public string Description { get; set; }

        [Required]
        public PropertyState StateProperty { get; set; }

        public string Bathroom { get; set; }
        public string Room { get; set; }
        public string StreammingPlatform { get; set; }
        public string Pool {  get; set; }

        public Property() {}

        public Property(string type, float squareMeters, int pricePerNight, int ownerId, int maxTenants,  string description, PropertyState stateProperty, string bath, string room, string streammingPlatform, string pool )
        {
            Type = type;
            SquareMeters = squareMeters;
            PricePerNight = pricePerNight;
            OwnerId = ownerId;
            MaxTenants = maxTenants;
            Description = description;
            StateProperty = stateProperty;
            Bathroom = bath;
            Room = room;
            StreammingPlatform = streammingPlatform;
            Pool = pool;

        }
    }
}
