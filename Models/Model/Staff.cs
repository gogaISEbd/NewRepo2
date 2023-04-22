using System;
using System.Collections.Generic;

namespace Models.Model;

public partial class Staff
{
    public int Id { get; set; }

    public string? Fio { get; set; }

    public string? Login { get; set; }

    public string? Password { get; set; }
    public string? Role { get; set; }

    public virtual ICollection<Task> Tasks { get; } = new List<Task>();
}
