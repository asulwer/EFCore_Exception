using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TestModel.Models.Mapping
{
    public class itemMap : IEntityTypeConfiguration<item>
    {

        public void Configure(EntityTypeBuilder<item> builder)
        {
            // Primary Key
            builder.HasKey(t => t.Id);

            builder.Property(t => t.ItemName)
                .HasMaxLength(100);

            builder.Property(t => t.ItemDesc)
                .HasMaxLength(100);

            // Table & Column Mappings
            builder.ToTable("item");
            builder.Property(t => t.Id).HasColumnName("Id").IsConcurrencyToken();
            builder.Property(t => t.ItemName).HasColumnName("ItemName");
            builder.Property(t => t.ItemDesc).HasColumnName("ItemDesc");
            builder.Property(t => t.TS).ValueGeneratedOnUpdate().IsConcurrencyToken();
        }
    }
}
