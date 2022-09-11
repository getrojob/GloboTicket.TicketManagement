using AutoMapper;
using GloboTicket.TicketManagement.Application.Contracts.Persistence;
using GloboTicket.TicketManagement.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagement.Application.Features.Events.Queries.GetEventDetail
{
    internal class GetEventsDetailQueryHandler : IRequestHandler<GetEventsDetailQuery, EventDetailVm>
    {
        private readonly IAsyncRepository<Event> _eventRepository;
        private readonly IAsyncRepository<Category> _categoryepository;
        private readonly IMapper _mapper;

        public GetEventsDetailQueryHandler(IAsyncRepository<Event> eventRepository, IAsyncRepository<Category> categoryepository, IMapper mapper)
        {
            _eventRepository = eventRepository;
            _categoryepository = categoryepository;
            _mapper = mapper;
        }

        public async Task<EventDetailVm> Handle(GetEventsDetailQuery request, CancellationToken cancellationToken)
        {
            var @event = await _eventRepository.GetByIdAsync(request.Id);
            var eventDetailDto = _mapper.Map<EventDetailVm>(@event);

            var category = await _categoryepository.GetByIdAsync(@event.CategoryId);

            eventDetailDto.Category = _mapper.Map<CategoryDto>(category);

            return eventDetailDto;
        }
    }
}
