using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Models.Model;

public partial class Task
{
    public int Id { get; set; }
    public DateTime Date { get; set; }

    public int? StaffId { get; set; }

    public string? Task1 { get; set; }
    public bool IsDone { get; set; }

    public virtual Staff? Staff { get; set; }
}
