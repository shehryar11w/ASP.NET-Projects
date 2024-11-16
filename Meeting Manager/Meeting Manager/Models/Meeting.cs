namespace Meeting_Manager.Models
{
    public class Meeting
    {
        public int Id { get; set; }

        public string? Subject { get; set; }

        public string? MeetingLink { get; set; }

        public DateTime? MeetingTime { get; set; }

        public string? Password { get; set; }

        public Meeting()
            {

            }

    }
}
