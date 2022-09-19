using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Win32.TaskScheduler.V2Interop;

[ComImport]
[SuppressUnmanagedCodeSecurity]
[TypeLibType(2)]
[ClassInterface(0)]
[DefaultMember("TargetServer")]
[Guid("0F87369F-A4E5-4CFC-BD3E-73E6154572DD")]
internal class TaskSchedulerClass : ITaskService, TaskScheduler
{
	[DispId(5)]
	public virtual extern bool Connected
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(5)]
		get;
	}

	[DispId(7)]
	public virtual extern string ConnectedDomain
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(7)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(6)]
	public virtual extern string ConnectedUser
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(6)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(8)]
	public virtual extern uint HighestVersion
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(8)]
		get;
	}

	[DispId(0)]
	public virtual extern string TargetServer
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(4)]
	public virtual extern void Connect([Optional][In][MarshalAs(UnmanagedType.Struct)] object serverName, [Optional][In][MarshalAs(UnmanagedType.Struct)] object user, [Optional][In][MarshalAs(UnmanagedType.Struct)] object domain, [Optional][In][MarshalAs(UnmanagedType.Struct)] object password);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1)]
	[return: MarshalAs(UnmanagedType.Interface)]
	public virtual extern ITaskFolder GetFolder([In][MarshalAs(UnmanagedType.BStr)] string Path);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(2)]
	[return: MarshalAs(UnmanagedType.Interface)]
	public virtual extern IRunningTaskCollection GetRunningTasks(int flags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(3)]
	[return: MarshalAs(UnmanagedType.Interface)]
	public virtual extern ITaskDefinition NewTask([In] uint flags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	public extern TaskSchedulerClass();
}
