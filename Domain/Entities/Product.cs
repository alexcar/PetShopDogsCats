namespace Domain.Entities
{
    public class Product : BaseEntity
    {
        public Product(string? code, string? name, string? description, decimal? costValue, int? profitMargin, decimal? saleValue, int stockQuantity)
        {
            Code = code;
            Name = name;
            Description = description;
            CostValue = costValue;
            ProfitMargin = profitMargin;
            SaleValue = saleValue;
            StockQuantity = stockQuantity;
        }

        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; } = null;
        public decimal? CostValue { get; set; }
        public int? ProfitMargin { get; set; }
        public decimal? SaleValue { get; set; }
        public int StockQuantity { get; set; }
    }
}
