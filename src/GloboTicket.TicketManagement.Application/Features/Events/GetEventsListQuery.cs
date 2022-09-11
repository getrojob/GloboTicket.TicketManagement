using System.Collections.Generic;
using MediatR;
namespace GloboTicket.TicketManagement.Application.Features.Events.Queries.GetEventDetail
{
    public class GetEventsListQuery : IRequest<List<EventListVm>>
    {

    }
}
