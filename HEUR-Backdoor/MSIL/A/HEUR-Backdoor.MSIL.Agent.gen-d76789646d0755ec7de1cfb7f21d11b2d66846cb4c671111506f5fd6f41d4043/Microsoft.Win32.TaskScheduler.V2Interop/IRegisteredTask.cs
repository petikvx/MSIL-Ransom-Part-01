using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using Microsoft.Win32.TaskScheduler.V1Interop;

namespace Microsoft.Win32.TaskScheduler.V2Interop;

[ComImport]
[DefaultMember("Path")]
[Guid("9C86F320-DEE3-4DD1-B972-A303F26B061E")]
[InterfaceType(ComInterfaceType.InterfaceIsDual)]
[SuppressUnmanagedCodeSecurity]
internal interface IRegisteredTask
{
	string Name
	{
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	string Path
	{
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	TaskState State { get; }

	bool Enabled { get; set; }

	DateTime LastRunTime { get; }

	int LastTaskResult { get; }

	int NumberOfMissedRuns { get; }

	DateTime NextRunTime { get; }

	ITaskDefinition Definition
	{
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	string Xml
	{
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[return: MarshalAs(UnmanagedType.Interface)]
	IRunningTask Run([In][MarshalAs(UnmanagedType.Struct)] object parameters);

	[return: MarshalAs(UnmanagedType.Interface)]
	IRunningTask RunEx([In][MarshalAs(UnmanagedType.Struct)] object parameters, [In] int flags, [In] int sessionID, [In][MarshalAs(UnmanagedType.BStr)] string user);

	[return: MarshalAs(UnmanagedType.Interface)]
	IRunningTaskCollection GetInstances(int flags);

	[return: MarshalAs(UnmanagedType.BStr)]
	string GetSecurityDescriptor(int securityInformation);

	void SetSecurityDescriptor([In][MarshalAs(UnmanagedType.BStr)] string sddl, [In] int flags);

	void Stop(int flags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[TypeLibFunc(65)]
	[DispId(1610743825)]
	void GetRunTimes([In] ref SystemTime pstStart, [In] ref SystemTime pstEnd, [In][Out] ref uint pCount, [In][Out] ref IntPtr pRunTimes);
}
