using System.Runtime.InteropServices;

namespace Microsoft.Win32.TaskScheduler;

[ComVisible(false)]
public enum TaskInstancesPolicy
{
	Parallel,
	Queue,
	IgnoreNew,
	StopExisting
}
