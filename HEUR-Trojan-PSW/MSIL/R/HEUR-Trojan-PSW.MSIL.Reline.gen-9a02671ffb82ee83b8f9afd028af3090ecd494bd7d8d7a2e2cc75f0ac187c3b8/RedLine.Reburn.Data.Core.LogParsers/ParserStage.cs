using RedLine.Reburn.Models.Info;

namespace RedLine.Reburn.Data.Core.LogParsers;

public delegate void ParserStage(ClientSettings settings, ref UserLog userLog);
