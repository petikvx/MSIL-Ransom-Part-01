using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Win32.TaskScheduler.V2Interop;

[ComImport]
[Guid("09941815-EA89-4B5B-89E0-2A773801FAC3")]
[SuppressUnmanagedCodeSecurity]
[InterfaceType(ComInterfaceType.InterfaceIsDual)]
internal interface ITrigger
{
	TaskTriggerType Type { get; }

	string Id
	{
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	IRepetitionPattern Repetition
	{
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
		[param: In]
		[param: MarshalAs(UnmanagedType.Interface)]
		set;
	}

	string ExecutionTimeLimit
	{
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	string StartBoundary
	{
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	string EndBoundary
	{
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	bool Enabled
	{
		get; [param: In]
		set;
	}
}
