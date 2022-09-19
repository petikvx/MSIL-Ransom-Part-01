using System;

namespace Microsoft.Win32.TaskScheduler.V1Interop;

[Flags]
internal enum TaskTriggerFlags : uint
{
	HasEndDate = 1u,
	KillAtDurationEnd = 2u,
	Disabled = 4u
}
