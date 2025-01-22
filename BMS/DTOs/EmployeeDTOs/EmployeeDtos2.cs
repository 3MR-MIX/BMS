using BMS.DTOs.BranchDTOs;
using BMS.Model;

namespace BMS.DTOs.EmployeeDTOs
{
    public class EmployeeDtos2
    {
        public string? Position { get; set; }
        public List<BranchDtos1>? branchDtos1 { get; set; }
    }
}
