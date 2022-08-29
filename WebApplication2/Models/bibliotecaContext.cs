using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication2.Models
{
    public partial class bibliotecaContext : DbContext
    {
        public bibliotecaContext()
        {
        }

        public bibliotecaContext(DbContextOptions<bibliotecaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Livro> Livros { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-J9HVPQ1\\SQLEXPRESS;Database=biblioteca;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Livro>(entity =>
            {
                entity.ToTable("livro");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Autor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("autor");

                entity.Property(e => e.ISBN)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("isbn");

                entity.Property(e => e.DataDePublicacao)
                    .HasColumnType("date")
                    .HasColumnName("data_de_publicacao");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nome");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
