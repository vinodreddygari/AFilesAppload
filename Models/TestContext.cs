using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AFilesAppload.Models;

public partial class TestContext : DbContext
{
    public TestContext()
    {
    }

    public TestContext(DbContextOptions<TestContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ApploadFile> ApploadFiles { get; set; }

    public virtual DbSet<Tuser> Tusers { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB;Database=Test;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ApploadFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ApploadF__3214EC07F77337CA");

            entity.ToTable("ApploadFile");

            entity.Property(e => e.FileName).HasMaxLength(40);
            entity.Property(e => e.Filedata).HasColumnName("FILEDATA");
            entity.Property(e => e.Filetype).HasColumnName("FILETYPE");
        });

        modelBuilder.Entity<Tuser>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.ToTable("TUsers");

            entity.Property(e => e.Password).HasMaxLength(30);
            entity.Property(e => e.Pdffile)
                .HasDefaultValueSql("(0x)")
                .HasColumnName("PDFfile");
            entity.Property(e => e.UserEmail).HasMaxLength(30);
            entity.Property(e => e.UserName).HasMaxLength(30);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_Users_Id");

            entity.Property(e => e.PdfFile).HasColumnName("PDF_File");
            entity.Property(e => e.UserEmail)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.UserPassword)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
