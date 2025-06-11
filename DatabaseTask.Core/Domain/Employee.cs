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

