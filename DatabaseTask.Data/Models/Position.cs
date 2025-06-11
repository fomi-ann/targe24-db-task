using System;
using System.Collections.Generic;

namespace DatabaseTask.Data.Models;

public partial class Position
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public string AccessId { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public DateTime? PositionDisabledDate { get; set; }

    public int? AccessId1 { get; set; }

    public virtual AccessLevel? AccessId1Navigation { get; set; }

    public virtual ICollection<Employee1> Employee1s { get; set; } = new List<Employee1>();
}
