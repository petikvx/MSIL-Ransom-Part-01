using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("7cd5c71d-223b-4afe-931d-5eedb1f2b01f")]
public interface nsIAppShell
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Run();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Exit();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void FavorPerformanceHint([MarshalAs(UnmanagedType.U1)] bool favorPerfOverStarvation, uint starvationDelay);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SuspendNative();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ResumeNative();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetEventloopNestingLevelAttribute();
}
