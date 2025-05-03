using System.ComponentModel.DataAnnotations;

namespace SkillPointAi.Models
{
    public class SkillGapResults
    {
        
        [Required]
        public string FullName { get; set; }
        [Required]
        public string DreamJob { get; set; }
        [Required]
        public List<string> CurrentSkills { get; set; }

        [Required]
        public List<string>? MissingSkills { get; set; }
        [Required]
        public Dictionary<string, string> RecommendedResources{ get; set; }
    }
}
