using Microsoft.EntityFrameworkCore;
using Rza_Website.Models;


namespace Rza_Website.Services
{
    public class TicketBookingService
    {
        private readonly TlS2300852RzaContext _context;
        public TicketBookingService(TlS2300852RzaContext context)
        {
            _context = context;
        }
        public async Task<List<Ticketbooking>> GetTicketBookingAsync()
        {
            return await _context.Ticketbookings.ToListAsync();
        }
        public async Task AddTicketBookingAsync(Ticketbooking newTicketbooking)
        {
            await _context.Ticketbookings.AddAsync(newTicketbooking);
            await _context.SaveChangesAsync();
        }
    }
}
