using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class HealthCheck
    {
        [Key]
        public int Id { get; set; }

        // FK
        public required int EmployeeId { get; set; }
        public required Employee Employee { get; set; }

        public DateTime LastCheckDate { get; set; }
        public DateTime NextCheckDate { get; set; }
        public bool IsHealthy { get; set; }
    }
}
