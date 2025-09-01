using ACME.OOP.Shared.Domain.Model.ValueObjects;

namespace ACME.OOP.SCM.Domain.Agregates;

public class Supplier(string identifier, string name, Address address)
{
    public string identifier { get; } = identifier ?? throw new ArgumentNullException(nameof(identifier));
    public string name { get; } = name ?? throw new ArgumentNullException(nameof(name));
    public Address address { get; } = address ?? throw new ArgumentNullException(nameof(address));
}
    

