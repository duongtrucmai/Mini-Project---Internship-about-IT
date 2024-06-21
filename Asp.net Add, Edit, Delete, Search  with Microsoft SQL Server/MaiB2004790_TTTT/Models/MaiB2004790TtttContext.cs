using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MaiB2004790_TTTT.Models;

public partial class MaiB2004790TtttContext : DbContext
{
    public MaiB2004790TtttContext()
    {
    }

    public MaiB2004790TtttContext(DbContextOptions<MaiB2004790TtttContext> options)
        : base(options)
    {
    }

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
       // => optionsBuilder.UseSqlServer("Server=DESKTOP-GALV3RF;Database=MaiB2004790_TTTT;User Id=sa;Password=230719;Trusted_Connection=True;trustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.ToTable("KhachHang");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Họ)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Sđt).HasColumnName("SĐT");
            entity.Property(e => e.Tên)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.ĐịaChỉ).HasColumnType("text");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
