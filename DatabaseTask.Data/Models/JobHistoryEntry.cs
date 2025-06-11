using System;
using System.Collections.Generic;

namespace DatabaseTask.Data.Models;

public partial class JobHistoryEntry
{
    public int Id { get; set; }

    public int EmployeeId { get; set; }

    public string Position { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public virtual Employee1 Employee { get; set; } = null!;
}
