using System.ComponentModel.DataAnnotations.Schema;
using System;
using api.Models;

namespace api.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; }=DateTime.Now;
        public int? StockId { get; set; }
        public Stock? Stock { get; set; }
    }
}
