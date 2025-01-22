using BMS.Data;
using BMS.DTOs.CustomerDTOs;
using BMS.Model;

namespace BMS.Repo.CustomerRepo
{
    public class CustomerRepo : ICustomerRepo
    {
        private readonly AppDbContext? _context;
        int ICustomerRepo.GetAllbyId(Customer customer)
        {
            throw new NotImplementedException();
        }

        int ICustomerRepo.GetbyId(string id)
        {
            throw new NotImplementedException();
        }

        bool ICustomerRepo.PostCustomer(string id, CustomerDto1 customerDto)
        {
            throw new NotImplementedException();
        }
    }
}