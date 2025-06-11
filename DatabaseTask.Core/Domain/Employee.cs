using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;


namespace DatabaseTask.Core.Domain
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public string? Phone {  get; set; }
        public string? Email { get; set; }
        public required string PersonalCode { get; set; }
        
        // FK
        public int AddressId { get; set; }
        public required Address Address { get; set; }

        // FK
        public int PositionId { get; set; }
        public required Position Position { get; set; }

        public ICollection<SickLeave> SickLeaves { get; set; } = new List<SickLeave>();
        public ICollection<Salary> Salaries { get; set; } = new List<Salary>();
        public ICollection<VacationList> VacationLists { get; set; } = new List<VacationList>();
        public ICollection<HealthCheck> HealthChecks { get; set; } = new List<HealthCheck>();
        public ICollection<Child> Children { get; set; } = new List<Child>();

        [InverseProperty("Creator")]
        public ICollection<Hint> CreatedHints { get; set; } = new List<Hint>();
        [InverseProperty("Creator")]
        public ICollection<Request> CreatedRequests { get; set; } = new List<Request>();

        [InverseProperty("ApprovedByEmployee")]
        public ICollection<VacationList> ApprovedVacationLists { get; set; } = new List<VacationList>();
        public ICollection<JobHistory> JobHistoryEntries { get; set; } = new List<JobHistory>();
        public ICollection<ObjectRent> ObjectGrants { get; set; } = new List<ObjectRent>();
    }


    //public enum Gender
    //{
    //    Female, 
    //    Male,
    //    Unknown
    //}

    //public class Children
    //{
    //    [Key]
    //    public Guid Id { get; set; }

    //    public string FirstName { get; set; }
    //}
}

