using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DotSoftSender.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CleanDatum> CleanData { get; set; }

    public virtual DbSet<MessageType> MessageTypes { get; set; }

    public virtual DbSet<Tmessage> Tmessages { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=dotsoft_sender;Username=postgres;Password=P@ssw0rd");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CleanDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("cleanData");
            
            entity.Property(e => e.Code)
                .HasMaxLength(255)
                .HasColumnName("code");
            entity.Property(e => e.Dob)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("DOB");
            entity.Property(e => e.DrNameAr)
                .HasMaxLength(255)
                .HasColumnName("drNameAr");
            entity.Property(e => e.DrNameEn)
                .HasMaxLength(255)
                .HasColumnName("drNameEn");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.Gender).HasMaxLength(255);
            entity.Property(e => e.IdDoctor).HasColumnName("idDoctor");
            entity.Property(e => e.Kaza)
                .HasMaxLength(255)
                .HasColumnName("kaza");
            entity.Property(e => e.MobileNumbers).HasMaxLength(255);
            entity.Property(e => e.Pc).HasColumnName("pc");
            entity.Property(e => e.PhoneNumbers).HasMaxLength(255);
            entity.Property(e => e.Printed).HasColumnName("printed");
            entity.Property(e => e.RegisterNumber).HasMaxLength(255);
            entity.Property(e => e.RegistrationDate).HasColumnType("timestamp without time zone");
            entity.Property(e => e.Rite)
                .HasMaxLength(255)
                .HasColumnName("rite");
            entity.Property(e => e.Spec).HasMaxLength(255);
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("type");
        });

        modelBuilder.Entity<MessageType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("messages_pkey");

            entity.ToTable("messageType");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MessType).HasColumnName("messType");
        });

        modelBuilder.Entity<Tmessage>(entity =>
        {
            entity.HasKey(e => e.IdDr).HasName("doctors_pkey");


            entity.ToTable("tmessages");
            entity.Property(e => e.DoctorId).HasColumnName("DoctorId");

            entity.HasOne(d => d.MsgType).WithMany(p => p.Tmessages)
                .HasForeignKey(d => d.MsgTypeId)
                .HasConstraintName("MsgTypeId");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
