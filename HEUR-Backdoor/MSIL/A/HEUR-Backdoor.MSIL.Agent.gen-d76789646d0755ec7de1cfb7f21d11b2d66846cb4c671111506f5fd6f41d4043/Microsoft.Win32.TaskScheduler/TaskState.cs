using System.Runtime.InteropServices;

namespace Microsoft.Win32.TaskScheduler;

[ComVisible(false)]
public enum TaskState
{
	Unknown,
	Disabled,
	Queued,
	Ready,
	Running
}
