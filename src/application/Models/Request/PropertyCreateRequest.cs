using domain.Entities;

public class PropertyCreateRequest
{
    public string Type { get; set; }

    public float SquareMeters { get; set; }


    public int PricePerNight { get; set; }


    public int OwnerId { get; set; }

    public Owner Owner { get; set; }

    public int MaxTenants { get; set; }

    public string Description { get; set; }
    public PropertyState StateProperty { get; set; }

    public string Bathroom { get; set; }
    public string Room { get; set; }
    public string StreammingPlatform { get; set; }
    public string Pool { get; set; }
}