using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace StockMarket.Admin.Entities
{
    [Table("Company")]
    public class Company
    {
        [Key]
        [StringLength(50)]
        [Column(TypeName = "Char")]
        public string CompanyName { get; set; }

        [Required]
        [StringLength(30)]
        public string Ceo { get; set; }

        public float Turnover { get; set; }
        [Required]
        public string BoardOfDirectors { get; set; }
        [Required]
        public string ListedInSe { get; set; }
        [Required]
        public string Brief { get; set; }
        [Required]
        [StringLength(10)]
        [Column(TypeName = "Char")]
        public string CompanyCode { get; set; }

        [ForeignKey("Sector")]
        public int SectorId { get; set; }
        public Sector Sector { get; set; }
    }
}
