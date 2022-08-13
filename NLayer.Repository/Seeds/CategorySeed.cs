using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;

namespace NLayer.Repository.Seeds
{
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
           // Category c = new();

            builder.HasData(
                new Category { Id = 1, Name = "Kardiyo" },
                new Category { Id = 2, Name = "Ağırlık" }

                );
        }
    }
}
