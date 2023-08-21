using System;
using System.Collections.Generic;

namespace Models.Model;

public partial class MainOperation
{
    public int Id { get; set; }

    public DateOnly? Date { get; set; }

    public DateOnly? DateStart { get; set; }

    public DateOnly? DateEnd { get; set; }

    public decimal? Cost { get; set; }
    public decimal? Payed { get; set; }

    public int? ClientId { get; set; }

    public int? RoomsId { get; set; }
    public bool? Condit { get; set; }

    public virtual Client? Client { get; set; }

    public virtual ICollection<JurnalProvodok> JurnalProvodoks { get; } = new List<JurnalProvodok>();

    public virtual Room? Rooms { get; set; }
}
