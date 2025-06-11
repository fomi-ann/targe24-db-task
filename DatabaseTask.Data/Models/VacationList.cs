using System;
using System.Collections.Generic;

namespace DatabaseTask.Data.Models;

public partial class VacationList
{
    public int Id { get; set; }

    public int EmployeeId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public int? ApprovedByEmployeeId { get; set; }

    public DateTime? DateApproved { get; set; }

    public byte TotalDays { get; set; }

    public byte VacationalDaysUsed { get; set; }

    public byte VacationalDaysRemaining { get; set; }

    public virtual Employee1? ApprovedByEmployee { get; set; }

    public virtual Employee1 Employee { get; set; } = null!;
}
