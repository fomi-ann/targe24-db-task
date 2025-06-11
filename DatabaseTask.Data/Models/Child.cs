using System;
using System.Collections.Generic;

namespace DatabaseTask.Data.Models;

public partial class Child
{
    public int Id { get; set; }

    public int EmployeeId { get; set; }

    public DateTime BirthDate { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public virtual Employee1 Employee { get; set; } = null!;
}
