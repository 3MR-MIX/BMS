using BMS.Data;
using BMS.DTOs.CustomerDTOs;
using BMS.Model;

namespace BMS.Repo.CustomerRepo
{
    public interface ICustomerRepo 
    {
        public int GetAllbyId(Customer customer);
        public bool PostCustomer(string id,CustomerDto1 customerDto);
        public int GetbyId(string id);
    }
}