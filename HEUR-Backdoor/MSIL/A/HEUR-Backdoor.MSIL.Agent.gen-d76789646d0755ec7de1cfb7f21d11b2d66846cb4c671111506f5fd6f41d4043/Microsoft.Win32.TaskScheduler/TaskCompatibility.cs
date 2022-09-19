using System.Runtime.InteropServices;

namespace Microsoft.Win32.TaskScheduler;

[ComVisible(false)]
public enum TaskCompatibility
{
	AT,
	V1,
	V2,
	V2_1,
	V2_2
}
