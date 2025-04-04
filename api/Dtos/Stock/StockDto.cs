using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Stock
{
    public class StockDto
    {
        public int Id { get; set; }

        
        
        public required string Symbol { get; set; }

        
        
        public required string CompanyName { get; set; }

        
        public decimal Purchase { get; set; }

        
        public decimal LastDiv { get; set; }

        
       
        public required string Industry { get; set; }

        
        public long MarketCap { get; set; }
    }
}