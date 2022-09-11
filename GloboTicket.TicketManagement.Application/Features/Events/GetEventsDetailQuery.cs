using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace GloboTicket.TicketManagement.Application.Features.Events.Queries.GetEventDetail
{
    public class GetEventsDetailQuery : IRequest<EventDetailVm>
    {
        public Guid Id { get; set; }
    }
}
