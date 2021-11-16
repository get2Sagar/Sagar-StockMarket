using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace StockMarket.AccountAPI.Entities
{
    [Table("Users")]
    [Index(nameof(Users.UserName), IsUnique = true)]
    public class Users
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(450)]
        
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string UserType { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string MobileNo { get; set; }

        public string Confirmed { get; set; }
    }
}
