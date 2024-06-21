using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MaiB2004790_TTTT.Models;

public partial class MaiB2004790ttttContext : DbContext
{
    public MaiB2004790ttttContext()
    {
    }

    public MaiB2004790ttttContext(DbContextOptions<MaiB2004790ttttContext> options)
        : base(options)
    {
    }

    public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { }
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        //=> optionsBuilder.UseSqlServer("Server=DESKTOP-GALV3RF;Database=MaiB2004790TTTT;User Id=sa;Password=230719;Trusted_Connection=True;trustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<NhaCungCap>(entity =>
        {
            entity.ToTable("NhaCungCap");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DiaChi)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.MaSoThue).HasMaxLength(20);
            entity.Property(e => e.Sdt)
                .HasMaxLength(10)
                .HasColumnName("SDT");
            entity.Property(e => e.SoTk)
                .HasMaxLength(20)
                .HasColumnName("SoTK");
            entity.Property(e => e.TenNhaCungCap)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
