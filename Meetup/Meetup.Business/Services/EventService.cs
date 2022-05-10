using Meetup.Business.Services.Interfaces;
using Meetup.Data.Repositories.Interfaces;
using Meetup.Shared.Entities;

namespace Meetup.Business.Services
{
    public class EventService : IEventService
    {
        private readonly IEventRepository eventRepository;

        public EventService(IEventRepository eventRepository)
        {
            this.eventRepository = eventRepository;
        }

        public async Task<Event> Create(Event newEvent)
        {
            return await eventRepository.Create(newEvent);
        }

        public async Task<bool> Delete(int id)
        {
            return await eventRepository.Delete(id);
        }

        public async Task<IEnumerable<Event>> GetAll()
        {
            return await eventRepository.GetAll();
        }

        public async Task<Event?> GetById(int id)
        {
            return await eventRepository.GetById(id);
        }

        public async Task<Event> Update(Event @event)
        {
            return await eventRepository.Update(@event);
        }
    }
}
