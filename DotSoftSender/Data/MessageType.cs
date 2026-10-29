using System;
using System.Collections.Generic;

namespace DotSoftSender.Data;

public partial class MessageType
{
    public int Id { get; set; }

    public string MessType { get; set; } = null!;

    public virtual ICollection<Tmessage> Tmessages { get; set; } = new List<Tmessage>();
}
