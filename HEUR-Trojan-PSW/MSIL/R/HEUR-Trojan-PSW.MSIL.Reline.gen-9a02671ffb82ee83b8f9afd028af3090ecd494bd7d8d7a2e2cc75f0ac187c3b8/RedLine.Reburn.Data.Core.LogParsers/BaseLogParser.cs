using RedLine.Reburn.Models.Info;

namespace RedLine.Reburn.Data.Core.LogParsers;

public abstract class BaseLogParser
{
	public abstract bool TryGet(ClientSettings settings, out UserLog userLog);
}
