using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Win32.TaskScheduler.V2Interop;

[ComImport]
[DefaultMember("TargetServer")]
[Guid("2FABA4C7-4DA9-4013-9697-20CC3FD40F85")]
[SuppressUnmanagedCodeSecurity]
[TypeLibType(4288)]
internal interface ITaskService
{
	[DispId(5)]
	bool Connected
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(5)]
		get;
	}

	[DispId(0)]
	string TargetServer
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(6)]
	string ConnectedUser
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(6)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(7)]
	string ConnectedDomain
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(7)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(8)]
	uint HighestVersion
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(8)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ITaskFolder GetFolder([In][MarshalAs(UnmanagedType.BStr)] string Path);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(2)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IRunningTaskCollection GetRunningTasks(int flags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(3)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ITaskDefinition NewTask([In] uint flags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(4)]
	void Connect([Optional][In][MarshalAs(UnmanagedType.Struct)] object serverName, [Optional][In][MarshalAs(UnmanagedType.Struct)] object user, [Optional][In][MarshalAs(UnmanagedType.Struct)] object domain, [Optional][In][MarshalAs(UnmanagedType.Struct)] object password);
}
