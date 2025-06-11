using System;
using System.Collections.Generic;

namespace DatabaseTask.Data.Models;

public partial class Salary
{
    public int Id { get; set; }

    public int EmployeeId { get; set; }

    public decimal EmployeeSalary { get; set; }

    public DateTime StartDate { get; set; }

    public virtual Employee1 Employee { get; set; } = null!;
}
