using Meetup.Business.Services.Interfaces;
using Meetup.Shared.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Meetup.API.Controllers
{
    [Route("api/events")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly IEventService eventService;

        public EventController(IEventService eventService)
        {
            this.eventService = eventService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Event>> GetById(int id)
        {
            var @event = await eventService.GetById(id);

            if (@event == null)
            {
                return BadRequest("There is no event with such id.");
            }

            return Ok(@event);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Event>>> GetAll()
        {
            return Ok(await eventService.GetAll());
        }

        [HttpPost]
        public async Task<ActionResult<Event>> Create(Event @event)
        {
            return Ok(await eventService.Create(@event));
        }

        [HttpPut]
        public async Task<ActionResult<Event>> Update(Event @event)
        {
            return Ok(await @eventService.Update(@event));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var isDeleted = await eventService.Delete(id);

            if (!isDeleted)
            {
                return BadRequest("Event was not deleted.");
            }

            return NoContent();
        }
    }
}
