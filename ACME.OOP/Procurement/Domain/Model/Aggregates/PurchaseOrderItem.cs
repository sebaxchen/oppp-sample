using ACME.OOP.Procurement.Domain.Model.valueObjects;
using ACME.OOP.Shared.Domain.Model.ValueObjects;

namespace ACME.OOP.Procurement.Domain.Model.Aggregates;

public class PurchaseOrderItem(ProductId productId, int quantity, Money unitprice)
{
    public ProductId roductoId { get; } = productId ?? throw new ArgumentNullException(nameof(productId));
    public int Quantity { get; } = quantity > 0 ? quantity : throw new ArgumentOutOfRangeException(nameof(unitprice));
    public Money UnitPrice { get; } = unitprice ?? throw new ArgumentNullException(nameof(unitprice));
    public Money CalculateTotal () => new Money(Quantity * UnitPrice.Amount, UnitPrice.Currency);
}