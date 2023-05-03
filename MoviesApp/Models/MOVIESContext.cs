using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MoviesApp.Models
{
    public partial class MOVIESContext : DbContext
    {
        public MOVIESContext()
        {
        }

        public MOVIESContext(DbContextOptions<MOVIESContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Film> Films { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Server=DESKTOP-692G2J9\\SQLEXPRESS;Database=MOVIES;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "French_CI_AS");

            modelBuilder.Entity<Film>(entity =>
            {
                //entity.HasNoKey();

                entity.ToTable("FILM");

                entity.Property(e => e.Actors)                    
                    .HasMaxLength(76)
                    .IsUnicode(false);

                entity.Property(e => e.Awards)                    
                    .HasMaxLength(66)
                    .IsUnicode(false);

                entity.Property(e => e.ComingSoon)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Country)                    
                    .HasMaxLength(26)
                    .IsUnicode(false);

                entity.Property(e => e.Director)                    
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.Genre)
                    .IsRequired()
                    .HasMaxLength(26)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Images0)                    
                    .HasMaxLength(163)
                    .IsUnicode(false);

                entity.Property(e => e.Images1)                    
                    .HasMaxLength(163)
                    .IsUnicode(false);

                entity.Property(e => e.Images2)                   
                    .HasMaxLength(164)
                    .IsUnicode(false);

                entity.Property(e => e.Images3)
                    .HasMaxLength(164)
                    .IsUnicode(false);

                entity.Property(e => e.Images4)
                    .HasMaxLength(163)
                    .IsUnicode(false);

                entity.Property(e => e.ImdbId)                   
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("imdbID");

                entity.Property(e => e.ImdbRating)                    
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("imdbRating");

                entity.Property(e => e.ImdbVotes)                    
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("imdbVotes");

                entity.Property(e => e.Language)                    
                    .HasMaxLength(39)
                    .IsUnicode(false);

                entity.Property(e => e.Metascore)                    
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Plot)                    
                    .HasMaxLength(246)
                    .IsUnicode(false);

                entity.Property(e => e.Poster)
                    
                    .HasMaxLength(131)
                    .IsUnicode(false);

                entity.Property(e => e.Rated)
                    
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Released)
                    
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Response)
                    
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Runtime)
                    
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(28)
                    .IsUnicode(false);

                entity.Property(e => e.TotalSeasons).HasColumnName("totalSeasons");

                entity.Property(e => e.Type)
                    
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Writer)
                    
                    .HasMaxLength(170)
                    .IsUnicode(false);

                entity.Property(e => e.Year)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
