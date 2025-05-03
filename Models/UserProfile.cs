using System.ComponentModel.DataAnnotations;

namespace SkillPointAi.Models
{
    public class UserProfile
    {
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        [Required]
        public string ConfirmPassword { get; set; }

        [Required]
        public  List<string>? CurrentSkills { get; set; }
        [Required]
        public string DreamJob { get; set; } 
    }
}
