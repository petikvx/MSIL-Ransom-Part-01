using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("7D9B09D9-4843-43EB-A7A7-67F7DDA6B3C4")]
public interface nsIDOMGeoPositionErrorCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void HandleEvent([MarshalAs(UnmanagedType.Interface)] nsIDOMGeoPositionError positionError);
}
