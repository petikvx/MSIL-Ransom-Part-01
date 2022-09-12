using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("527E8B53-6F29-4B6A-8D04-5C1666A4C4C1")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDOMGeoPositionCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void HandleEvent([MarshalAs(UnmanagedType.Interface)] nsIDOMGeoPosition position);
}
