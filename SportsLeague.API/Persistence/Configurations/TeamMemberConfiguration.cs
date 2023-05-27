using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsLeague.API.Core.Models;

namespace SportsLeague.API.Persistence.Configurations
{
    public class TeamMemberConfiguration : IEntityTypeConfiguration<TeamMember>
    {
        public void Configure(EntityTypeBuilder<TeamMember> builder)
        {
            builder.HasKey(m => m.Id);

            builder.Property(m => m.Name).IsRequired().HasMaxLength(50);
            builder.Property(m => m.Position).IsRequired().HasMaxLength(50);
            builder.Property(m => m.Number).IsRequired();
        }
    }
}
