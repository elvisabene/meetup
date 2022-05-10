namespace Meetup.Shared.Entities
{
    public class Event
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string OrganizerName { get; set; } = null!;

        public string Place { get; set; } = null!;

        public DateTime Date { get; set; }
    }
}
