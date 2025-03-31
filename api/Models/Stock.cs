using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models
{
    public class Stock
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public required string Symbol { get; set; }

        [Required]
        [StringLength(100)]
        public required string CompanyName { get; set; }

        [Required]
        public decimal Purchase { get; set; }

        [Required]
        public decimal LastDiv { get; set; }

        [Required]
        [StringLength(10)]
        public required string Industry { get; set; }

        [Required]
        public long MarketCap { get; set; }

        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}

