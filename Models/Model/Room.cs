using System;
using System.Collections.Generic;

namespace Models.Model;

public partial class Room
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public decimal? Price { get; set; }
    public decimal? Size{ get; set; }
    public string? Location { get; set; }
    public int? Rooms { get; set; }


    public virtual ICollection<MainOperation> MainOperations { get; } = new List<MainOperation>();
}
