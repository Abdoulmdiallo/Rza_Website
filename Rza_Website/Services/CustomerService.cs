using Rza_Website.Models;
using Microsoft.EntityFrameworkCore;

namespace Rza_Website.Services
{
    public class CustomerService
    {
        private readonly  TlS2300852RzaContext _context;
        public CustomerService(TlS2300852RzaContext context)
        {
            
            _context = context;

        }
        public  async Task AddCustomerAsync(Customer customer)
        { 
        
            await _context.Customers.AddAsync(customer);
            await _context.SaveChangesAsync();

        }
        public async Task<bool> CheckUsernameExistsAsync(string username)
        { 
            var result = await _context.Customers.FirstOrDefaultAsync(c => c.Username == username);
            return result != null;
        }

        public async Task<Customer?> LogIn(Customer customer) 
        {

            return await _context.Customers.FirstOrDefaultAsync(
                c => c.Username == customer.Username &&
                c.Password == customer.Password);

        }

        
    }
}
