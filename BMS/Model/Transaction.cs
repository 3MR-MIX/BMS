using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace BMS.Model
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public int AccountId { get; set; }
    }
}
