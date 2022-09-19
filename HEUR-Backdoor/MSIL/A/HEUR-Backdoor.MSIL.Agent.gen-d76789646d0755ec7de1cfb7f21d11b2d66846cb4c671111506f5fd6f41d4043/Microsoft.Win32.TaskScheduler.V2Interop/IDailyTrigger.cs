using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Win32.TaskScheduler.V2Interop;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsDual)]
[Guid("126C5CD8-B288-41D5-8DBF-E491446ADC5C")]
[SuppressUnmanagedCodeSecurity]
internal interface IDailyTrigger : ITrigger
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

	short DaysInterval
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
