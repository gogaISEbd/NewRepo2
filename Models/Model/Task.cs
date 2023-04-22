using System;
using System.Collections.Generic;

namespace Models.Model;

public partial class Task
{
    public int Id { get; set; }

    public int? StaffId { get; set; }

    public string? Task1 { get; set; }

    public virtual Staff? Staff { get; set; }
}
