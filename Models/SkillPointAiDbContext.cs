using Microsoft.EntityFrameworkCore;

namespace SkillPointAi.Models
{
    public class SkillPointAiDbContext: DbContext
    {
        public DbSet<UserProfile> UserProfiles { get; set; }
        public SkillPointAiDbContext(DbContextOptions<SkillPointAiDbContext> options)
            : base(options)
        {

        }
        
        
    }
}
