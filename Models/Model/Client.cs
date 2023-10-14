using System;
using System.Collections.Generic;

namespace Models.Model;

public partial class Client
{
    public int Id { get; set; }

    public string? Fio { get; set; }

    public int? Age { get; set; }

    public string? Passport { get; set; }
    public string? Phone { get; set; }

    public virtual ICollection<AdditionalOperation> AdditionalOperations { get; } = new List<AdditionalOperation>();

    public virtual ICollection<MainOperation> MainOperations { get; } = new List<MainOperation>();
}
