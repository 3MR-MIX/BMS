using System.ComponentModel.DataAnnotations;

namespace BMS.Model
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Position { get; set; }
        public List<Branch>? branches { get; set; }
    }
}
