using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace QLBanSach.Models;

public partial class QlbanSachContext : DbContext
{
    public QlbanSachContext()
    {
    }

    public QlbanSachContext(DbContextOptions<QlbanSachContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cau1> Cau1s { get; set; }

    public virtual DbSet<Cau10> Cau10s { get; set; }

    public virtual DbSet<Cau11> Cau11s { get; set; }

    public virtual DbSet<Cau12> Cau12s { get; set; }

    public virtual DbSet<Cau13> Cau13s { get; set; }

    public virtual DbSet<Cau14> Cau14s { get; set; }

    public virtual DbSet<Cau15> Cau15s { get; set; }

    public virtual DbSet<Cau16> Cau16s { get; set; }

    public virtual DbSet<Cau17> Cau17s { get; set; }

    public virtual DbSet<Cau18> Cau18s { get; set; }

    public virtual DbSet<Cau19> Cau19s { get; set; }

    public virtual DbSet<Cau2> Cau2s { get; set; }

    public virtual DbSet<Cau3> Cau3s { get; set; }

    public virtual DbSet<Cau4> Cau4s { get; set; }

    public virtual DbSet<Cau5> Cau5s { get; set; }

    public virtual DbSet<Cau6> Cau6s { get; set; }

    public virtual DbSet<Cau7> Cau7s { get; set; }

    public virtual DbSet<Cau8> Cau8s { get; set; }

    public virtual DbSet<Cau9> Cau9s { get; set; }

    public virtual DbSet<TChiTietHdb> TChiTietHdbs { get; set; }

    public virtual DbSet<TChiTietHdn> TChiTietHdns { get; set; }

    public virtual DbSet<THoaDonBan> THoaDonBans { get; set; }

    public virtual DbSet<THoaDonNhap> THoaDonNhaps { get; set; }

    public virtual DbSet<TKhachHang> TKhachHangs { get; set; }

    public virtual DbSet<TNhaCungCap> TNhaCungCaps { get; set; }

    public virtual DbSet<TNhaXuatBan> TNhaXuatBans { get; set; }

    public virtual DbSet<TNhanVien> TNhanViens { get; set; }

    public virtual DbSet<TSach> TSaches { get; set; }

    public virtual DbSet<TTheLoai> TTheLoais { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=QLBanSach;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cau1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("cau1");

            entity.Property(e => e.MaSach).HasMaxLength(10);
            entity.Property(e => e.TacGia).HasMaxLength(150);
            entity.Property(e => e.TenSach).HasMaxLength(200);
        });

        modelBuilder.Entity<Cau10>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("cau10");

            entity.Property(e => e.MaSach).HasMaxLength(10);
            entity.Property(e => e.TenSach).HasMaxLength(200);
            entity.Property(e => e.TenTheLoai).HasMaxLength(100);
        });

        modelBuilder.Entity<Cau11>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("cau11");

            entity.Property(e => e.DiaChi).HasMaxLength(150);
            entity.Property(e => e.DienThoai).HasMaxLength(15);
            entity.Property(e => e.MaKh)
                .HasMaxLength(10)
                .HasColumnName("MaKH");
            entity.Property(e => e.TenKh).HasMaxLength(50);
        });

        modelBuilder.Entity<Cau12>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("cau12");

            entity.Property(e => e.SoHdb)
                .HasMaxLength(10)
                .HasColumnName("SoHDB");
            entity.Property(e => e.TongTriGia).HasColumnType("money");
            entity.Property(e => e.TriGiaHoaDon).HasColumnType("money");
        });

        modelBuilder.Entity<Cau13>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("cau13");

            entity.Property(e => e.MaSach).HasMaxLength(10);
            entity.Property(e => e.TacGia).HasMaxLength(150);
            entity.Property(e => e.TenSach).HasMaxLength(200);
        });

        modelBuilder.Entity<Cau14>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("cau14");

            entity.Property(e => e.MaSach).HasMaxLength(10);
            entity.Property(e => e.TacGia).HasMaxLength(150);
            entity.Property(e => e.TenSach).HasMaxLength(200);
        });

        modelBuilder.Entity<Cau15>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("cau15");

            entity.Property(e => e.MaSach).HasMaxLength(10);
            entity.Property(e => e.TacGia).HasMaxLength(150);
            entity.Property(e => e.TenSach).HasMaxLength(200);
        });

        modelBuilder.Entity<Cau16>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("cau16");

            entity.Property(e => e.MaSach).HasMaxLength(10);
            entity.Property(e => e.Slban2014).HasColumnName("SLBan2014");
            entity.Property(e => e.TacGia).HasMaxLength(150);
            entity.Property(e => e.TenSach).HasMaxLength(200);
        });

        modelBuilder.Entity<Cau17>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("cau17");

            entity.Property(e => e.MaKh)
                .HasMaxLength(10)
                .HasColumnName("MaKH");
            entity.Property(e => e.TenKh)
                .HasMaxLength(50)
                .HasColumnName("TenKH");
            entity.Property(e => e.TriGiaHoaDon).HasColumnType("money");
        });

        modelBuilder.Entity<Cau18>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("cau18");

            entity.Property(e => e.DoanhSo).HasColumnType("money");
            entity.Property(e => e.MaNv)
                .HasMaxLength(10)
                .HasColumnName("MaNV");
            entity.Property(e => e.TenNv)
                .HasMaxLength(50)
                .HasColumnName("TenNV");
        });

        modelBuilder.Entity<Cau19>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("cau19");

            entity.Property(e => e.MaNxb)
                .HasMaxLength(10)
                .HasColumnName("MaNXB");
            entity.Property(e => e.MaSach).HasMaxLength(10);
            entity.Property(e => e.TenNxb)
                .HasMaxLength(100)
                .HasColumnName("TenNXB");
            entity.Property(e => e.TenSach).HasMaxLength(200);
        });

        modelBuilder.Entity<Cau2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("cau2");

            entity.Property(e => e.MaSach).HasMaxLength(10);
            entity.Property(e => e.TacGia).HasMaxLength(150);
            entity.Property(e => e.TenSach).HasMaxLength(200);
        });

        modelBuilder.Entity<Cau3>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("cau3");

            entity.Property(e => e.DienThoai).HasMaxLength(15);
            entity.Property(e => e.MaKh)
                .HasMaxLength(10)
                .HasColumnName("MaKH");
            entity.Property(e => e.TenKh)
                .HasMaxLength(50)
                .HasColumnName("TenKH");
            entity.Property(e => e.TongTienTieuDung).HasColumnType("money");
        });

        modelBuilder.Entity<Cau4>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("cau4");

            entity.Property(e => e.MaSach).HasMaxLength(10);
            entity.Property(e => e.Slban2021).HasColumnName("SLBan2021");
            entity.Property(e => e.Slnhap2021).HasColumnName("SLNhap2021");
            entity.Property(e => e.TenSach).HasMaxLength(200);
        });

        modelBuilder.Entity<Cau5>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("cau5");

            entity.Property(e => e.MaKh)
                .HasMaxLength(10)
                .HasColumnName("MaKH");
            entity.Property(e => e.MaNv)
                .HasMaxLength(10)
                .HasColumnName("MaNV");
            entity.Property(e => e.NgayBan).HasColumnType("datetime");
            entity.Property(e => e.SoHdb)
                .HasMaxLength(10)
                .HasColumnName("SoHDB");
            entity.Property(e => e.TongTienHoaDon).HasColumnType("money");
        });

        modelBuilder.Entity<Cau6>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("cau6");

            entity.Property(e => e.DoanhThu).HasColumnType("money");
        });

        modelBuilder.Entity<Cau7>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("cau7");

            entity.Property(e => e.DoanhThu).HasColumnType("money");
        });

        modelBuilder.Entity<Cau8>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("cau8");

            entity.Property(e => e.DienThoai).HasMaxLength(15);
            entity.Property(e => e.MaKh)
                .HasMaxLength(10)
                .HasColumnName("MaKH");
            entity.Property(e => e.TenKh)
                .HasMaxLength(50)
                .HasColumnName("TenKH");
            entity.Property(e => e.TongTieuDung).HasColumnType("money");
        });

        modelBuilder.Entity<Cau9>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("cau9");

            entity.Property(e => e.MaSach).HasMaxLength(10);
            entity.Property(e => e.Slban2014).HasColumnName("SLBan2014");
            entity.Property(e => e.TacGia).HasMaxLength(150);
            entity.Property(e => e.TenSach).HasMaxLength(200);
        });

        modelBuilder.Entity<TChiTietHdb>(entity =>
        {
            entity.HasKey(e => new { e.SoHdb, e.MaSach });

            entity.ToTable("tChiTietHDB");

            entity.Property(e => e.SoHdb)
                .HasMaxLength(10)
                .HasColumnName("SoHDB");
            entity.Property(e => e.MaSach).HasMaxLength(10);
            entity.Property(e => e.KhuyenMai).HasMaxLength(100);
            entity.Property(e => e.Slban).HasColumnName("SLBan");

            entity.HasOne(d => d.MaSachNavigation).WithMany(p => p.TChiTietHdbs)
                .HasForeignKey(d => d.MaSach)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tChiTietHDB_tSach");

            entity.HasOne(d => d.SoHdbNavigation).WithMany(p => p.TChiTietHdbs)
                .HasForeignKey(d => d.SoHdb)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tChiTietHDB_tHoaDonBan");
        });

        modelBuilder.Entity<TChiTietHdn>(entity =>
        {
            entity.HasKey(e => new { e.SoHdn, e.MaSach });

            entity.ToTable("tChiTietHDN");

            entity.Property(e => e.SoHdn)
                .HasMaxLength(10)
                .HasColumnName("SoHDN");
            entity.Property(e => e.MaSach).HasMaxLength(10);
            entity.Property(e => e.KhuyenMai).HasMaxLength(100);
            entity.Property(e => e.Slnhap).HasColumnName("SLNhap");

            entity.HasOne(d => d.MaSachNavigation).WithMany(p => p.TChiTietHdns)
                .HasForeignKey(d => d.MaSach)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tChiTietHDN_tSach");

            entity.HasOne(d => d.SoHdnNavigation).WithMany(p => p.TChiTietHdns)
                .HasForeignKey(d => d.SoHdn)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tChiTietHDN_tHoaDonNhap");
        });

        modelBuilder.Entity<THoaDonBan>(entity =>
        {
            entity.HasKey(e => e.SoHdb);

            entity.ToTable("tHoaDonBan", tb => tb.HasTrigger("cau_3"));

            entity.Property(e => e.SoHdb)
                .HasMaxLength(10)
                .HasColumnName("SoHDB");
            entity.Property(e => e.MaKh)
                .HasMaxLength(10)
                .HasColumnName("MaKH");
            entity.Property(e => e.MaNv)
                .HasMaxLength(10)
                .HasColumnName("MaNV");
            entity.Property(e => e.NgayBan).HasColumnType("datetime");

            entity.HasOne(d => d.MaKhNavigation).WithMany(p => p.THoaDonBans)
                .HasForeignKey(d => d.MaKh)
                .HasConstraintName("FK_tHoaDonBan_tKhachHang");

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.THoaDonBans)
                .HasForeignKey(d => d.MaNv)
                .HasConstraintName("FK_tHoaDonBan_tNhanVien");
        });

        modelBuilder.Entity<THoaDonNhap>(entity =>
        {
            entity.HasKey(e => e.SoHdn);

            entity.ToTable("tHoaDonNhap");

            entity.Property(e => e.SoHdn)
                .HasMaxLength(10)
                .HasColumnName("SoHDN");
            entity.Property(e => e.MaNcc)
                .HasMaxLength(10)
                .HasColumnName("MaNCC");
            entity.Property(e => e.MaNv)
                .HasMaxLength(10)
                .HasColumnName("MaNV");
            entity.Property(e => e.NgayNhap).HasColumnType("datetime");

            entity.HasOne(d => d.MaNccNavigation).WithMany(p => p.THoaDonNhaps)
                .HasForeignKey(d => d.MaNcc)
                .HasConstraintName("FK_tHoaDonNhap_tNhaCungCap");

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.THoaDonNhaps)
                .HasForeignKey(d => d.MaNv)
                .HasConstraintName("FK_tHoaDonNhap_tNhanVien");
        });

        modelBuilder.Entity<TKhachHang>(entity =>
        {
            entity.HasKey(e => e.MaKh);

            entity.ToTable("tKhachHang");

            entity.Property(e => e.MaKh)
                .HasMaxLength(10)
                .HasColumnName("MaKH");
            entity.Property(e => e.DiaChi).HasMaxLength(150);
            entity.Property(e => e.DienThoai).HasMaxLength(15);
            entity.Property(e => e.Slhoadonban)
                .HasDefaultValue(0)
                .HasColumnName("SLHOADONBAN");
            entity.Property(e => e.Sluonghoadonban)
                .HasDefaultValue(0)
                .HasColumnName("SLUONGHOADONBAN");
            entity.Property(e => e.Soluonghoadon)
                .HasDefaultValue(0)
                .HasColumnName("SOLUONGHOADON");
            entity.Property(e => e.TenKh)
                .HasMaxLength(50)
                .HasColumnName("TenKH");
            entity.Property(e => e.TongTienTieuDung)
                .HasDefaultValue(0m)
                .HasColumnType("money");
        });

        modelBuilder.Entity<TNhaCungCap>(entity =>
        {
            entity.HasKey(e => e.MaNcc);

            entity.ToTable("tNhaCungCap");

            entity.Property(e => e.MaNcc)
                .HasMaxLength(10)
                .HasColumnName("MaNCC");
            entity.Property(e => e.TenNcc)
                .HasMaxLength(200)
                .HasColumnName("TenNCC");
        });

        modelBuilder.Entity<TNhaXuatBan>(entity =>
        {
            entity.HasKey(e => e.MaNxb);

            entity.ToTable("tNhaXuatBan");

            entity.Property(e => e.MaNxb)
                .HasMaxLength(10)
                .HasColumnName("MaNXB");
            entity.Property(e => e.TenNxb)
                .HasMaxLength(100)
                .HasColumnName("TenNXB");
        });

        modelBuilder.Entity<TNhanVien>(entity =>
        {
            entity.HasKey(e => e.MaNv);

            entity.ToTable("tNhanVien");

            entity.Property(e => e.MaNv)
                .HasMaxLength(10)
                .HasColumnName("MaNV");
            entity.Property(e => e.DiaChi).HasMaxLength(150);
            entity.Property(e => e.DienThoai).HasMaxLength(15);
            entity.Property(e => e.GioiTinh).HasMaxLength(5);
            entity.Property(e => e.NgaySinh).HasColumnType("datetime");
            entity.Property(e => e.TenNv)
                .HasMaxLength(50)
                .HasColumnName("TenNV");
        });

        modelBuilder.Entity<TSach>(entity =>
        {
            entity.HasKey(e => e.MaSach);

            entity.ToTable("tSach");

            entity.Property(e => e.MaSach).HasMaxLength(10);
            entity.Property(e => e.Anh).HasColumnType("image");
            entity.Property(e => e.DonGiaBan).HasColumnType("money");
            entity.Property(e => e.DonGiaNhap).HasColumnType("money");
            entity.Property(e => e.MaNxb)
                .HasMaxLength(10)
                .HasColumnName("MaNXB");
            entity.Property(e => e.MaTheLoai).HasMaxLength(10);
            entity.Property(e => e.TacGia).HasMaxLength(150);
            entity.Property(e => e.TenSach).HasMaxLength(200);
            entity.Property(e => e.TrongLuong).HasMaxLength(50);

            entity.HasOne(d => d.MaNxbNavigation).WithMany(p => p.TSaches)
                .HasForeignKey(d => d.MaNxb)
                .HasConstraintName("FK_tSach_tNhaXuatBan");

            entity.HasOne(d => d.MaTheLoaiNavigation).WithMany(p => p.TSaches)
                .HasForeignKey(d => d.MaTheLoai)
                .HasConstraintName("FK_tSach_tTheLoai");
        });

        modelBuilder.Entity<TTheLoai>(entity =>
        {
            entity.HasKey(e => e.MaTheLoai);

            entity.ToTable("tTheLoai");

            entity.Property(e => e.MaTheLoai).HasMaxLength(10);
            entity.Property(e => e.TenTheLoai).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
