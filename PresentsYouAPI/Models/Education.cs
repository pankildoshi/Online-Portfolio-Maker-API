namespace PresentsYouAPI.Models
{
    public class Education
    {
        public int Id { get; set; }
        public string Institute { get; set; }
        public string Degree { get; set; }
        public string Field { get; set; }
        public int Grade { get; set; }
        public User User { get; set; }
    }
}
