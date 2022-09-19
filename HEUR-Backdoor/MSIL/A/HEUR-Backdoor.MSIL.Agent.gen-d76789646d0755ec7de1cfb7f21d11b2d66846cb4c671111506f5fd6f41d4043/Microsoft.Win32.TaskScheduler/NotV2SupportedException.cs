using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Microsoft.Win32.TaskScheduler;

[ComVisible(false)]
[DebuggerStepThrough]
public class NotV2SupportedException : TSNotSupportedException
{
	internal override string LibName => "Task Scheduler 2.0 (1.2)";

	internal NotV2SupportedException()
		: base(TaskCompatibility.V1)
	{
	}

	internal NotV2SupportedException(string message)
		: base(message, TaskCompatibility.V1)
	{
	}
}
