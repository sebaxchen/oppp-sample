namespace ACME.OOP.Shared.Domain.Model.ValueObjects;



public record Address
{
    public string Street { get; init; }
    public string Number { get; init; }
    public string City { get; init; }
    public string StateOrRegion { get; init; }
    public string PostalCode { get; init; }
    public string Country { get; init; }


    public Address(string street, string number, string city, string stateOrRegion, string postalCode, string country)
    {
        if (string.IsNullOrWhiteSpace(street))
            throw new ArgumentException("Street cannot be null or whitespace", nameof(street));
        if (string.IsNullOrWhiteSpace(Number))
            throw new ArgumentException("Number cannot be null or whitespace", nameof(number));
        if (string.IsNullOrWhiteSpace(City))
            throw new ArgumentException("City cannot be null or whitespace", nameof(city));
        if (string.IsNullOrWhiteSpace(StateOrRegion))
            throw new ArgumentException("StateOrRegion cannot be null or whitespace", nameof(StateOrRegion));
        if (string.IsNullOrWhiteSpace(PostalCode))
            throw new ArgumentException("PostalCode cannot be null or whitespace", nameof(PostalCode));
        if (string.IsNullOrWhiteSpace(Country))
            throw new ArgumentException("Country cannot be null or whitespace", nameof(Country));

        Street = street;
        Number = number;
        City = city;
        StateOrRegion = stateOrRegion;
        Country = country;
    }

    public override string Tostring()
    {
        => $"{Street} {Number}, {City}, {StateOrRegion}, {PostalCode}, {Country}";
    }
        
    
    
    
}