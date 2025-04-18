﻿using Microsoft.EntityFrameworkCore;
using Rza_Website.Models;

namespace Rza_Website.Services

{

    public class TicketService

    {

        private readonly TlS2300852RzaContext _context;

        public TicketService(TlS2300852RzaContext context)

        {

            _context = context;

        }

        public async Task<List<Ticket>> GetTicketsAsync()

        {

            return await _context.Tickets.ToListAsync();

        }

        public async Task AddTicketAsync(Ticket newTicket)

        {

            await _context.Tickets.AddAsync(newTicket);

            await _context.SaveChangesAsync();

        }

    }

}