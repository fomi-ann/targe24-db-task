using System;
using System.Collections.Generic;

namespace DatabaseTask.Data.Models;

public partial class HealthCheck
{
    public int Id { get; set; }

    public int EmployeeId { get; set; }

    public DateTime LastCheckDate { get; set; }

    public DateTime NextCheckDate { get; set; }

    public bool IsHealthy { get; set; }

    public virtual Employee1 Employee { get; set; } = null!;
}
