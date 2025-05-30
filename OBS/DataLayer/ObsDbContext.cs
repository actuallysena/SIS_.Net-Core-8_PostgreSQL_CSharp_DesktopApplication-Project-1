﻿using System;
using System.Collections.Generic;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataLayer;

public partial class ObsDbContext : DbContext
{
    public ObsDbContext()
    {
    }

    public ObsDbContext(DbContextOptions<ObsDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Akademisyen> Akademisyens { get; set; }

    public virtual DbSet<Bolumler> Bolumlers { get; set; }

    public virtual DbSet<Dersler> Derslers { get; set; }

    public virtual DbSet<Fakulteler> Fakultelers { get; set; }

    public virtual DbSet<Ogrenci> Ogrencis { get; set; }

    public virtual DbSet<OgrenciDer> OgrenciDers { get; set; }

    public virtual DbSet<Personel> Personels { get; set; }

    public virtual DbSet<Sinif> Sinifs { get; set; }

    public virtual DbSet<Universite> Universites { get; set; }

    public virtual DbSet<Yonetici> Yoneticis { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Database=obs_db;Username=postgres;Password=123456");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Akademisyen>(entity =>
        {
            entity.HasKey(e => e.AkademisyenId).HasName("akademisyen_pkey");

            entity.ToTable("akademisyen");

            entity.HasIndex(e => e.AkademisyenMail, "akademisyen_akademisyen_mail_key").IsUnique();

            entity.HasIndex(e => e.AkademisyenTc, "akademisyen_akademisyen_tc_key").IsUnique();

            entity.Property(e => e.AkademisyenId)
                .ValueGeneratedNever()
                .HasColumnName("akademisyen_id");
            entity.Property(e => e.AkademisyenAdi)
                .HasMaxLength(50)
                .HasColumnName("akademisyen_adi");
            entity.Property(e => e.AkademisyenMail)
                .HasMaxLength(255)
                .HasColumnName("akademisyen_mail");
            entity.Property(e => e.AkademisyenSifre)
                .HasMaxLength(255)
                .HasColumnName("akademisyen_sifre");
            entity.Property(e => e.AkademisyenSoyadi)
                .HasMaxLength(50)
                .HasColumnName("akademisyen_soyadi");
            entity.Property(e => e.AkademisyenTc)
                .HasMaxLength(11)
                .HasColumnName("akademisyen_tc");
            entity.Property(e => e.AkademisyenTel)
                .HasMaxLength(15)
                .HasColumnName("akademisyen_tel");
            entity.Property(e => e.FkBolumId).HasColumnName("fk_bolum_id");

            entity.HasOne(d => d.FkBolum).WithMany(p => p.Akademisyens)
                .HasForeignKey(d => d.FkBolumId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("akademisyen_fk_bolum_id_fkey");
        });

        modelBuilder.Entity<Bolumler>(entity =>
        {
            entity.HasKey(e => e.BolumId).HasName("bolumler_pkey");

            entity.ToTable("bolumler");

            entity.Property(e => e.BolumId).HasColumnName("bolum_id");
            entity.Property(e => e.Baskan)
                .HasDefaultValue(0)
                .HasColumnName("baskan");
            entity.Property(e => e.BolumAdi)
                .HasMaxLength(255)
                .HasColumnName("bolum_adi");
            entity.Property(e => e.FakId).HasColumnName("fak_id");
            entity.Property(e => e.FkSekreter).HasColumnName("fk_sekreter");

            entity.HasOne(d => d.Fak).WithMany(p => p.Bolumlers)
                .HasForeignKey(d => d.FakId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("bolumler_fk_fakid_fkey");
        });

        modelBuilder.Entity<Dersler>(entity =>
        {
            entity.HasKey(e => e.DersId).HasName("dersler_pkey");

            entity.ToTable("dersler");

            entity.Property(e => e.DersId).HasColumnName("ders_id");
            entity.Property(e => e.Akts).HasColumnName("akts");
            entity.Property(e => e.DersAdi)
                .HasMaxLength(255)
                .HasColumnName("ders_adi");
            entity.Property(e => e.DersDonem)
                .HasMaxLength(50)
                .HasColumnName("ders_donem");
            entity.Property(e => e.Derslik)
                .HasMaxLength(50)
                .HasColumnName("derslik");
            entity.Property(e => e.FkBolm).HasColumnName("fk_bolm");
            entity.Property(e => e.FkSnf).HasColumnName("fk_snf");
            entity.Property(e => e.Kredi).HasColumnName("kredi");

            entity.HasOne(d => d.Sinif).WithMany(p => p.Derslers)
                .HasForeignKey(d => new { d.FkSnf, d.FkBolm })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("dersler_fk_snf_fk_bolm_fkey");
        });

        modelBuilder.Entity<Fakulteler>(entity =>
        {
            entity.HasKey(e => e.FakId).HasName("fakulteler_pkey");

            entity.ToTable("fakulteler");

            entity.Property(e => e.FakId).HasColumnName("fak_id");
            entity.Property(e => e.Dekan).HasColumnName("dekan");
            entity.Property(e => e.FakAdi)
                .HasMaxLength(255)
                .HasColumnName("fak_adi");
            entity.Property(e => e.FkUniId).HasColumnName("fk_uni_id");

            entity.HasOne(d => d.DekanNavigation).WithMany(p => p.Fakultelers)
                .HasForeignKey(d => d.Dekan)
                .HasConstraintName("fakulteler_dekan_fkey");

            entity.HasOne(d => d.FkUni).WithMany(p => p.Fakultelers)
                .HasForeignKey(d => d.FkUniId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fakulteler_fk_uni_id_fkey");
        });

        modelBuilder.Entity<Ogrenci>(entity =>
        {
            entity.HasKey(e => e.OgrNo).HasName("ogrenci_pkey");

            entity.ToTable("ogrenci");

            entity.HasIndex(e => e.OgrMail, "ogrenci_ogr_mail_key").IsUnique();

            entity.HasIndex(e => e.OgrTc, "ogrenci_ogr_tc_key").IsUnique();

            entity.Property(e => e.OgrNo)
                .ValueGeneratedNever()
                .HasColumnName("ogr_no");
            entity.Property(e => e.Danisman).HasColumnName("danisman");
            entity.Property(e => e.FkBolmm).HasColumnName("fk_bolmm");
            entity.Property(e => e.FkSnff).HasColumnName("fk_snff");
            entity.Property(e => e.OgrAdi)
                .HasMaxLength(255)
                .HasColumnName("ogr_adi");
            entity.Property(e => e.OgrDurum).HasColumnName("ogr_durum");
            entity.Property(e => e.OgrMail)
                .HasMaxLength(255)
                .HasColumnName("ogr_mail");
            entity.Property(e => e.OgrOgretim)
                .HasMaxLength(2)
                .HasColumnName("ogr_ogretim");
            entity.Property(e => e.OgrProgram)
                .HasMaxLength(255)
                .HasColumnName("ogr_program");
            entity.Property(e => e.OgrSifre)
                .HasMaxLength(255)
                .HasColumnName("ogr_sifre");
            entity.Property(e => e.OgrSoyadi)
                .HasMaxLength(255)
                .HasColumnName("ogr_soyadi");
            entity.Property(e => e.OgrTc)
                .HasMaxLength(11)
                .HasColumnName("ogr_tc");
            entity.Property(e => e.OgrTel)
                .HasMaxLength(15)
                .HasColumnName("ogr_tel");

            entity.HasOne(d => d.Sinif).WithMany(p => p.Ogrencis)
                .HasForeignKey(d => new { d.FkSnff, d.FkBolmm })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ogrenci_fk_snff_fk_bolmm_fkey");
        });

        modelBuilder.Entity<OgrenciDer>(entity =>
        {
            entity.HasKey(e => new { e.OgrNo, e.DersId, e.Donemkodu }).HasName("ogrenci_ders_pkey");

            entity.ToTable("ogrenci_ders");

            entity.Property(e => e.OgrNo).HasColumnName("ogr_no");
            entity.Property(e => e.DersId).HasColumnName("ders_id");
            entity.Property(e => e.Donemkodu)
                .HasMaxLength(20)
                .HasColumnName("donemkodu");
            entity.Property(e => e.Butunlemenotu)
                .HasPrecision(5, 2)
                .HasColumnName("butunlemenotu");
            entity.Property(e => e.Devamsizlik).HasColumnName("devamsizlik");
            entity.Property(e => e.Devamzorunlulugu)
                .HasDefaultValue(true)
                .HasColumnName("devamzorunlulugu");
            entity.Property(e => e.Finalnotu)
                .HasPrecision(5, 2)
                .HasColumnName("finalnotu");
            entity.Property(e => e.Gectimi)
                .HasDefaultValue(false)
                .HasColumnName("gectimi");
            entity.Property(e => e.Harfnotu)
                .HasMaxLength(2)
                .HasColumnName("harfnotu");
            entity.Property(e => e.Ortalama)
                .HasPrecision(5, 2)
                .HasColumnName("ortalama");
            entity.Property(e => e.Vizenotu)
                .HasPrecision(5, 2)
                .HasColumnName("vizenotu");

            entity.HasOne(d => d.Ders).WithMany(p => p.OgrenciDers)
                .HasForeignKey(d => d.DersId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ogrenci_ders_ders_id_fkey");

            entity.HasOne(d => d.OgrNoNavigation).WithMany(p => p.OgrenciDers)
                .HasForeignKey(d => d.OgrNo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ogrenci_ders_ogr_no_fkey");
        });

        modelBuilder.Entity<Personel>(entity =>
        {
            entity.HasKey(e => e.PersId).HasName("personel_pkey");

            entity.ToTable("personel");

            entity.Property(e => e.PersId)
                .ValueGeneratedNever()
                .HasColumnName("pers_id");
            entity.Property(e => e.PersAdi)
                .HasMaxLength(255)
                .HasColumnName("pers_adi");
            entity.Property(e => e.PersGorev)
                .HasMaxLength(255)
                .HasColumnName("pers_gorev");
            entity.Property(e => e.PersSifre)
                .HasMaxLength(255)
                .HasColumnName("pers_sifre");
            entity.Property(e => e.PersSoyadi)
                .HasMaxLength(255)
                .HasColumnName("pers_soyadi");
        });

        modelBuilder.Entity<Sinif>(entity =>
        {
            entity.HasKey(e => new { e.Snf, e.FkBolId }).HasName("pk_sinif_id");

            entity.ToTable("sinif");

            entity.Property(e => e.Snf).HasColumnName("snf");
            entity.Property(e => e.FkBolId).HasColumnName("fk_bol_id");

            entity.HasOne(d => d.FkBol).WithMany(p => p.Sinifs)
                .HasForeignKey(d => d.FkBolId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("sinif_fk_bol_id_fkey");
        });

        modelBuilder.Entity<Universite>(entity =>
        {
            entity.HasKey(e => e.UniId).HasName("universite_pkey");

            entity.ToTable("universite");

            entity.Property(e => e.UniId).HasColumnName("uni_id");
            entity.Property(e => e.Rektor).HasColumnName("rektor");
            entity.Property(e => e.UniAdi)
                .HasMaxLength(255)
                .HasColumnName("uni_adi");
        });

        modelBuilder.Entity<Yonetici>(entity =>
        {
            entity.HasKey(e => e.YoneticiId).HasName("yonetici_pkey");

            entity.ToTable("yonetici");

            entity.Property(e => e.YoneticiId).HasColumnName("yonetici_id");
            entity.Property(e => e.Adi)
                .HasMaxLength(255)
                .HasColumnName("adi");
            entity.Property(e => e.Sifre)
                .HasMaxLength(255)
                .HasColumnName("sifre");
            entity.Property(e => e.Soyadi)
                .HasMaxLength(255)
                .HasColumnName("soyadi");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
