using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazerApp1.Data;

public partial class BookStoreDbContext : IdentityDbContext<ApiUser>
{
    public BookStoreDbContext()
    {
    }

    public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Author> Authors { get; set; }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<Table> Tables { get; set; }

    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Author>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Authors__3214EC07BC584D94");

            entity.Property(e => e.Bio).HasMaxLength(250);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC07772716CA");

            entity.HasIndex(e => e.Isbn, "UQ__tmp_ms_x__447D36EA4D96F115").IsUnique();

            entity.Property(e => e.Image).HasMaxLength(50);
            entity.Property(e => e.Isbn)
                .HasMaxLength(50)
                .HasColumnName("ISBN");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Summary).HasMaxLength(250);
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .HasColumnName("Title ");
        });

        modelBuilder.Entity<Table>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Table__3214EC076FE15DC5");

            entity.ToTable("Table");

            entity.Property(e => e.Bio).HasMaxLength(250);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
        });

        modelBuilder.Entity<IdentityRole>().HasData(
            new IdentityRole
            {
                Name = "User",
                NormalizedName = "USER",
                Id = "348eccc9-ac9f-4bb8-9898-5dcf8f9854dc"
            },

             new IdentityRole

             {
                 Name = "Administrator",
                 NormalizedName = "ADMININISTRATOR",
                 Id = "7ceae20e-1390-475f-8ec5-87293dc79748"
             }

            );

        var hasher = new PasswordHasher<ApiUser>();

        modelBuilder.Entity<ApiUser>().HasData(
            new ApiUser
            {
                
                Id = "b2b3903a-fa2e-4d3d-9749-65560a2f7c05",
                Email = "admin@bookstore.com",
                NormalizedEmail = "ADMIN@BOOKSTORE.COM",
                UserName = "admin@bookstore.com",
                FirstName = "System",
                LastName = "Admin",
                PasswordHash = hasher.HashPassword(null,"P@ssword1")

            },

             new ApiUser

             {
             
                 Id = "040dac1c-dec8-4c9e-881f-0341615815cc",
                 Email = "user@bookstore.com",
                 NormalizedEmail = "USER@BOOKSTORE.COM",
                 UserName = "user@bookstore.com",
                 FirstName = "System",
                 LastName = "User",
                 PasswordHash = hasher.HashPassword(null, "P@ssword1")
             }

            );

        modelBuilder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<String>
            {
                RoleId = "348eccc9-ac9f-4bb8-9898-5dcf8f9854dc",
                UserId = "040dac1c-dec8-4c9e-881f-0341615815cc"
            },

             new IdentityUserRole<String>
             {
                 RoleId = "7ceae20e-1390-475f-8ec5-87293dc79748",
                 UserId = "b2b3903a-fa2e-4d3d-9749-65560a2f7c05"
             }
             
             );

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
