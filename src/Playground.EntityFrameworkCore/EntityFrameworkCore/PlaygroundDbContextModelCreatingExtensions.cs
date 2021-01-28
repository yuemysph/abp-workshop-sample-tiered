using Microsoft.EntityFrameworkCore;
using Playground.Authors;
using Playground.Books;
using Playground.Customers;
using Playground.Payments;
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

            builder.Entity<RentalRecord>( b => {
                b.ToTable(PlaygroundConsts.DbTablePrefix + "RentalRecords",
                    PlaygroundConsts.DbSchema);
                b.ConfigureByConvention();
                b.Property(x => x.CustomerId).IsRequired();
                b.Property(x => x.StartDate).IsRequired();
                b.Property(x => x.EndDate).IsRequired();
                b.HasOne<Book>().WithMany().HasForeignKey(x => x.BookId).IsRequired();
                b.HasOne<Customer>().WithMany().HasForeignKey(x => x.CustomerId).IsRequired();
                b.HasOne<Payment>().WithMany().HasForeignKey(x => x.PaymentId).IsRequired();
            });

            builder.Entity<Customer>(b => {
                b.ToTable(PlaygroundConsts.DbTablePrefix + "Customers",
                    PlaygroundConsts.DbSchema);
                b.ConfigureByConvention();
                b.Property(x => x.Name).IsRequired();
                b.Property(x => x.Email).IsRequired();
            });

            builder.Entity<Payment>(b => {
                b.ToTable(PlaygroundConsts.DbTablePrefix + "Payments",
                    PlaygroundConsts.DbSchema);
                b.ConfigureByConvention();
                b.Property(x => x.PaymentDate).IsRequired();
                b.Property(x => x.Amount).IsRequired();
                b.HasOne<Customer>().WithMany().HasForeignKey(x => x.CustomerId).IsRequired();
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