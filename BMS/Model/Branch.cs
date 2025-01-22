using System.ComponentModel.DataAnnotations;

namespace BMS.Model
{
    public class Branch
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Location { get; set; }
        public List<Employee > Employees { get; set; }
    }
}
