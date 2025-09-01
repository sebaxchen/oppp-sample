namespace ACME.OOP.SCM.Domain.Model.ValueObjects;


public record SupplierId
{
    public string Identifier { get; init; }
    
   
    public SupplierId(string identifier)
    {
        if (string.IsNullOrWhiteSpace(identifier))
            throw new ArgumentException("Supplier id cannot be null or whitespace.", nameof(identifier));
        Identifier = identifier;
    }
    
   
    public override string ToString() => Identifier;
}