using System;
using System.ComponentModel.DataAnnotations;

namespace api.Dtos.Stock
{
    public class CreateStockRequestDto
    {
        [Required]
        [MaxLength(10, ErrorMessage = "Symbol must be less than 10 characters")]
        public required string Symbol { get; set; }
        [Required]
        [MaxLength(10, ErrorMessage = "CompanyName must be less than 10 characters")]
        public required string CompanyName { get; set; }
        [Required]
        [Range(1,1000000000)]
        public decimal Purchase { get; set; }
        [Required]
        [Range(0.001,100)]
        public decimal LastDiv { get; set; }
        [Required]
        [MaxLength(10, ErrorMessage = "Industry must be less than 10 characters")]
        public required string Industry { get; set; }
        [Required]
        [Range(1, 500000000)]
        public long MarketCap { get; set; }
    }
}
