using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RestaurantApp.Models
{
    public partial class TraineeDemo1Context : DbContext
    {
        public TraineeDemo1Context()
        {
        }

        public TraineeDemo1Context(DbContextOptions<TraineeDemo1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<BookImages> BookImages { get; set; }
        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<Cart> Cart { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Items> Items { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<PaymentTypes> PaymentTypes { get; set; }
        public virtual DbSet<Purchases> Purchases { get; set; }
        public virtual DbSet<Rents> Rents { get; set; }
        public virtual DbSet<Reports> Reports { get; set; }
        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<Useraccounts> Useraccounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Data Source=192.168.1.201;Initial Catalog=TraineeDemo1;Persist Security Info=True;User ID=User_AviBen;Password=password123###;MultipleActiveResultSets=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FirstName).HasMaxLength(256);

                entity.Property(e => e.LastName).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Author)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BookId).ValueGeneratedOnAdd();

                entity.Property(e => e.BookImagefile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BookInfo).IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BookImages>(entity =>
            {
                entity.HasKey(e => e.BookImageId);

                entity.HasIndex(e => e.BookId);

                entity.Property(e => e.FileName).IsRequired();

                entity.Property(e => e.FilePath).IsRequired();

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.BookImages)
                    .HasForeignKey(d => d.BookId);
            });

            modelBuilder.Entity<Books>(entity =>
            {
                entity.HasKey(e => e.BookId);

                entity.HasIndex(e => e.CategoryId);

                entity.HasIndex(e => e.RentId);

                entity.Property(e => e.AuhorName).IsRequired();

                entity.Property(e => e.AuthorContactNo).IsRequired();

                entity.Property(e => e.BookName).IsRequired();

                entity.Property(e => e.PublisherName).IsRequired();

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.CategoryId);

                entity.HasOne(d => d.Rent)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.RentId);
            });

            modelBuilder.Entity<Cart>(entity =>
            {
                entity.HasIndex(e => e.AppUsersId);

                entity.HasIndex(e => e.BookId);

                entity.Property(e => e.Price).IsRequired();

                entity.HasOne(d => d.AppUsers)
                    .WithMany(p => p.Cart)
                    .HasForeignKey(d => d.AppUsersId);

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.Cart)
                    .HasForeignKey(d => d.BookId);
            });

            modelBuilder.Entity<Categories>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.Property(e => e.CategoryName).IsRequired();
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.Property(e => e.CustomerName).IsRequired();
            });

            modelBuilder.Entity<Items>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.Property(e => e.ItemName).IsRequired();

                entity.Property(e => e.ItemPrice).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.OrderId).ValueGeneratedOnAdd();

                entity.Property(e => e.Orderdate).HasColumnType("datetime2(2)");
            });

            modelBuilder.Entity<PaymentTypes>(entity =>
            {
                entity.HasKey(e => e.PaymentTypeId);

                entity.Property(e => e.PaymentTypeName).IsRequired();
            });

            modelBuilder.Entity<Purchases>(entity =>
            {
                entity.HasKey(e => e.PurchaseId);

                entity.HasIndex(e => e.AppUsersId);

                entity.HasIndex(e => e.OrderId);

                entity.HasOne(d => d.AppUsers)
                    .WithMany(p => p.Purchases)
                    .HasForeignKey(d => d.AppUsersId);
            });

            modelBuilder.Entity<Rents>(entity =>
            {
                entity.HasKey(e => e.RentId);

                entity.HasIndex(e => e.AppUsersId);

                entity.HasIndex(e => e.BookId)
                    .IsUnique()
                    .HasFilter("([BookId] IS NOT NULL)");

                entity.Property(e => e.Quantity).IsRequired();

                entity.HasOne(d => d.AppUsers)
                    .WithMany(p => p.Rents)
                    .HasForeignKey(d => d.AppUsersId);

                entity.HasOne(d => d.Book)
                    .WithOne(p => p.Rents)
                    .HasForeignKey<Rents>(d => d.BookId);
            });

            modelBuilder.Entity<Reports>(entity =>
            {
                entity.HasKey(e => e.ReportId);
            });

            modelBuilder.Entity<Students>(entity =>
            {
                entity.HasIndex(e => e.AppUsersId);

                entity.HasIndex(e => e.BookId);

                entity.Property(e => e.Address).IsRequired();

                entity.Property(e => e.ContactNo).IsRequired();

                entity.Property(e => e.StudentName).IsRequired();

                entity.HasOne(d => d.AppUsers)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.AppUsersId);

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.BookId);
            });

            modelBuilder.Entity<Useraccounts>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Role)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
