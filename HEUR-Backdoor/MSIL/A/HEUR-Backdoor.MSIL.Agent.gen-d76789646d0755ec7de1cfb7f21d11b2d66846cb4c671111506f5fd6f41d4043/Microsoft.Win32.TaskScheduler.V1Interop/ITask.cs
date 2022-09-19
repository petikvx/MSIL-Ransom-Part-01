using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Win32.TaskScheduler.V1Interop;

[Guid("148BD524-A2AB-11CE-B11F-00AA00530503")]
[SuppressUnmanagedCodeSecurity]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface ITask
{
	[return: MarshalAs(UnmanagedType.Interface)]
	ITaskTrigger CreateTrigger(out ushort NewTriggerIndex);

	void DeleteTrigger([In] ushort TriggerIndex);

	[return: MarshalAs(UnmanagedType.U2)]
	ushort GetTriggerCount();

	[return: MarshalAs(UnmanagedType.Interface)]
	ITaskTrigger GetTrigger([In] ushort TriggerIndex);

	CoTaskMemString GetTriggerString([In] ushort TriggerIndex);

	void GetRunTimes([In][MarshalAs(UnmanagedType.Struct)] ref SystemTime Begin, [In][MarshalAs(UnmanagedType.Struct)] ref SystemTime End, ref ushort Count, [In][Out] ref IntPtr TaskTimes);

	[return: MarshalAs(UnmanagedType.Struct)]
	SystemTime GetNextRunTime();

	void SetIdleWait([In] ushort IdleMinutes, [In] ushort DeadlineMinutes);

	void GetIdleWait(out ushort IdleMinutes, out ushort DeadlineMinutes);

	void Run();

	void Terminate();

	void EditWorkItem([In] IntPtr hParent, [In] uint dwReserved);

	[return: MarshalAs(UnmanagedType.Struct)]
	SystemTime GetMostRecentRunTime();

	TaskStatus GetStatus();

	uint GetExitCode();

	void SetComment([In][MarshalAs(UnmanagedType.LPWStr)] string Comment);

	CoTaskMemString GetComment();

	void SetCreator([In][MarshalAs(UnmanagedType.LPWStr)] string Creator);

	CoTaskMemString GetCreator();

	void SetWorkItemData([In] ushort DataLen, [In][MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1, SizeParamIndex = 0)] byte[] Data);

	void GetWorkItemData(out ushort DataLen, out IntPtr Data);

	void SetErrorRetryCount([In] ushort RetryCount);

	ushort GetErrorRetryCount();

	void SetErrorRetryInterval([In] ushort RetryInterval);

	ushort GetErrorRetryInterval();

	void SetFlags([In] TaskFlags Flags);

	TaskFlags GetFlags();

	void SetAccountInformation([In][MarshalAs(UnmanagedType.LPWStr)] string AccountName, [In] IntPtr Password);

	CoTaskMemString GetAccountInformation();

	void SetApplicationName([In][MarshalAs(UnmanagedType.LPWStr)] string ApplicationName);

	CoTaskMemString GetApplicationName();

	void SetParameters([In][MarshalAs(UnmanagedType.LPWStr)] string Parameters);

	CoTaskMemString GetParameters();

	void SetWorkingDirectory([In][MarshalAs(UnmanagedType.LPWStr)] string WorkingDirectory);

	CoTaskMemString GetWorkingDirectory();

	void SetPriority([In] uint Priority);

	uint GetPriority();

	void SetTaskFlags([In] uint Flags);

	uint GetTaskFlags();

	void SetMaxRunTime([In] uint MaxRunTimeMS);

	uint GetMaxRunTime();
}
