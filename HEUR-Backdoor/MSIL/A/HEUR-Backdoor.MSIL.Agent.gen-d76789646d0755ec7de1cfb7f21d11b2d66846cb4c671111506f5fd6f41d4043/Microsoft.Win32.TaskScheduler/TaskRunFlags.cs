using System.Runtime.InteropServices;

namespace Microsoft.Win32.TaskScheduler;

[ComVisible(false)]
public enum TaskRunFlags
{
	AsSelf = 1,
	IgnoreConstraints = 2,
	NoFlags = 0,
	UseSessionId = 4,
	UserSID = 8
}
