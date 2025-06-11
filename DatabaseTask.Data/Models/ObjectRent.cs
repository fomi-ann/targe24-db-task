using System;
using System.Collections.Generic;

namespace DatabaseTask.Data.Models;

public partial class ObjectRent
{
    public int Id { get; set; }

    public int EmployeeId { get; set; }

    public int DeviceId { get; set; }

    public DateTime GrantDate { get; set; }

    public DateTime? ReturnDate { get; set; }

    public virtual Device Device { get; set; } = null!;

    public virtual Employee1 Employee { get; set; } = null!;
}
