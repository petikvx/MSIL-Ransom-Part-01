using System.Runtime.InteropServices;

namespace Microsoft.Win32.TaskScheduler;

[ComVisible(false)]
public enum TaskSessionStateChangeType
{
	ConsoleConnect = 1,
	ConsoleDisconnect = 2,
	RemoteConnect = 3,
	RemoteDisconnect = 4,
	SessionLock = 7,
	SessionUnlock = 8
}
