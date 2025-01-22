using System.ComponentModel.DataAnnotations;

namespace BMS.Model
{
    public class BankCard
    {
        [Key]
        public int Id { get; set; }
        [Required,MaxLength(15)]
        public string? CardNumber { get; set; }
        [Required,DataType(DataType.DateTime)]
        public string? ExpiryDate { get; set; }
        public int CustomerId { get; set; }
    }
}
