using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Win32.TaskScheduler.V2Interop;

[ComImport]
[Guid("4C8FEC3A-C218-4E0C-B23D-629024DB91A2")]
[SuppressUnmanagedCodeSecurity]
[InterfaceType(ComInterfaceType.InterfaceIsDual)]
internal interface IRegistrationTrigger : ITrigger
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

	string Delay
	{
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}
}
