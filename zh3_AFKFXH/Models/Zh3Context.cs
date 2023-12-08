using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace zh3_AFKFXH.Models;

public partial class Zh3Context : DbContext
{
    public Zh3Context()
    {
    }

    public Zh3Context(DbContextOptions<Zh3Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Csapat> Csapats { get; set; }

    public virtual DbSet<Jateko> Jatekos { get; set; }

    public virtual DbSet<Mecc> Meccs { get; set; }

    public virtual DbSet<Nap> Naps { get; set; }

    public virtual DbSet<Stadion> Stadions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=softengzh3.database.windows.net;Initial Catalog=zh3;User ID=hallgato;Password=Password123");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Csapat>(entity =>
        {
            entity.HasKey(e => e.CsapatId).HasName("PK__csapat__E72F362B70E18D10");

            entity.ToTable("csapat");

            entity.Property(e => e.CsapatId)
                .ValueGeneratedNever()
                .HasColumnName("csapat_id");
            entity.Property(e => e.AlakulasiEv).HasColumnName("alakulasi_ev");
            entity.Property(e => e.EdzoNev)
                .HasMaxLength(50)
                .HasColumnName("edzo_nev");
            entity.Property(e => e.Nev)
                .HasMaxLength(50)
                .HasColumnName("nev");
        });

        modelBuilder.Entity<Jateko>(entity =>
        {
            entity.HasKey(e => e.JatekosId).HasName("PK__jatekos__E50155B774F61AAD");

            entity.ToTable("jatekos");

            entity.Property(e => e.JatekosId)
                .ValueGeneratedNever()
                .HasColumnName("jatekos_id");
            entity.Property(e => e.CsapatId).HasColumnName("csapat_id");
            entity.Property(e => e.Mezszam).HasColumnName("mezszam");
            entity.Property(e => e.Nev)
                .HasMaxLength(50)
                .HasColumnName("nev");
            entity.Property(e => e.Poszt)
                .HasMaxLength(20)
                .HasColumnName("poszt");
            entity.Property(e => e.SzuletesiDatum)
                .HasColumnType("date")
                .HasColumnName("szuletesi_datum");

            entity.HasOne(d => d.Csapat).WithMany(p => p.Jatekos)
                .HasForeignKey(d => d.CsapatId)
                .HasConstraintName("FK__jatekos__csapat___656C112C");
        });

        modelBuilder.Entity<Mecc>(entity =>
        {
            entity.HasKey(e => e.MeccsId).HasName("PK__meccs__D8FA4B906AB10720");

            entity.ToTable("meccs");

            entity.Property(e => e.MeccsId)
                .ValueGeneratedNever()
                .HasColumnName("meccs_id");
            entity.Property(e => e.Csapat1).HasColumnName("csapat_1");
            entity.Property(e => e.Csapat2).HasColumnName("csapat_2");
            entity.Property(e => e.Eredmeny)
                .HasMaxLength(10)
                .HasColumnName("eredmeny");
            entity.Property(e => e.NapId).HasColumnName("nap_id");
            entity.Property(e => e.Nezoszam).HasColumnName("nezoszam");
            entity.Property(e => e.StadionId).HasColumnName("stadion_id");

            entity.HasOne(d => d.Csapat1Navigation).WithMany(p => p.MeccCsapat1Navigations)
                .HasForeignKey(d => d.Csapat1)
                .HasConstraintName("FK__meccs__csapat_1__68487DD7");

            entity.HasOne(d => d.Csapat2Navigation).WithMany(p => p.MeccCsapat2Navigations)
                .HasForeignKey(d => d.Csapat2)
                .HasConstraintName("FK__meccs__csapat_2__693CA210");

            entity.HasOne(d => d.Nap).WithMany(p => p.Meccs)
                .HasForeignKey(d => d.NapId)
                .HasConstraintName("FK__meccs__nap_id__6B24EA82");

            entity.HasOne(d => d.Stadion).WithMany(p => p.Meccs)
                .HasForeignKey(d => d.StadionId)
                .HasConstraintName("FK__meccs__stadion_i__6A30C649");
        });

        modelBuilder.Entity<Nap>(entity =>
        {
            entity.HasKey(e => e.NapId).HasName("PK__nap__984C593AEF8DDB00");

            entity.ToTable("nap");

            entity.Property(e => e.NapId)
                .ValueGeneratedNever()
                .HasColumnName("nap_id");
            entity.Property(e => e.Jegyar).HasColumnName("jegyar");
            entity.Property(e => e.Nev)
                .HasMaxLength(10)
                .HasColumnName("nev");
        });

        modelBuilder.Entity<Stadion>(entity =>
        {
            entity.HasKey(e => e.StadionId).HasName("PK__stadion__3EC28F0DA8F19518");

            entity.ToTable("stadion");

            entity.Property(e => e.StadionId)
                .ValueGeneratedNever()
                .HasColumnName("stadion_id");
            entity.Property(e => e.Ferohelyek).HasColumnName("ferohelyek");
            entity.Property(e => e.Varos)
                .HasMaxLength(20)
                .HasColumnName("varos");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
