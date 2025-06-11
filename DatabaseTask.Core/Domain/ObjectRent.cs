using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class ObjectRent
    {
        [Key]
        public int Id { get; set; }

        // FK
        public required int EmployeeId { get; set; }
        public required Employee Employee { get; set; }

        // FK
        public int DeviceId { get; set; }
        public required Devices Device { get; set; }

        public DateTime GrantDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
