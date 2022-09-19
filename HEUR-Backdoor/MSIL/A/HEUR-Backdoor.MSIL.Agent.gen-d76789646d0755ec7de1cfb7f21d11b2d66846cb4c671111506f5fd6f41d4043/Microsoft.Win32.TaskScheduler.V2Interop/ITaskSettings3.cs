using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Win32.TaskScheduler.V2Interop;

[ComImport]
[SuppressUnmanagedCodeSecurity]
[InterfaceType(ComInterfaceType.InterfaceIsDual)]
[Guid("0AD9D0D7-0C7F-4EBB-9A5F-D1C648DCA528")]
internal interface ITaskSettings3 : ITaskSettings
{
	new bool AllowDemandStart
	{
		get; [param: In]
		set;
	}

	new string RestartInterval
	{
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	new int RestartCount
	{
		get; [param: In]
		set;
	}

	new TaskInstancesPolicy MultipleInstances
	{
		get; [param: In]
		set;
	}

	new bool StopIfGoingOnBatteries
	{
		get; [param: In]
		set;
	}

	new bool DisallowStartIfOnBatteries
	{
		get; [param: In]
		set;
	}

	new bool AllowHardTerminate
	{
		get; [param: In]
		set;
	}

	new bool StartWhenAvailable
	{
		get; [param: In]
		set;
	}

	new string XmlText
	{
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	new bool RunOnlyIfNetworkAvailable
	{
		get; [param: In]
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

	new bool Enabled
	{
		get; [param: In]
		set;
	}

	new string DeleteExpiredTaskAfter
	{
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	new int Priority
	{
		get; [param: In]
		set;
	}

	new TaskCompatibility Compatibility
	{
		get; [param: In]
		set;
	}

	new bool Hidden
	{
		get; [param: In]
		set;
	}

	new IIdleSettings IdleSettings
	{
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
		[param: In]
		[param: MarshalAs(UnmanagedType.Interface)]
		set;
	}

	new bool RunOnlyIfIdle
	{
		get; [param: In]
		set;
	}

	new bool WakeToRun
	{
		get; [param: In]
		set;
	}

	new INetworkSettings NetworkSettings
	{
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
		[param: In]
		[param: MarshalAs(UnmanagedType.Interface)]
		set;
	}

	bool DisallowStartOnRemoteAppSession
	{
		get; [param: In]
		set;
	}

	bool UseUnifiedSchedulingEngine
	{
		get; [param: In]
		set;
	}

	IMaintenanceSettings MaintenanceSettings
	{
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
		[param: In]
		[param: MarshalAs(UnmanagedType.Interface)]
		set;
	}

	bool Volatile
	{
		get; [param: In]
		set;
	}

	[return: MarshalAs(UnmanagedType.Interface)]
	IMaintenanceSettings CreateMaintenanceSettings();
}
