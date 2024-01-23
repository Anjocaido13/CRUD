using CRUD.Entities;

namespace CRUD.Persistence
{
    public class DevEventsDbContext
    {
        public List<DevEvent> DevEvents { get; set; }

        public DevEventsDbContext()
        {
            DevEvents = new List<DevEvent>();
        }

    }
}
