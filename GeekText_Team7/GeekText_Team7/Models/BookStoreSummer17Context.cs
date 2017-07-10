using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GeekText_Team7.Models
{
    public partial class BookStoreSummer17Context : DbContext
    {
        public virtual DbSet<Author> Author { get; set; }
        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<BookAuthor> BookAuthor { get; set; }
        public virtual DbSet<CreditCard> CreditCard { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=BookStoreSummer17;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasIndex(e => e.UserId)
                    .HasName("IX_Book_UserId");

                entity.Property(e => e.Isbn).HasColumnName("ISBN");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Book)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<BookAuthor>(entity =>
            {
                entity.HasKey(e => new { e.BookId, e.AuthorId })
                    .HasName("PK_BookAuthor");

                entity.HasIndex(e => e.AuthorId)
                    .HasName("IX_BookAuthor_AuthorId");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.BookAuthor)
                    .HasForeignKey(d => d.AuthorId);

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.BookAuthor)
                    .HasForeignKey(d => d.BookId);
            });

            modelBuilder.Entity<CreditCard>(entity =>
            {
                entity.HasIndex(e => e.UserId)
                    .HasName("IX_CreditCard_UserID");

                entity.Property(e => e.CreditCardNumber).HasDefaultValueSql("0");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CreditCard)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasDefaultValueSql("'0001-01-01T00:00:00.000'");
            });
        }
    }
}