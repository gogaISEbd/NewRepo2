using System;
using System.Collections.Generic;

namespace Models.Model;

public partial class Room
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public decimal? Price { get; set; }

    public virtual ICollection<MainOperation> MainOperations { get; } = new List<MainOperation>();
}
