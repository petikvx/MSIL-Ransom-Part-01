using System.Collections.Generic;
using Colla3ing;
using N1grophob1;

namespace Estat8d;

public interface ICollectorLogger : ILogger
{
	IEnumerable<IRestoreLogMessage> Errors { get; }
}
