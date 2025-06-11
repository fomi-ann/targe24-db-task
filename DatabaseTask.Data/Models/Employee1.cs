using System;
using System.Collections.Generic;

namespace DatabaseTask.Data.Models;

public partial class Employee1
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string PersonalCode { get; set; } = null!;

    public int AddressId { get; set; }

    public int PositionId { get; set; }

    public virtual Address Address { get; set; } = null!;

    public virtual ICollection<Child> Children { get; set; } = new List<Child>();

    public virtual ICollection<HealthCheck> HealthChecks { get; set; } = new List<HealthCheck>();

    public virtual ICollection<Hint> Hints { get; set; } = new List<Hint>();

    public virtual ICollection<JobHistoryEntry> JobHistoryEntries { get; set; } = new List<JobHistoryEntry>();

    public virtual ICollection<ObjectRent> ObjectRents { get; set; } = new List<ObjectRent>();

    public virtual Position Position { get; set; } = null!;

    public virtual ICollection<Request> Requests { get; set; } = new List<Request>();

    public virtual ICollection<Salary> Salaries { get; set; } = new List<Salary>();

    public virtual ICollection<SickLeaf> SickLeaves { get; set; } = new List<SickLeaf>();

    public virtual ICollection<VacationList> VacationListApprovedByEmployees { get; set; } = new List<VacationList>();

    public virtual ICollection<VacationList> VacationListEmployees { get; set; } = new List<VacationList>();
}
