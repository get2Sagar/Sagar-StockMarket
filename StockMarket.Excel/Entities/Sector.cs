using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockMarket.Admin.Entities
{
    [Table("Sector")]
    public class Sector
    {
        [Key] //Apply PK
        public int SectorId { get; set; }

        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string SectorName { get; set; }

        public string Brief { get; set; }

    }
}
