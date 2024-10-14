using System;
using System.Collections.Generic;

namespace Rza_Website.Models;

public partial class Attraction
{
    public int AttractioniD { get; set; }

    public string? AttractionName { get; set; }

    public int Capacity { get; set; }

    public DateTime? Schedule { get; set; }

    public float? Price { get; set; }

    public string? SpecialReqs { get; set; }

    public int? TicketiD { get; set; }

    public virtual Ticket? Ticket { get; set; }
}
