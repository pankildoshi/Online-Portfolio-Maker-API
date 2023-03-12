namespace PresentsYouAPI.Models
{
    public class Experience
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Role { get; set; }
        public string Description { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int UserId { get; set; }
    }
}
