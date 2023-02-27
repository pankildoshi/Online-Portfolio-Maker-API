using Microsoft.Build.Framework;

namespace PresentsYouAPI.Models
{
    public class Project
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public string GithubUrl { get; set; }
        public string LiveUrl { get; set; }

        public User User { get; set; }
    }
}
