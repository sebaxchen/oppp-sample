namespace ACME.OOP.Procurement.Domain.Model.valueObjects;

public record ProductId
{
    public Guid  Id{ get; init; }
    
   
    public ProductId(Guid id)
    {
        if (id == Guid.Empty)
            throw new ArgumentException("Product id cannot be empty UUID.", nameof(id));
        Id = id;
    }
    
   public static  ProductId New() => new (Guid.NewGuid());
    public override string ToString() => Id .ToString();
}



