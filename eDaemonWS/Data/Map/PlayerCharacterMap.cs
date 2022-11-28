using eDaemonWS.Model.Characters;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eDaemonWS.Data.Map
{
    public class PlayerCharacterMap : IEntityTypeConfiguration<PlayerCharacter>
    {
        public void Configure(EntityTypeBuilder<PlayerCharacter> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Strength).IsRequired().HasMaxLength(3);
            builder.Property(x => x.Agility).IsRequired().HasMaxLength(3);
            builder.Property(x => x.Dexterity).IsRequired().HasMaxLength(3);
            builder.Property(x => x.Constitution).IsRequired().HasMaxLength(3);
            builder.Property(x => x.Intelligence).IsRequired().HasMaxLength(3);
            builder.Property(x => x.WillPower).IsRequired().HasMaxLength(3);
            builder.Property(x => x.Perception).IsRequired().HasMaxLength(3);
            builder.Property(x => x.Charisma).IsRequired().HasMaxLength(3);
        }
    }
}
