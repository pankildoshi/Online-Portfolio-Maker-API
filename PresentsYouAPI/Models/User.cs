using System.ComponentModel.DataAnnotations;

namespace PresentsYouAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string GithubProfile { get; set; }
        public string LinkedInProfile { get; set; }
    }
}
