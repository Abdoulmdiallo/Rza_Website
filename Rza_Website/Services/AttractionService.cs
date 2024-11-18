using Microsoft.EntityFrameworkCore;
using Rza_Website.Models;

namespace Rza_Website.Services
{
    public class AttractionService
    {
        private readonly TlS2300852RzaContext _context;
        public AttractionService(TlS2300852RzaContext context)
        {
            _context = context;
        }
        public async Task<List<Attraction>> GetAttractionsAsync()
        {
            return await _context.Attractions.ToListAsync();
        }
    }
}