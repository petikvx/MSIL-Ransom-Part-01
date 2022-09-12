using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("AC4A133B-9F92-4F7C-B369-D40CB6B17650")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIGeolocationProvider
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Startup();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Watch([MarshalAs(UnmanagedType.Interface)] nsIGeolocationUpdate callback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Shutdown();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetHighAccuracy([MarshalAs(UnmanagedType.U1)] bool enable);
}
