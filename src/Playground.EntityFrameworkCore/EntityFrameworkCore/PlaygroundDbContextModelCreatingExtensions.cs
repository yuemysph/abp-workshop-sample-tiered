using Microsoft.EntityFrameworkCore;
using Playground.Authors;
using Playground.Books;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Playground.EntityFrameworkCore
{
    public static class PlaygroundDbContextModelCreatingExtensions
    {
        public static void ConfigurePlayground(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            builder.Entity<Book>(b =>
            {
                b.ToTable(PlaygroundConsts.DbTablePrefix + "Books",
                          PlaygroundConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Name).IsRequired().HasMaxLength(128);
                b.HasOne<Author>().WithMany().HasForeignKey(x => x.AuthorId).IsRequired();
            });

            builder.Entity<Author>(b =>
            {
                b.ToTable(PlaygroundConsts.DbTablePrefix + "Authors",
                    PlaygroundConsts.DbSchema);

                b.ConfigureByConvention();

                b.Property(x => x.Name)
                    .IsRequired()
                    .HasMaxLength(AuthorConsts.MaxNameLength);

                b.HasIndex(x => x.Name);
            });

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(PlaygroundConsts.DbTablePrefix + "YourEntities", PlaygroundConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}