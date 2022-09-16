using GloboTicket.TicketManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;

namespace GloboTicket.TicketManagement.Domain.Entities
{
    public class Event : AuditableEntity
    {
        public Guid EventId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public int Price { get; set; }

        [Required]
        [StringLength(50)]
        public string Artist { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
