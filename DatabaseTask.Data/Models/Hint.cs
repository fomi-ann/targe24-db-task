using System;
using System.Collections.Generic;

namespace DatabaseTask.Data.Models;

public partial class Hint
{
    public int Id { get; set; }

    public int WorkTopicId { get; set; }

    public int CreatorEmployeeId { get; set; }

    public int CreatorId { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? ReviewedDate { get; set; }

    public string? Description { get; set; }

    public virtual Employee1 Creator { get; set; } = null!;

    public virtual WorkTopic WorkTopic { get; set; } = null!;
}
