namespace Microsoft.Win32.TaskScheduler.V1Interop;

internal enum TaskTriggerType
{
	RunOnce,
	RunDaily,
	RunWeekly,
	RunMonthly,
	RunMonthlyDOW,
	OnIdle,
	OnSystemStart,
	OnLogon
}
