using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("877ace25-8bc5-452a-8586-9c1cf2871994")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIUpdateChecker
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void CheckForUpdates([MarshalAs(UnmanagedType.Interface)] nsIUpdateCheckListener listener, [MarshalAs(UnmanagedType.U1)] bool force);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void StopChecking(ushort duration);
}
