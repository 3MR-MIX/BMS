using System.ComponentModel.DataAnnotations;

namespace BMS.Model
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(20)]
        public string? AccountNumber { get; set; }
        [Required]
        public int? Balance { get; set; }
        public int? CustomerId { get; set; }
        public Transaction? Transaction { get; set; }
    }
}
