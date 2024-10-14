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
    }
}
