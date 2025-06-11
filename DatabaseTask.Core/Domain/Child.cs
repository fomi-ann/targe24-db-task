using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Child
    {
        [Key]
        public int Id { get; set; }

        // FK
        public required int EmployeeId { get; set; }
        public required Employee Employee { get; set; }

        public DateTime BirthDate { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
    }
}
