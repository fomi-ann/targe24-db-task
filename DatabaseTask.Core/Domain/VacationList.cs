using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class VacationList
    {
        [Key]
        public int Id { get; set; }

        // FK
        public required int EmployeeId { get; set; }
        public required Employee Employee { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // FK
        public int? ApprovedByEmployeeID { get; set; }
        public required Employee ApprovedByEmployee { get; set; }

        public DateTime? DateApproved { get; set; }
        public byte TotalDays { get; set; }
        public byte VacationalDaysUsed { get; set; }
        public byte VacationalDaysRemaining { get; set; }
    }
}
