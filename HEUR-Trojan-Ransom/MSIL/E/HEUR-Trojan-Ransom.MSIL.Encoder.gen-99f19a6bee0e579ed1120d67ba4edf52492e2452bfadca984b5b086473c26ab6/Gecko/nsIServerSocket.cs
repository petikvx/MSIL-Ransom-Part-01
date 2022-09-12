using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("7a9c39cb-a13f-4eef-9bdf-a74301628742")]
public interface nsIServerSocket
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init(int aPort, [MarshalAs(UnmanagedType.U1)] bool aLoopbackOnly, int aBackLog);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InitSpecialConnection(int aPort, ulong aFlags, int aBackLog);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InitWithAddress(IntPtr aAddr, int aBackLog);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InitWithFilename([MarshalAs(UnmanagedType.Interface)] nsIFile aPath, uint aPermissions, int aBacklog);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Close();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AsyncListen([MarshalAs(UnmanagedType.Interface)] nsIServerSocketListener aListener);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetPortAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetAddress();
}
