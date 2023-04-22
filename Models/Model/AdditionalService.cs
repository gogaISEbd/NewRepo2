using System;
using System.Collections.Generic;

namespace Models.Model;

public partial class AdditionalService
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public decimal? Price { get; set; }

    public virtual ICollection<AdditionalOperation> AdditionalOperations { get; } = new List<AdditionalOperation>();
}
