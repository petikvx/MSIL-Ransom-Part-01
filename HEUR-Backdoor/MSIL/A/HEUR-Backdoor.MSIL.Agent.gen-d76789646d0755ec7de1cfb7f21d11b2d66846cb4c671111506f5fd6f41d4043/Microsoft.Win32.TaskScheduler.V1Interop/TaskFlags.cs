using System;

namespace Microsoft.Win32.TaskScheduler.V1Interop;

[Flags]
internal enum TaskFlags
{
	Interactive = 1,
	DeleteWhenDone = 2,
	Disabled = 4,
	StartOnlyIfIdle = 0x10,
	KillOnIdleEnd = 0x20,
	DontStartIfOnBatteries = 0x40,
	KillIfGoingOnBatteries = 0x80,
	RunOnlyIfDocked = 0x100,
	Hidden = 0x200,
	RunIfConnectedToInternet = 0x400,
	RestartOnIdleResume = 0x800,
	SystemRequired = 0x1000,
	RunOnlyIfLoggedOn = 0x2000
}
