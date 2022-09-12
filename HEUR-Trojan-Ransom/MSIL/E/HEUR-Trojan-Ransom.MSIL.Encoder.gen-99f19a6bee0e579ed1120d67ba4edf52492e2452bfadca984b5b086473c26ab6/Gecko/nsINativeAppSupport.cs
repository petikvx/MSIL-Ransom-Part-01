using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("5fdf8480-1f98-11d4-8077-00600811a9c3")]
public interface nsINativeAppSupport
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool Start();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Enable();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool Stop();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Quit();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnLastWindowClosing();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ReOpen();
}
