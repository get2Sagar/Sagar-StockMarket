using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockMarket.Admin.Entities
{
    [Table("Ipo")]
    public class Ipo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "Char")]
        public string CompanyName { get; set; }

        [Required]
        public string StockExchange { get; set; }

        public float PricePerShare { get; set; }

        public long NoOfShares { get; set; }

        public DateTime OpenDateTime { get; set; }

        public string Remarks { get; set; }
    }
}
