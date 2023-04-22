using System;
using System.Collections.Generic;

namespace Models.Model;

public partial class JurnalProvodok
{
    public int Id { get; set; }

    public DateOnly? DateOperation { get; set; }

    public int? MainOperationId { get; set; }

    public int? AdditionalOperationId { get; set; }

    public int? AccountDt { get; set; }

    public string? SubcontoDt1 { get; set; }

    public int? AccountCr { get; set; }

    public string? SubcontoCr1 { get; set; }

    public decimal? Count { get; set; }

    public string? Comment { get; set; }

    

    public virtual AdditionalOperation? AdditionalOperation { get; set; }

    public virtual MainOperation? MainOperation { get; set; }
}

