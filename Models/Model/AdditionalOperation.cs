using System;
using System.Collections.Generic;

namespace Models.Model;

public partial class AdditionalOperation
{
    public int Id { get; set; }

    public DateOnly? Date { get; set; }

    public decimal? Cost { get; set; }

    public int? ClientId { get; set; }

    public int? AdditionalId { get; set; }

    public virtual AdditionalService? Additional { get; set; }

    public virtual Client? Client { get; set; }

    public virtual ICollection<JurnalProvodok> JurnalProvodoks { get; } = new List<JurnalProvodok>();
}
