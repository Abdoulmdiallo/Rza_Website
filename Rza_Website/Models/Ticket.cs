using System;
using System.Collections.Generic;

namespace Rza_Website.Models;

public partial class Ticket
{
    public int? CustomeriD { get; set; }

    public int? AttractioniD { get; set; }

    public int TicketiD { get; set; }

    public float? Price { get; set; }

    public DateOnly? ValidFrom { get; set; }

    public string? TicketType { get; set; }

    public virtual Customer? Attraction { get; set; }

    public virtual ICollection<Attraction> Attractions { get; set; } = new List<Attraction>();
}
