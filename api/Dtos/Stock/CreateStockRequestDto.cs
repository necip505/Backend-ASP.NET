using System;

namespace api.Dtos.Stock
{
    public class CreateStockRequestDto
    {
        public required string Symbol { get; set; }
        public required string CompanyName { get; set; }
        public decimal Purchase { get; set; }
        public decimal LastDiv { get; set; }
        public required string Industry { get; set; }
        public long MarketCap { get; set; }
    }
}
