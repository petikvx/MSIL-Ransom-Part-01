using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Win32.TaskScheduler.V2Interop;

[ComImport]
[Guid("77D025A3-90FA-43AA-B52E-CDA5499B946A")]
[SuppressUnmanagedCodeSecurity]
[InterfaceType(ComInterfaceType.InterfaceIsDual)]
internal interface IMonthlyDOWTrigger : ITrigger
{
	new TaskTriggerType Type { get; }

	new string Id
	{
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	new IRepetitionPattern Repetition
	{
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
		[param: In]
		[param: MarshalAs(UnmanagedType.Interface)]
		set;
	}

	new string ExecutionTimeLimit
	{
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	new string StartBoundary
	{
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	new string EndBoundary
	{
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	new bool Enabled
	{
		get; [param: In]
		set;
	}

	short DaysOfWeek
	{
		get; [param: In]
		set;
	}

	short WeeksOfMonth
	{
		get; [param: In]
		set;
	}

	short MonthsOfYear
	{
		get; [param: In]
		set;
	}

	bool RunOnLastWeekOfMonth
	{
		get; [param: In]
		set;
	}

	string RandomDelay
	{
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}
}
