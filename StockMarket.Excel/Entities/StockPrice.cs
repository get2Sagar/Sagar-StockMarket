using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockMarket.Admin.Entities
{
    [Table("StockPrice")]
    public class StockPrice
    {
        [Key]
        public int StockId { get; set; }
        public double CurrentPrice { get; set; }
        public DateTime Date { get; set; }
        [Required]
        public string Time { get; set; }
        [Required]
        public string StockExchange { get; set; }

        [ForeignKey("Company")]
        public string CompanyCode { get; set; }
        public Company Company { get; set; }
    }
}
