using System;
using System.Collections.Generic;

namespace DotSoftSender.Data;

public partial class Tmessage
{
    public int IdDr { get; set; }

    public int? DoctorId { get; set;  }

    public string DrName { get; set; } = null!;

    public bool IsSent { get; set; }

    public bool IsError { get; set; }

    public string? ErrorMsg { get; set; }

    public string From { get; set; } = null!;

    public string To { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string RequestNb { get; set; } = null!;

    public string FilePath { get; set; } = null!;

    public int? MsgTypeId { get; set; }

    public virtual MessageType? MsgType { get; set; }
}
