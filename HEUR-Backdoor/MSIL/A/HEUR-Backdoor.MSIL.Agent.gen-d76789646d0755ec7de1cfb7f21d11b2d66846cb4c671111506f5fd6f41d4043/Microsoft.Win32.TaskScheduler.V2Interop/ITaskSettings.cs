using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Win32.TaskScheduler.V2Interop;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsDual)]
[SuppressUnmanagedCodeSecurity]
[Guid("8FD4711D-2D02-4C8C-87E3-EFF699DE127E")]
internal interface ITaskSettings
{
	bool AllowDemandStart
	{
		get; [param: In]
		set;
	}

	string RestartInterval
	{
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	int RestartCount
	{
		get; [param: In]
		set;
	}

	TaskInstancesPolicy MultipleInstances
	{
		get; [param: In]
		set;
	}

	bool StopIfGoingOnBatteries
	{
		get; [param: In]
		set;
	}

	bool DisallowStartIfOnBatteries
	{
		get; [param: In]
		set;
	}

	bool AllowHardTerminate
	{
		get; [param: In]
		set;
	}

	bool StartWhenAvailable
	{
		get; [param: In]
		set;
	}

	string XmlText
	{
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	bool RunOnlyIfNetworkAvailable
	{
		get; [param: In]
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

	bool Enabled
	{
		get; [param: In]
		set;
	}

	string DeleteExpiredTaskAfter
	{
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	int Priority
	{
		get; [param: In]
		set;
	}

	TaskCompatibility Compatibility
	{
		get; [param: In]
		set;
	}

	bool Hidden
	{
		get; [param: In]
		set;
	}

	IIdleSettings IdleSettings
	{
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
		[param: In]
		[param: MarshalAs(UnmanagedType.Interface)]
		set;
	}

	bool RunOnlyIfIdle
	{
		get; [param: In]
		set;
	}

	bool WakeToRun
	{
		get; [param: In]
		set;
	}

	INetworkSettings NetworkSettings
	{
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
		[param: In]
		[param: MarshalAs(UnmanagedType.Interface)]
		set;
	}
}
