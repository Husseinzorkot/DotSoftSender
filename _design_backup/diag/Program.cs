using DotSoftSender.Data;
using Microsoft.EntityFrameworkCore;
using var db = new AppDbContext();
Console.WriteLine("MessageType rows:");
foreach (var t in db.MessageTypes.AsNoTracking().ToList()) Console.WriteLine($"  Id={t.Id} MessType={t.MessType}");
Console.WriteLine("Tmessages by MsgTypeId / IsSent / IsError:");
foreach (var g in db.Tmessages.AsNoTracking().GroupBy(m => new { m.MsgTypeId, m.IsSent, m.IsError }).Select(g => new { g.Key, C = g.Count() }).ToList())
  Console.WriteLine($"  MsgTypeId={g.Key.MsgTypeId?.ToString() ?? "null"} IsSent={g.Key.IsSent} IsError={g.Key.IsError} count={g.C}");
Console.WriteLine("Last 5 messages:");
foreach (var m in db.Tmessages.AsNoTracking().OrderByDescending(m => m.IdDr).Take(5).ToList())
  Console.WriteLine($"  Id={m.IdDr} Type={m.MsgTypeId} Sent={m.IsSent} Err={m.IsError} File={m.FilePath}");
