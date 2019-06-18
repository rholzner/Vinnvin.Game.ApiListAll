using System;
using System.Collections.Generic;

namespace Vinnvin.GameApi.listAll.Models
{
    public class Vocher
    {
        public string TicketId { get; set; }
        public DateTime PerchesTime { get; set; }
        public IEnumerable<Ticket> Tickets { get; set; }
    }
}
