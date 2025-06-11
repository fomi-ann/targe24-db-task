using System;
using System.Collections.Generic;

namespace DatabaseTask.Data.Models;

public partial class SickLeaf
{
    public int Id { get; set; }

    public int EmployeeId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public bool IsActive { get; set; }

    public virtual Employee1 Employee { get; set; } = null!;
}
