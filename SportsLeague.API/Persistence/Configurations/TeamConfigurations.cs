using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsLeague.API.Core.Models;

namespace SportsLeague.API.Persistence.Configurations
{
    public class TeamConfigurations : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Name).IsRequired().HasMaxLength(50);
            builder.Property(t => t.City).IsRequired().HasMaxLength(35);
            builder.Property(t => t.Coach).IsRequired().HasMaxLength(50);
        }
    }
}
