using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Microsoft.Win32.TaskScheduler;

[ComVisible(false)]
[DebuggerStepThrough]
public class NotV1SupportedException : TSNotSupportedException
{
	internal override string LibName => "Task Scheduler 1.0";

	internal NotV1SupportedException()
		: base(TaskCompatibility.V2)
	{
	}

	internal NotV1SupportedException(string message)
		: base(message, TaskCompatibility.V2)
	{
	}
}
