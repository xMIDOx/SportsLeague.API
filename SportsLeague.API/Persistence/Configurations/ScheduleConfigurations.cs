using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsLeague.API.Core.Models;

namespace SportsLeague.API.Persistence.Configurations
{
    public class ScheduleConfigurations : IEntityTypeConfiguration<Schedule>
    {
        public void Configure(EntityTypeBuilder<Schedule> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.ScheduleDate).IsRequired();

            builder.HasOne(s => s.HomeTeam)
                .WithMany(t => t.HomeSchedules)
                .HasForeignKey(s => s.HomeTeamId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(s => s.AwayTeam)
                .WithMany(t => t.AwaySchedules)
                .HasForeignKey(s => s.AwayTeamId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasIndex(s => new { s.HomeTeamId, s.AwayTeamId }).IsUnique();
        }
    }
}
