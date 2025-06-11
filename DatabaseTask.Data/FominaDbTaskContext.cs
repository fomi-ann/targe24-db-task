using System;
using System.Collections.Generic;
using DatabaseTask.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Data;

public partial class FominaDbTaskContext : DbContext
{
    public FominaDbTaskContext()
    {
    }

    public FominaDbTaskContext(DbContextOptions<FominaDbTaskContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AccessLevel> AccessLevels { get; set; }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<Child> Children { get; set; }

    public virtual DbSet<Device> Devices { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Employee1> Employees1 { get; set; }

    public virtual DbSet<HealthCheck> HealthChecks { get; set; }

    public virtual DbSet<Hint> Hints { get; set; }

    public virtual DbSet<JobHistoryEntry> JobHistoryEntries { get; set; }

    public virtual DbSet<ObjectRent> ObjectRents { get; set; }

    public virtual DbSet<Position> Positions { get; set; }

    public virtual DbSet<Request> Requests { get; set; }

    public virtual DbSet<Salary> Salaries { get; set; }

    public virtual DbSet<SickLeaf> SickLeaves { get; set; }

    public virtual DbSet<VacationList> VacationLists { get; set; }

    public virtual DbSet<WorkTopic> WorkTopics { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=ALEX;Database=Fomina-db-task;Trusted_Connection=true;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Child>(entity =>
        {
            entity.HasIndex(e => e.EmployeeId, "IX_Children_EmployeeId");

            entity.HasOne(d => d.Employee).WithMany(p => p.Children).HasForeignKey(d => d.EmployeeId);
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.ToTable("Employee");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Employee1>(entity =>
        {
            entity.ToTable("Employees");

            entity.HasIndex(e => e.AddressId, "IX_Employees_AddressId");

            entity.HasIndex(e => e.PositionId, "IX_Employees_PositionId");

            entity.HasOne(d => d.Address).WithMany(p => p.Employee1s).HasForeignKey(d => d.AddressId);

            entity.HasOne(d => d.Position).WithMany(p => p.Employee1s).HasForeignKey(d => d.PositionId);
        });

        modelBuilder.Entity<HealthCheck>(entity =>
        {
            entity.HasIndex(e => e.EmployeeId, "IX_HealthChecks_EmployeeId");

            entity.HasOne(d => d.Employee).WithMany(p => p.HealthChecks).HasForeignKey(d => d.EmployeeId);
        });

        modelBuilder.Entity<Hint>(entity =>
        {
            entity.HasIndex(e => e.CreatorId, "IX_Hints_CreatorId");

            entity.HasIndex(e => e.WorkTopicId, "IX_Hints_WorkTopicId");

            entity.HasOne(d => d.Creator).WithMany(p => p.Hints).HasForeignKey(d => d.CreatorId);

            entity.HasOne(d => d.WorkTopic).WithMany(p => p.Hints).HasForeignKey(d => d.WorkTopicId);
        });

        modelBuilder.Entity<JobHistoryEntry>(entity =>
        {
            entity.HasIndex(e => e.EmployeeId, "IX_JobHistoryEntries_EmployeeId");

            entity.HasOne(d => d.Employee).WithMany(p => p.JobHistoryEntries).HasForeignKey(d => d.EmployeeId);
        });

        modelBuilder.Entity<ObjectRent>(entity =>
        {
            entity.HasIndex(e => e.DeviceId, "IX_ObjectRents_DeviceId");

            entity.HasIndex(e => e.EmployeeId, "IX_ObjectRents_EmployeeId");

            entity.HasOne(d => d.Device).WithMany(p => p.ObjectRents).HasForeignKey(d => d.DeviceId);

            entity.HasOne(d => d.Employee).WithMany(p => p.ObjectRents).HasForeignKey(d => d.EmployeeId);
        });

        modelBuilder.Entity<Position>(entity =>
        {
            entity.HasIndex(e => e.AccessId1, "IX_Positions_AccessId1");

            entity.HasOne(d => d.AccessId1Navigation).WithMany(p => p.Positions).HasForeignKey(d => d.AccessId1);
        });

        modelBuilder.Entity<Request>(entity =>
        {
            entity.HasIndex(e => e.CreatorId, "IX_Requests_CreatorId");

            entity.HasIndex(e => e.WorkTopicId, "IX_Requests_WorkTopicId");

            entity.HasOne(d => d.Creator).WithMany(p => p.Requests).HasForeignKey(d => d.CreatorId);

            entity.HasOne(d => d.WorkTopic).WithMany(p => p.Requests).HasForeignKey(d => d.WorkTopicId);
        });

        modelBuilder.Entity<Salary>(entity =>
        {
            entity.HasIndex(e => e.EmployeeId, "IX_Salaries_EmployeeId");

            entity.Property(e => e.EmployeeSalary).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Employee).WithMany(p => p.Salaries).HasForeignKey(d => d.EmployeeId);
        });

        modelBuilder.Entity<SickLeaf>(entity =>
        {
            entity.HasIndex(e => e.EmployeeId, "IX_SickLeaves_EmployeeId");

            entity.HasOne(d => d.Employee).WithMany(p => p.SickLeaves).HasForeignKey(d => d.EmployeeId);
        });

        modelBuilder.Entity<VacationList>(entity =>
        {
            entity.HasIndex(e => e.ApprovedByEmployeeId, "IX_VacationLists_ApprovedByEmployeeID");

            entity.HasIndex(e => e.EmployeeId, "IX_VacationLists_EmployeeId");

            entity.Property(e => e.ApprovedByEmployeeId).HasColumnName("ApprovedByEmployeeID");

            entity.HasOne(d => d.ApprovedByEmployee).WithMany(p => p.VacationListApprovedByEmployees).HasForeignKey(d => d.ApprovedByEmployeeId);

            entity.HasOne(d => d.Employee).WithMany(p => p.VacationListEmployees).HasForeignKey(d => d.EmployeeId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
