using System;
using System.Collections.Generic;

namespace DatabaseTask.Data.Models;

public partial class WorkTopic
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Hint> Hints { get; set; } = new List<Hint>();

    public virtual ICollection<Request> Requests { get; set; } = new List<Request>();
}
