namespace ACME.OOP.Shared.Domain.Model.ValueObjects;


public record Money
{
    public decimal Amount { get; init; }
    public string Currency { get; init; }

   
    public Money(decimal amount, string currency)
    {
        if (string.IsNullOrWhiteSpace(currency) || currency.Length != 3)
            throw new ArgumentException("Currency must be a valid 3-letter ISO code.", nameof(currency));
        if (amount < 0)
            throw new ArgumentException("Amount must be a non-negative number.", nameof(amount));
    }
    
   
    public override string ToString() => $"{Amount} {Currency}";
}