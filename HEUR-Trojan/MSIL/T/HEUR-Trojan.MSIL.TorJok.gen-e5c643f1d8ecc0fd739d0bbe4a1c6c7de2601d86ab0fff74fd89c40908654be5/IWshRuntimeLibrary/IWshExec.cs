using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace IWshRuntimeLibrary;

[ComImport]
[Guid("08FED190-BE19-11D3-A28B-00104BD35090")]
[TypeLibType(4160)]
public interface IWshExec
{
	[ComAliasName("IWshRuntimeLibrary.WshExecStatus")]
	[DispId(1)]
	WshExecStatus Status
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1)]
		[return: ComAliasName("IWshRuntimeLibrary.WshExecStatus")]
		get;
	}

	[DispId(3)]
	TextStream StdIn
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(3)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(4)]
	TextStream StdOut
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(4)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(5)]
	TextStream StdErr
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(5)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(6)]
	int ProcessID
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(6)]
		get;
	}

	[DispId(7)]
	int ExitCode
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(7)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(8)]
	void Terminate();
}
