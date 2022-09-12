using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("643dc5e9-b911-4b2c-8d44-603162696baf")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIGeolocationUpdate
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Update([MarshalAs(UnmanagedType.Interface)] nsIDOMGeoPosition position);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void LocationUpdatePending();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void NotifyError(ushort error);
}
