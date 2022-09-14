using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace IWshRuntimeLibrary;

[ComImport]
[ClassInterface(0)]
[Guid("08FED191-BE19-11D3-A28B-00104BD35090")]
public sealed class WshExecClass : IWshExec, WshExec
{
	[ComAliasName("IWshRuntimeLibrary.WshExecStatus")]
	[DispId(1)]
	public virtual extern WshExecStatus Status
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1)]
		[return: ComAliasName("IWshRuntimeLibrary.WshExecStatus")]
		get;
	}

	[DispId(3)]
	public virtual extern TextStream StdIn
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(3)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(4)]
	public virtual extern TextStream StdOut
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(4)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(5)]
	public virtual extern TextStream StdErr
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(5)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(6)]
	public virtual extern int ProcessID
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(6)]
		get;
	}

	[DispId(7)]
	public virtual extern int ExitCode
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(7)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	internal extern WshExecClass();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(8)]
	public virtual extern void Terminate();
}
