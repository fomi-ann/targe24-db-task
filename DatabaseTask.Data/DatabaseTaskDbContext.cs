using System.Net;
using Azure.Core;
using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Request = DatabaseTask.Core.Domain.Request;


namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<SickLeave> SickLeaves { get; set; }
        public DbSet<Salary> Salaries { get; set; }
        public DbSet<VacationList> VacationLists { get; set; }
        public DbSet<HealthCheck> HealthChecks { get; set; }
        public DbSet<Child> Children { get; set; }
        public DbSet<JobHistory> JobHistoryEntries { get; set; }
        public DbSet<WorkTopic> WorkTopics { get; set; }
        public DbSet<Hint> Hints { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Devices> Devices { get; set; }
        public DbSet<ObjectRent> ObjectRents { get; set; }
        public DbSet<Access> AccessLevels { get; set; }
    }
}
