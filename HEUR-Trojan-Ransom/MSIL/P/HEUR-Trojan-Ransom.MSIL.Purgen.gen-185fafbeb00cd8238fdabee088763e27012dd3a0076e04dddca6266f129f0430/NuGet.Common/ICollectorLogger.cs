using System.Collections.Generic;

namespace NuGet.Common;

public interface ICollectorLogger : ILogger
{
	IEnumerable<IRestoreLogMessage> Errors { get; }
}
