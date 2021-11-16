using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockMarket.Admin.Entities
{
    [Table("StockExchange")]
    public class StockExchange
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string StockExchangeName { get; set; }
        [Required]
        public string Brief { get; set; }
        [Required]
        public string ContactAddress { get; set; }
        public string Remarks { get; set; }
    }
}
