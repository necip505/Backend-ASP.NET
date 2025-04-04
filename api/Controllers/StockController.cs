using Microsoft.AspNetCore.Mvc; // for ControllerBase
using api.Models; // for Stock
using System.Collections.Generic; // for List
using System.Linq; // for ToList
using api.Data; // for ApplicationDBContext
using Microsoft.EntityFrameworkCore; // for DbContext and DbSet
using System.Threading.Tasks; // for Task
using api.Dtos.Stock; // for StockDto
using api.Mappers; // for StockMappers


namespace api.Controllers
{
    [Route("api/stock")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public StockController(ApplicationDBContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetStocks()
        {
            var stocks = _context.Stock.ToList().Select(s => s.ToStockDto());
            
            return Ok(stocks);
        }
        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var stock = _context.Stock.Find(id);
            if (stock == null)
            {
                return NotFound();
            }
            return Ok(stock.ToStockDto());
        }
    }
}