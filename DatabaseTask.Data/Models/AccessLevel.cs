using System;
using System.Collections.Generic;

namespace DatabaseTask.Data.Models;

public partial class AccessLevel
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public virtual ICollection<Position> Positions { get; set; } = new List<Position>();
}
