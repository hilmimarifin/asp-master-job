using System;
using System.Collections.Generic;

namespace asp_master_job.Entities;

public partial class Jobtitle
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
