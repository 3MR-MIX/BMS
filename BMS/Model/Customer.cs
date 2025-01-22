using System.ComponentModel.DataAnnotations;

namespace BMS.Model
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email {  get; set; }
        [MaxLength(15)]
        public string phoneNumber { get; set; }
        public int? BankCardId { get; set; }
    }
}
