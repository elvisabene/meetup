﻿using Meetup.Data.Repositories.Interfaces;
using Meetup.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace Meetup.Data.Repositories
{
    public class EventRepository : IEventRepository
    {
        private readonly DataContext context;

        public EventRepository(DataContext context)
        {
            this.context = context;
        }

        public async Task<Event> Create(Event newEvent)
        {
            context.Events.Add(newEvent);
            await context.SaveChangesAsync();

            return newEvent;
        }

        public async Task<bool> Delete(int id)
        {
            var eventToDelete = await context.Events.FindAsync(id);

            if (eventToDelete == null)
            {
                return false;
            }

            context.Events.Remove(eventToDelete);
            await context.SaveChangesAsync();

            return true;
        }

        public async Task<IEnumerable<Event>> GetAll()
        {
            var events = await context.Events.ToListAsync();

            return events;
        }

        public async Task<Event?> GetById(int id)
        {
            var @event = await context.Events.FindAsync(id);

            return @event;
        }

        public async Task Update(Event entity)
        {
            context.Events.Update(entity);
            await context.SaveChangesAsync();
        }
    }
}