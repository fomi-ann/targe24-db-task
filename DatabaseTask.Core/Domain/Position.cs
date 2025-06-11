using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Position
    {
        [Key]
        public int Id { get; set; }

        public string? Description { get; set; }
        public required string AccessId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? PositionDisabledDate { get; set; }

        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
