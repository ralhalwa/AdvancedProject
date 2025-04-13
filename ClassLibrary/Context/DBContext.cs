﻿using System;
using System.Collections.Generic;
using ClassLibrary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.Graph.Models;
using User = ClassLibrary.Models.User;


namespace ClassLibrary.Persistence;

public partial class DBContext : DbContext
{
    public DBContext()
    {
    }

    public DBContext(DbContextOptions<DBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AvailableStatus> AvailableStatuses { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<ConditionStatus> ConditionStatuses { get; set; }

    public virtual DbSet<Document> Documents { get; set; }

    public virtual DbSet<DocumentType> DocumentTypes { get; set; }

    public virtual DbSet<Equipment> Equipment { get; set; }

    public virtual DbSet<FeedBack> FeedBacks { get; set; }

    public virtual DbSet<FeedBack1> FeedBacks1 { get; set; }

    public virtual DbSet<Log> Logs { get; set; }

    public virtual DbSet<Notification> Notifications { get; set; }

    public virtual DbSet<NotificationType> NotificationTypes { get; set; }

    public virtual DbSet<PaymentStatus> PaymentStatuses { get; set; }

    public virtual DbSet<ProductStatus> ProductStatuses { get; set; }

    public virtual DbSet<RentalRequest> RentalRequests { get; set; }

    public virtual DbSet<RentalStatus> RentalStatuses { get; set; }

    public virtual DbSet<RentalTransaction> RentalTransactions { get; set; }

    public virtual DbSet<ReturnRecord> ReturnRecords { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserRole> UserRoles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=NewDB;Trusted_Connection=True;");
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<UserRole>().HasData(
            new UserRole { Id = 1, Role = "Admin" },
            new UserRole { Id = 2, Role = "Manager" },
            new UserRole { Id = 3, Role = "Customer" }
        );
        modelBuilder.Entity<ConditionStatus>().HasData(
             new ConditionStatus { Id = 1, Status = "New" },
             new ConditionStatus { Id = 2, Status = "Good" },
            new ConditionStatus { Id = 3, Status = "Damaged" },
             new ConditionStatus { Id = 4, Status = "Refurbished" }
        );
        modelBuilder.Entity<AvailableStatus>().HasData(
            new AvailableStatus { Id = 1, Status = "Available" },
            new AvailableStatus { Id = 2, Status = "Unavailable" },
            new AvailableStatus { Id = 3, Status = "Under Maintenance" }
        );
        modelBuilder.Entity<Category>().HasData(
         new Category { Id = 1, Name = "Power Tools" },
         new Category { Id = 2, Name = "Cameras" },
         new Category { Id = 3, Name = "Construction" },
         new Category { Id = 4, Name = "Event Supplies" }
        );
        modelBuilder.Entity<Equipment>().HasData(
            new Equipment
            {
                Id = 1,
                Name = "Mariam",
                Description = "Sample equipment description",
                CategoryId = 1,
                Price = 100.00m,
                AvailableId = 1,
                ConditionId = 1,
                Image = new byte[0] // Empty byte array; you can replace this with actual image data
            }
        );


        modelBuilder.Entity<Document>(entity =>
        {
            entity.HasOne(d => d.DocumentTypeNavigation).WithMany(p => p.Documents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Document_Document_Type");

            entity.HasOne(d => d.User).WithMany(p => p.Documents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Document_User");
        });

        modelBuilder.Entity<Equipment>(entity =>
        {
            entity.HasOne(d => d.Available).WithMany(p => p.Equipment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Equipment_Available_Status");

            entity.HasOne(d => d.Category).WithMany(p => p.Equipment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Equipment_Category");

            entity.HasOne(d => d.Condition).WithMany(p => p.Equipment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Equipment_Condition_Status");
        });

        modelBuilder.Entity<FeedBack>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Table2");

            entity.HasOne(d => d.EquipmentNavigation).WithMany(p => p.FeedBacks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FeedBack_Equipment");

            entity.HasOne(d => d.User).WithMany(p => p.FeedBacks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FeedBack_User");
        });

        modelBuilder.Entity<Log>(entity =>
        {
            entity.HasOne(d => d.User).WithMany(p => p.Logs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Log_User");
        });

        modelBuilder.Entity<Notification>(entity =>
        {
            entity.HasOne(d => d.NotificationType).WithMany(p => p.Notifications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Notification_Notification_Type");

            entity.HasOne(d => d.User).WithMany(p => p.Notifications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Notification_User");
        });

        modelBuilder.Entity<RentalRequest>(entity =>
        {
            entity.HasOne(d => d.Equipment).WithMany(p => p.RentalRequests)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Rental_Request_Equipment");

            entity.HasOne(d => d.RentalStatusNavigation).WithMany(p => p.RentalRequests)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Rental_Request_Product_Status");

            entity.HasOne(d => d.RentalStatus1).WithMany(p => p.RentalRequests)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Rental_Request_Rental_Status");
        });

        modelBuilder.Entity<RentalTransaction>(entity =>
        {
            entity.HasOne(d => d.PaymentStatusNavigation).WithMany(p => p.RentalTransactions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Rental_Transaction_Payment_Status");

            entity.HasOne(d => d.RentalStatusNavigation).WithMany(p => p.RentalTransactions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Rental_Transaction_Rental_Status");

            entity.HasOne(d => d.User).WithMany(p => p.RentalTransactions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Rental_Transaction_User");
        });

        modelBuilder.Entity<ReturnRecord>(entity =>
        {
            entity.HasOne(d => d.ConditionNavigation).WithMany(p => p.ReturnRecords)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Return_Record_Condition_Status");

            entity.HasOne(d => d.EquipmentNavigation).WithMany(p => p.ReturnRecords)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Return_Record_Equipment");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_User_User_Role");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
