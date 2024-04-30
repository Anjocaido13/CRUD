namespace CRUD.Entities
{
    public class DevEvent
    {
        public DevEvent()
        {
            Speakers = new List<DevEventSpeaker>();
            IsDeleted = true;
        }

        public Guid Id { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<DevEventSpeaker> Speakers { get; set; }
        public bool IsDeleted { get; set; }

        public void Update(String title, String description, DateTime startdate, DateTime endDate)
        {
            Title = title;
            Description = description;
            StartDate = startdate;
            EndDate = endDate;
        }
        public void Delete()
        {
            IsDeleted = true;
        }
    }
}
