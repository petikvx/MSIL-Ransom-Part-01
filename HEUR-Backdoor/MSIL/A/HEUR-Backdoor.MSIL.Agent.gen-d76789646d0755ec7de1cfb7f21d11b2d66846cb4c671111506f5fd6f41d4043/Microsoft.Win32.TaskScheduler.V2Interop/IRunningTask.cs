using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Win32.TaskScheduler.V2Interop;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsDual)]
[Guid("653758FB-7B9A-4F1E-A471-BEEB8E9B834E")]
[SuppressUnmanagedCodeSecurity]
[DefaultMember("InstanceGuid")]
internal interface IRunningTask
{
	string Name
	{
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	string InstanceGuid
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

	string CurrentAction
	{
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	uint EnginePID { get; }

	void Stop();

	void Refresh();
}
