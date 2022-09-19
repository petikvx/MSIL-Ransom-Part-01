using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Microsoft.Win32.TaskScheduler;

[DebuggerStepThrough]
[ComVisible(false)]
public class NotSupportedPriorToException : TSNotSupportedException
{
	internal override string LibName => $"Task Scheduler versions prior to 2.{(int)(min - 2)} (1.{(int)min})";

	internal NotSupportedPriorToException(TaskCompatibility supportedVersion)
		: base(supportedVersion)
	{
	}
}
